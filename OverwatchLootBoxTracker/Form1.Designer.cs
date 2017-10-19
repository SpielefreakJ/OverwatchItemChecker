namespace OverwatchLootBoxTracker
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
            this.lblKosten = new System.Windows.Forms.Label();
            this.gBLang = new System.Windows.Forms.GroupBox();
            this.btnLangGerman = new System.Windows.Forms.Button();
            this.btnLangEnglish = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.gBLang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKosten
            // 
            this.lblKosten.AutoSize = true;
            this.lblKosten.Location = new System.Drawing.Point(13, 13);
            this.lblKosten.Name = "lblKosten";
            this.lblKosten.Size = new System.Drawing.Size(83, 13);
            this.lblKosten.TabIndex = 0;
            this.lblKosten.Text = "Kosten für Rest:";
            // 
            // gBLang
            // 
            this.gBLang.Controls.Add(this.btnLangEnglish);
            this.gBLang.Controls.Add(this.btnLangGerman);
            this.gBLang.Location = new System.Drawing.Point(684, 455);
            this.gBLang.Name = "gBLang";
            this.gBLang.Size = new System.Drawing.Size(200, 100);
            this.gBLang.TabIndex = 1;
            this.gBLang.TabStop = false;
            this.gBLang.Text = "Change Language";
            this.gBLang.Visible = false;
            // 
            // btnLangGerman
            // 
            this.btnLangGerman.Location = new System.Drawing.Point(7, 20);
            this.btnLangGerman.Name = "btnLangGerman";
            this.btnLangGerman.Size = new System.Drawing.Size(187, 23);
            this.btnLangGerman.TabIndex = 0;
            this.btnLangGerman.Text = "German (Deutsch)";
            this.btnLangGerman.UseVisualStyleBackColor = true;
            this.btnLangGerman.Click += new System.EventHandler(this.btnLangGerman_Click);
            // 
            // btnLangEnglish
            // 
            this.btnLangEnglish.Location = new System.Drawing.Point(7, 49);
            this.btnLangEnglish.Name = "btnLangEnglish";
            this.btnLangEnglish.Size = new System.Drawing.Size(187, 23);
            this.btnLangEnglish.TabIndex = 1;
            this.btnLangEnglish.Text = "English";
            this.btnLangEnglish.UseVisualStyleBackColor = true;
            this.btnLangEnglish.Click += new System.EventHandler(this.btnLangEnglish_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 532);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(84, 23);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Einstellungen";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 567);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.gBLang);
            this.Controls.Add(this.lblKosten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gBLang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKosten;
        private System.Windows.Forms.GroupBox gBLang;
        private System.Windows.Forms.Button btnLangEnglish;
        private System.Windows.Forms.Button btnLangGerman;
        private System.Windows.Forms.Button btnSettings;
    }
}

