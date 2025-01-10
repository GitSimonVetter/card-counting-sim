namespace card_counting_sim
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLearn = new System.Windows.Forms.Button();
            this.btSimulate = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.lbBlackjack = new System.Windows.Forms.Label();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.cbInsuranceSettings = new System.Windows.Forms.CheckBox();
            this.cbTrueCountSettings = new System.Windows.Forms.CheckBox();
            this.cbRunningCountSettings = new System.Windows.Forms.CheckBox();
            this.cbSurrenderSettings = new System.Windows.Forms.CheckBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.btStartRound = new System.Windows.Forms.Button();
            this.lblPlayerHand = new System.Windows.Forms.Label();
            this.btHit = new System.Windows.Forms.Button();
            this.pnSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLearn
            // 
            this.btLearn.Location = new System.Drawing.Point(602, 317);
            this.btLearn.Name = "btLearn";
            this.btLearn.Size = new System.Drawing.Size(145, 63);
            this.btLearn.TabIndex = 0;
            this.btLearn.Text = "Learn";
            this.btLearn.UseVisualStyleBackColor = true;
            this.btLearn.Click += new System.EventHandler(this.btLearn_Click);
            // 
            // btSimulate
            // 
            this.btSimulate.Location = new System.Drawing.Point(451, 317);
            this.btSimulate.Name = "btSimulate";
            this.btSimulate.Size = new System.Drawing.Size(145, 63);
            this.btSimulate.TabIndex = 1;
            this.btSimulate.Text = "Simulate";
            this.btSimulate.UseVisualStyleBackColor = true;
            this.btSimulate.Click += new System.EventHandler(this.btSimulate_Click);
            // 
            // btSettings
            // 
            this.btSettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSettings.Location = new System.Drawing.Point(42, 317);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(145, 63);
            this.btSettings.TabIndex = 2;
            this.btSettings.Text = "Settings";
            this.btSettings.UseVisualStyleBackColor = false;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // lbBlackjack
            // 
            this.lbBlackjack.AutoSize = true;
            this.lbBlackjack.Location = new System.Drawing.Point(12, 9);
            this.lbBlackjack.Name = "lbBlackjack";
            this.lbBlackjack.Size = new System.Drawing.Size(54, 13);
            this.lbBlackjack.TabIndex = 3;
            this.lbBlackjack.Text = "Blackjack";
            // 
            // pnSettings
            // 
            this.pnSettings.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnSettings.Controls.Add(this.cbSurrenderSettings);
            this.pnSettings.Controls.Add(this.cbRunningCountSettings);
            this.pnSettings.Controls.Add(this.cbTrueCountSettings);
            this.pnSettings.Controls.Add(this.cbInsuranceSettings);
            this.pnSettings.Location = new System.Drawing.Point(309, 35);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(479, 403);
            this.pnSettings.TabIndex = 4;
            this.pnSettings.Visible = false;
            // 
            // cbInsuranceSettings
            // 
            this.cbInsuranceSettings.AutoSize = true;
            this.cbInsuranceSettings.Location = new System.Drawing.Point(32, 33);
            this.cbInsuranceSettings.Name = "cbInsuranceSettings";
            this.cbInsuranceSettings.Size = new System.Drawing.Size(73, 17);
            this.cbInsuranceSettings.TabIndex = 0;
            this.cbInsuranceSettings.Text = "Insurance";
            this.cbInsuranceSettings.UseVisualStyleBackColor = true;
            this.cbInsuranceSettings.CheckStateChanged += new System.EventHandler(this.cbInsuranceSettings_CheckStateChanged);
            // 
            // cbTrueCountSettings
            // 
            this.cbTrueCountSettings.AutoSize = true;
            this.cbTrueCountSettings.Location = new System.Drawing.Point(32, 56);
            this.cbTrueCountSettings.Name = "cbTrueCountSettings";
            this.cbTrueCountSettings.Size = new System.Drawing.Size(79, 17);
            this.cbTrueCountSettings.TabIndex = 1;
            this.cbTrueCountSettings.Text = "True Count";
            this.cbTrueCountSettings.UseVisualStyleBackColor = true;
            // 
            // cbRunningCountSettings
            // 
            this.cbRunningCountSettings.AutoSize = true;
            this.cbRunningCountSettings.Location = new System.Drawing.Point(32, 79);
            this.cbRunningCountSettings.Name = "cbRunningCountSettings";
            this.cbRunningCountSettings.Size = new System.Drawing.Size(97, 17);
            this.cbRunningCountSettings.TabIndex = 2;
            this.cbRunningCountSettings.Text = "Running Count";
            this.cbRunningCountSettings.UseVisualStyleBackColor = true;
            // 
            // cbSurrenderSettings
            // 
            this.cbSurrenderSettings.AutoSize = true;
            this.cbSurrenderSettings.Location = new System.Drawing.Point(32, 102);
            this.cbSurrenderSettings.Name = "cbSurrenderSettings";
            this.cbSurrenderSettings.Size = new System.Drawing.Size(72, 17);
            this.cbSurrenderSettings.TabIndex = 3;
            this.cbSurrenderSettings.Text = "Surrender";
            this.cbSurrenderSettings.UseVisualStyleBackColor = true;
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(31, 72);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(13, 13);
            this.lbBalance.TabIndex = 5;
            this.lbBalance.Text = "0";
            // 
            // btStartRound
            // 
            this.btStartRound.Location = new System.Drawing.Point(42, 149);
            this.btStartRound.Name = "btStartRound";
            this.btStartRound.Size = new System.Drawing.Size(75, 23);
            this.btStartRound.TabIndex = 6;
            this.btStartRound.Text = "StartRound";
            this.btStartRound.UseVisualStyleBackColor = true;
            // 
            // lblPlayerHand
            // 
            this.lblPlayerHand.AutoSize = true;
            this.lblPlayerHand.Location = new System.Drawing.Point(163, 72);
            this.lblPlayerHand.Name = "lblPlayerHand";
            this.lblPlayerHand.Size = new System.Drawing.Size(33, 13);
            this.lblPlayerHand.TabIndex = 7;
            this.lblPlayerHand.Text = "Hand";
            // 
            // btHit
            // 
            this.btHit.Location = new System.Drawing.Point(137, 149);
            this.btHit.Name = "btHit";
            this.btHit.Size = new System.Drawing.Size(75, 23);
            this.btHit.TabIndex = 8;
            this.btHit.Text = "Hit";
            this.btHit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btHit);
            this.Controls.Add(this.lblPlayerHand);
            this.Controls.Add(this.btStartRound);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.pnSettings);
            this.Controls.Add(this.btSimulate);
            this.Controls.Add(this.lbBlackjack);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.btLearn);
            this.Name = "Form1";
            this.Text = "Card Counting Sim";
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLearn;
        private System.Windows.Forms.Button btSimulate;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Label lbBlackjack;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.CheckBox cbSurrenderSettings;
        private System.Windows.Forms.CheckBox cbRunningCountSettings;
        private System.Windows.Forms.CheckBox cbTrueCountSettings;
        private System.Windows.Forms.CheckBox cbInsuranceSettings;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Button btStartRound;
        private System.Windows.Forms.Label lblPlayerHand;
        private System.Windows.Forms.Button btHit;
    }
}

