using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card_counting_sim
{
    public partial class Form1 : Form
    {
        private Game game;
        public Form1()
        {
            InitializeComponent();
        }
        
        bool insurance = false;
        private void btSettings_Click(object sender, EventArgs e)
        {
            if (pnSettings.Visible)
            {
                pnSettings.Hide();
            }
            else
            { 
                pnSettings.Show(); 
            }
        }

        private void btLearn_Click(object sender, EventArgs e)
        {

        }

        private void cbInsuranceSettings_CheckStateChanged(object sender, EventArgs e)
        {
            if(cbInsuranceSettings.Checked)
            {
                insurance = true;
            }
            else if(!cbInsuranceSettings.Checked)
            {
                insurance = false;
            }
            Console.WriteLine("Settings Changed Insurance: " + insurance);
        }

        private void btSimulate_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            string playerName = "John"; // Beispielname
            decimal initialBalance = 1000m;
            game = new Game(playerName, initialBalance, 1); // 1 Deck
            UpdateUI();
        }
        private void UpdateUI()
        {
            // Hier kannst du das UI basierend auf der Balance und Hand des Spielers aktualisieren.
            lbBalance.Text = $"Balance: {game.PlayerHands[0].Balance:C}";
            lbPlayerHand.Text = $"Hand: {game.PlayerHands[0].PlayerHand}";
            // Weitere UI-Aktualisierungen, z.B. für die Anzeige der Karten
        }
        private void btStartRound_Click(object sender, EventArgs e)
        {
            // Beispiel für das Platzieren einer Wette und Starten einer neuen Runde
            decimal betAmount = 100m; // Beispielbetrag
            game.StartNewRound(betAmount, 1); // 1 Hand
            UpdateUI();
        }
    }
}
