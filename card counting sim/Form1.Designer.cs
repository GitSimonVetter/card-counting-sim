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
            this.SuspendLayout();
            // 
            // btLearn
            // 
            this.btLearn.Location = new System.Drawing.Point(42, 40);
            this.btLearn.Name = "btLearn";
            this.btLearn.Size = new System.Drawing.Size(145, 63);
            this.btLearn.TabIndex = 0;
            this.btLearn.Text = "Learn";
            this.btLearn.UseVisualStyleBackColor = true;
            // 
            // btSimulate
            // 
            this.btSimulate.Location = new System.Drawing.Point(82, 141);
            this.btSimulate.Name = "btSimulate";
            this.btSimulate.Size = new System.Drawing.Size(145, 63);
            this.btSimulate.TabIndex = 1;
            this.btSimulate.Text = "Simulate";
            this.btSimulate.UseVisualStyleBackColor = true;
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
            this.lbBlackjack.Location = new System.Drawing.Point(214, 90);
            this.lbBlackjack.Name = "lbBlackjack";
            this.lbBlackjack.Size = new System.Drawing.Size(54, 13);
            this.lbBlackjack.TabIndex = 3;
            this.lbBlackjack.Text = "Blackjack";
            // 
            // pnSettings
            // 
            this.pnSettings.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnSettings.Location = new System.Drawing.Point(274, 35);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(479, 403);
            this.pnSettings.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLearn);
            this.Controls.Add(this.btSimulate);
            this.Controls.Add(this.lbBlackjack);
            this.Controls.Add(this.pnSettings);
            this.Controls.Add(this.btSettings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLearn;
        private System.Windows.Forms.Button btSimulate;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Label lbBlackjack;
        private System.Windows.Forms.Panel pnSettings;
    }
}

