using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace card_counting_sim
{
    public class Game
    {
        public List<Player> PlayerHands { get; private set; }  // Sichtbarkeit geändert, jetzt öffentlich
        private Player Dealer;
        private Deck Deck;

        // Konstruktor zum Initialisieren des Spiels
        public Game(string playerName, decimal initialBalance, int numberOfDecks = 1)
        {
            Deck = new Deck(numberOfDecks);
            PlayerHands = new List<Player> { new Player(playerName, initialBalance) };
            Dealer = new Player("Dealer", 0);
        }

        // Methode zum Starten einer neuen Runde mit mehreren Händen
        public void StartNewRound(decimal betAmount, int numberOfHands)
        {
            PlayerHands.Clear();
            for (int i = 0; i < numberOfHands; i++)
            {
                Player newHand = new Player($"Hand {i + 1}", PlayerHands[0].Balance);
                if (newHand.PlaceBet(betAmount))
                {
                    PlayerHands.Add(newHand);
                }
                else
                {
                    Console.WriteLine($"Nicht genügend Guthaben für Hand {i + 1}. Diese Hand wird nicht gespielt.");
                    break;
                }
            }

            Dealer.ResetHand();
            

            foreach (var player in PlayerHands)
            {
                player.ResetHand();
                player.Hit(Deck.DrawCard());
            }
            Dealer.Hit(Deck.DrawCard());
            foreach (var player in PlayerHands)
            {
                player.Hit(Deck.DrawCard());

                Console.WriteLine($"{player.Name} Hand: {player.PlayerHand}");
            }
            Dealer.Hit(Deck.DrawCard());

            Console.WriteLine($"Dealer zeigt: {(Dealer.PlayerHand.GetCardCount() > 1 ? Dealer.PlayerHand.ToString().Split(',')[0] : Dealer.PlayerHand.ToString())}");
        }

        // Methode für den Spielzug des Spielers
        public void PlayerTurns()
        {
            foreach (var player in PlayerHands)
            {
                Console.WriteLine($"\nSpielzug für {player.Name}");

                while (!player.PlayerHand.IsBusted())
                {
                    Console.WriteLine($"{player.Name} Hand: {player.PlayerHand}");
                    Console.WriteLine("Hit oder Stand? (H/S)");
                    string choice = Console.ReadLine().Trim().ToUpper();
                    if (choice == "H")
                    {
                        player.Hit(Deck.DrawCard());
                    }
                    else if (choice == "S")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe, bitte 'H' für Hit oder 'S' für Stand eingeben.");
                    }
                }

                if (player.PlayerHand.IsBusted())
                {
                    Console.WriteLine($"{player.Name} ist über 21! Diese Hand verliert.");
                }
            }
        }

        // Methode für den Spielzug des Dealers
        public void DealerTurn()
        {
            Console.WriteLine($"Dealerhand: {Dealer.PlayerHand}");
            while (Dealer.PlayerHand.GetTotalValue() < 17)
            {
                Dealer.Hit(Deck.DrawCard());
                Console.WriteLine($"Dealer zieht Karte: {Dealer.PlayerHand}");
            }

            if (Dealer.PlayerHand.IsBusted())
            {
                Console.WriteLine("Dealer ist über 21!");
            }
        }

        // Methode zum Abschluss der Runde und Bestimmung der Gewinner
        public void DetermineWinners()
        {
            foreach (var player in PlayerHands)
            {
                if (player.PlayerHand.IsBusted())
                {
                    continue;
                }

                if (Dealer.PlayerHand.IsBusted() || player.PlayerHand.GetTotalValue() > Dealer.PlayerHand.GetTotalValue())
                {
                    // Wenn der Spieler ein Blackjack hat (21 Punkte mit 2 Karten)
                    if (player.PlayerHand.GetTotalValue() == 21 && player.PlayerHand.GetCardCount() == 2)
                    {
                        Console.WriteLine($"{player.Name} gewinnt mit Blackjack!");
                        player.WinBlackjack();  // 3:2 Auszahlung bei Blackjack
                    }
                    else
                    {
                        Console.WriteLine($"{player.Name} gewinnt!");
                        player.Win();  // Normale Auszahlung bei Sieg
                    }
                }
                else if (player.PlayerHand.GetTotalValue() == Dealer.PlayerHand.GetTotalValue())
                {
                    Console.WriteLine($"{player.Name} spielt unentschieden.");
                    player.Push();  // Unentschieden (Push) - Der Einsatz wird zurückgegeben
                }
                else
                {
                    Console.WriteLine($"{player.Name} verliert.");
                }
            }
        }
    }
}
