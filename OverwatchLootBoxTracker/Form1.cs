using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Code by Justin SpielefreakJ
 * (c) 2017
 */

namespace OverwatchLootBoxTracker
{
    public partial class Form1 : Form
    {
        IniStream inisSettings = null;
        CLang Lang;
        string Language;

        public Form1()
        {
            InitializeComponent();
            KlassenInst();
            ChangePos();

            //Auslesen der "Settings.ini" Datei und speichern in IniStream inisSettings
            inisSettings = new IniStream("Settings.ini");

            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            IniRead();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            MessageBox.Show(Lang.AppClose);
            IniSave();
        }

        private void IniSave()
        {
            //Speichern der änderrung unter "Color" in der Settings.ini
            inisSettings.Write("Lang", Language);
        }

        private void IniRead()
        {
            //Farbe auslesen und auf dem Hintergrund anwenden
            Language = inisSettings.Read("Lang");
            Lang.ChangeLang = Language;

            Texte();
        }

        private void KlassenInst()
        {
            Lang = new CLang(Language);
        }

        private void Texte()
        {
            //Erste mal ausrechnen, wieviel alles zusammen Kostet
            lblKosten.Text = Lang.Remaining;
            gbAll.Visible = false;
            gBLang.Visible = false;

            btnSettings.Text = Lang.Settingsbutton;
            gBLang.Text = Lang.LangChangeBox;

            btnSkins.Text = Lang.Skins;
            btnEmotes.Text = Lang.Emotes;
            btnVictoryPoses.Text = Lang.VictoryPoses;
            btnVoiceLines.Text = Lang.VoiceLines;
            btnSprays.Text = Lang.Sprays;
            btnHighlightIntros.Text = Lang.HighlightIntros;
            btnWeapons.Text = Lang.Weapons;
            btnPlayerIcons.Text = Lang.PlayerIcons;

            lblMoreInfoCost.Text = Lang.RemMoreInfo1;
            lblMoreInfoCost2.Text = Lang.RemMoreInfo2;
        }

        private void ChangePos()
        {
            gBLang.Location = new Point(684, 600);
            gbAll.Location = new Point(122, 29);
            gBMoreCost.Location = new Point(16, 29);
        }

        /*
        //Ab hier beginnt der richtige Code
        */

        private void btnLangGerman_Click(object sender, EventArgs e)
        {
            Language = "DE";
            Lang.ChangeLang = Language;
            Texte();
        }

        private void btnLangEnglish_Click(object sender, EventArgs e)
        {
            Language = "EN";
            Lang.ChangeLang = Language;
            Texte();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            gBLang.Visible = !gBLang.Visible;
            gBLang.BringToFront();
        }

        private void btnSkins_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.Skins)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
            }

            gbAll.Text = Lang.Skins;
        }

        private void btnEmotes_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.Emotes)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
            }

            gbAll.Text = Lang.Emotes;
        }

        private void btnVictoryPoses_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.VictoryPoses)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
            }

            gbAll.Text = Lang.VictoryPoses;
        }

        private void btnVoiceLines_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.VoiceLines)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
            }

            gbAll.Text = Lang.VoiceLines;
        }

        private void btnSprays_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.Sprays)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
            }

            gbAll.Text = Lang.Sprays;
        }

        private void btnHighlightIntros_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.HighlightIntros)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
            }

            gbAll.Text = Lang.HighlightIntros;
        }

        private void btnWeapons_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.Weapons)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
            }

            gbAll.Text = Lang.Weapons;
        }

        private void btnPlayerIcons_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.PlayerIcons)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
            }

            gbAll.Text = Lang.PlayerIcons;
        }

        private void btnMoreCost_Click(object sender, EventArgs e)
        {
            if (btnMoreCost.Text == Lang.Close)
            {
                gBMoreCost.Visible = false;
                btnMoreCost.Text = Lang.MoreCost;
            }
            else
            {
                gBMoreCost.Visible = true;
                btnMoreCost.Text = Lang.Close;
                gBLang.Visible = false;
            }
        }
    }
}
