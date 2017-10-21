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
            this.btnLangEnglish = new System.Windows.Forms.Button();
            this.btnLangGerman = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSkins = new System.Windows.Forms.Button();
            this.btnEmotes = new System.Windows.Forms.Button();
            this.btnVictoryPoses = new System.Windows.Forms.Button();
            this.btnVoiceLines = new System.Windows.Forms.Button();
            this.btnSprays = new System.Windows.Forms.Button();
            this.btnHighlightIntros = new System.Windows.Forms.Button();
            this.btnWeapons = new System.Windows.Forms.Button();
            this.btnPlayerIcons = new System.Windows.Forms.Button();
            this.gbAll = new System.Windows.Forms.GroupBox();
            this.btnMoreCost = new System.Windows.Forms.Button();
            this.gBMoreCost = new System.Windows.Forms.GroupBox();
            this.lblMoreInfoCost2 = new System.Windows.Forms.Label();
            this.lblMoreInfoCost = new System.Windows.Forms.Label();
            this.gBLang.SuspendLayout();
            this.gbAll.SuspendLayout();
            this.gBMoreCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKosten
            // 
            this.lblKosten.AutoSize = true;
            this.lblKosten.Location = new System.Drawing.Point(13, 13);
            this.lblKosten.Name = "lblKosten";
            this.lblKosten.Size = new System.Drawing.Size(50, 13);
            this.lblKosten.TabIndex = 0;
            this.lblKosten.Text = "lblKosten";
            // 
            // gBLang
            // 
            this.gBLang.Controls.Add(this.btnLangEnglish);
            this.gBLang.Controls.Add(this.btnLangGerman);
            this.gBLang.Location = new System.Drawing.Point(856, 677);
            this.gBLang.Name = "gBLang";
            this.gBLang.Size = new System.Drawing.Size(200, 100);
            this.gBLang.TabIndex = 1;
            this.gBLang.TabStop = false;
            this.gBLang.Text = "Sprache Ändern";
            this.gBLang.Visible = false;
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
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(32, 677);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(84, 23);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Einstellungen";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSkins
            // 
            this.btnSkins.Location = new System.Drawing.Point(16, 29);
            this.btnSkins.Name = "btnSkins";
            this.btnSkins.Size = new System.Drawing.Size(100, 75);
            this.btnSkins.TabIndex = 3;
            this.btnSkins.Text = "Skins";
            this.btnSkins.UseVisualStyleBackColor = true;
            this.btnSkins.Click += new System.EventHandler(this.btnSkins_Click);
            // 
            // btnEmotes
            // 
            this.btnEmotes.Location = new System.Drawing.Point(16, 110);
            this.btnEmotes.Name = "btnEmotes";
            this.btnEmotes.Size = new System.Drawing.Size(100, 75);
            this.btnEmotes.TabIndex = 4;
            this.btnEmotes.Text = "Emotes";
            this.btnEmotes.UseVisualStyleBackColor = true;
            this.btnEmotes.Click += new System.EventHandler(this.btnEmotes_Click);
            // 
            // btnVictoryPoses
            // 
            this.btnVictoryPoses.Location = new System.Drawing.Point(16, 191);
            this.btnVictoryPoses.Name = "btnVictoryPoses";
            this.btnVictoryPoses.Size = new System.Drawing.Size(100, 75);
            this.btnVictoryPoses.TabIndex = 5;
            this.btnVictoryPoses.Text = "Vicoty Poses";
            this.btnVictoryPoses.UseVisualStyleBackColor = true;
            this.btnVictoryPoses.Click += new System.EventHandler(this.btnVictoryPoses_Click);
            // 
            // btnVoiceLines
            // 
            this.btnVoiceLines.Location = new System.Drawing.Point(16, 272);
            this.btnVoiceLines.Name = "btnVoiceLines";
            this.btnVoiceLines.Size = new System.Drawing.Size(100, 75);
            this.btnVoiceLines.TabIndex = 6;
            this.btnVoiceLines.Text = "Voice Lines";
            this.btnVoiceLines.UseVisualStyleBackColor = true;
            this.btnVoiceLines.Click += new System.EventHandler(this.btnVoiceLines_Click);
            // 
            // btnSprays
            // 
            this.btnSprays.Location = new System.Drawing.Point(16, 353);
            this.btnSprays.Name = "btnSprays";
            this.btnSprays.Size = new System.Drawing.Size(100, 75);
            this.btnSprays.TabIndex = 7;
            this.btnSprays.Text = "Sprays";
            this.btnSprays.UseVisualStyleBackColor = true;
            this.btnSprays.Click += new System.EventHandler(this.btnSprays_Click);
            // 
            // btnHighlightIntros
            // 
            this.btnHighlightIntros.Location = new System.Drawing.Point(16, 434);
            this.btnHighlightIntros.Name = "btnHighlightIntros";
            this.btnHighlightIntros.Size = new System.Drawing.Size(100, 75);
            this.btnHighlightIntros.TabIndex = 8;
            this.btnHighlightIntros.Text = "Highlight Intros";
            this.btnHighlightIntros.UseVisualStyleBackColor = true;
            this.btnHighlightIntros.Click += new System.EventHandler(this.btnHighlightIntros_Click);
            // 
            // btnWeapons
            // 
            this.btnWeapons.Location = new System.Drawing.Point(16, 515);
            this.btnWeapons.Name = "btnWeapons";
            this.btnWeapons.Size = new System.Drawing.Size(100, 75);
            this.btnWeapons.TabIndex = 10;
            this.btnWeapons.Text = "Weapons";
            this.btnWeapons.UseVisualStyleBackColor = true;
            this.btnWeapons.Click += new System.EventHandler(this.btnWeapons_Click);
            // 
            // btnPlayerIcons
            // 
            this.btnPlayerIcons.Location = new System.Drawing.Point(16, 596);
            this.btnPlayerIcons.Name = "btnPlayerIcons";
            this.btnPlayerIcons.Size = new System.Drawing.Size(100, 75);
            this.btnPlayerIcons.TabIndex = 11;
            this.btnPlayerIcons.Text = "Player Icons";
            this.btnPlayerIcons.UseVisualStyleBackColor = true;
            this.btnPlayerIcons.Click += new System.EventHandler(this.btnPlayerIcons_Click);
            // 
            // gbAll
            // 
            this.gbAll.Controls.Add(this.gBMoreCost);
            this.gbAll.Location = new System.Drawing.Point(122, 29);
            this.gbAll.Name = "gbAll";
            this.gbAll.Size = new System.Drawing.Size(762, 671);
            this.gbAll.TabIndex = 12;
            this.gbAll.TabStop = false;
            this.gbAll.Text = "gbAll";
            this.gbAll.Visible = false;
            // 
            // btnMoreCost
            // 
            this.btnMoreCost.Location = new System.Drawing.Point(711, 8);
            this.btnMoreCost.Name = "btnMoreCost";
            this.btnMoreCost.Size = new System.Drawing.Size(167, 23);
            this.btnMoreCost.TabIndex = 13;
            this.btnMoreCost.Text = "btnMoreCost";
            this.btnMoreCost.UseVisualStyleBackColor = true;
            this.btnMoreCost.Click += new System.EventHandler(this.btnMoreCost_Click);
            // 
            // gBMoreCost
            // 
            this.gBMoreCost.Controls.Add(this.lblMoreInfoCost2);
            this.gBMoreCost.Controls.Add(this.lblMoreInfoCost);
            this.gBMoreCost.Location = new System.Drawing.Point(410, 258);
            this.gBMoreCost.Name = "gBMoreCost";
            this.gBMoreCost.Size = new System.Drawing.Size(868, 671);
            this.gBMoreCost.TabIndex = 0;
            this.gBMoreCost.TabStop = false;
            this.gBMoreCost.Text = "gBMoreCost";
            this.gBMoreCost.Visible = false;
            // 
            // lblMoreInfoCost2
            // 
            this.lblMoreInfoCost2.AutoSize = true;
            this.lblMoreInfoCost2.Location = new System.Drawing.Point(658, 62);
            this.lblMoreInfoCost2.Name = "lblMoreInfoCost2";
            this.lblMoreInfoCost2.Size = new System.Drawing.Size(86, 13);
            this.lblMoreInfoCost2.TabIndex = 1;
            this.lblMoreInfoCost2.Text = "lblMoreInfoCost2";
            this.lblMoreInfoCost2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMoreInfoCost
            // 
            this.lblMoreInfoCost.AutoSize = true;
            this.lblMoreInfoCost.Location = new System.Drawing.Point(112, 62);
            this.lblMoreInfoCost.Name = "lblMoreInfoCost";
            this.lblMoreInfoCost.Size = new System.Drawing.Size(80, 13);
            this.lblMoreInfoCost.TabIndex = 0;
            this.lblMoreInfoCost.Text = "lblMoreInfoCost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(896, 712);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnMoreCost);
            this.Controls.Add(this.gBLang);
            this.Controls.Add(this.gbAll);
            this.Controls.Add(this.btnPlayerIcons);
            this.Controls.Add(this.btnWeapons);
            this.Controls.Add(this.btnHighlightIntros);
            this.Controls.Add(this.btnSprays);
            this.Controls.Add(this.btnVoiceLines);
            this.Controls.Add(this.btnVictoryPoses);
            this.Controls.Add(this.btnEmotes);
            this.Controls.Add(this.btnSkins);
            this.Controls.Add(this.lblKosten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gBLang.ResumeLayout(false);
            this.gbAll.ResumeLayout(false);
            this.gBMoreCost.ResumeLayout(false);
            this.gBMoreCost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKosten;
        private System.Windows.Forms.GroupBox gBLang;
        private System.Windows.Forms.Button btnLangEnglish;
        private System.Windows.Forms.Button btnLangGerman;
        private System.Windows.Forms.Button btnSkins;
        private System.Windows.Forms.Button btnEmotes;
        private System.Windows.Forms.Button btnVictoryPoses;
        private System.Windows.Forms.Button btnVoiceLines;
        private System.Windows.Forms.Button btnSprays;
        private System.Windows.Forms.Button btnHighlightIntros;
        private System.Windows.Forms.Button btnWeapons;
        private System.Windows.Forms.Button btnPlayerIcons;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox gbAll;
        private System.Windows.Forms.Button btnMoreCost;
        private System.Windows.Forms.GroupBox gBMoreCost;
        private System.Windows.Forms.Label lblMoreInfoCost;
        private System.Windows.Forms.Label lblMoreInfoCost2;
    }
}

