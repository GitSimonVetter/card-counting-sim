using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_counting_sim
{
    public class Player
    {
        public string Name { get; private set; }
        public Hand PlayerHand { get; private set; }
        public decimal Balance { get; set; }  // Sichtbarkeit geändert, jetzt öffentlich modifizierbar
        public decimal CurrentBet { get; private set; }

        // Konstruktor
        public Player(string name, decimal initialBalance)
        {
            Name = name;
            Balance = initialBalance;
            PlayerHand = new Hand();
        }

        // Methode zum Platzieren einer Wette
        public bool PlaceBet(decimal betAmount)
        {
            if (betAmount <= Balance)
            {
                CurrentBet = betAmount;
                Balance -= betAmount; // Reduziert das Guthaben des Spielers um den Wetteinsatz
                return true;
            }
            return false; // Nicht genug Guthaben
        }

        // Methode zur Aktualisierung des Guthabens nach einem Gewinn
        public void Win()
        {
            Balance += CurrentBet * 2; // Wenn der Spieler gewinnt, erhält er den doppelten Einsatz zurück
            ResetBet();
        }

        // Methode zur Auszahlung eines Blackjack-Gewinns (3:2 Auszahlung)
        public void WinBlackjack()
        {
            Balance += CurrentBet * 2.5m; // Blackjack-Auszahlung (3:2)
            ResetBet();
        }

        // Methode zur Rücksetzung des Einsatzes
        private void ResetBet()
        {
            CurrentBet = 0;
        }

        // Methode zur Rücksetzung der Hand (für die nächste Runde)
        public void ResetHand()
        {
            PlayerHand = new Hand();
        }

        // Methode zum Hinzufügen einer Karte zur Hand des Spielers
        public void Hit(Card card)
        {
            PlayerHand.AddCard(card); // Fügt der Hand des Spielers eine neue Karte hinzu
        }

        // Methode zur Handhabung des Push-Szenarios (Unentschieden)
        public void Push()
        {
            Balance += CurrentBet;  // Der Einsatz wird dem Guthaben wieder hinzugefügt, der Spieler verliert nicht
            ResetBet();  // Setzt den aktuellen Einsatz zurück
        }

        public override string ToString()
        {
            return $"{Name}: Balance = {Balance:C}, Hand = {PlayerHand}, Total Value = {PlayerHand.GetTotalValue()}";
        }
    }


}
