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
        CCost Cost;
        Translate.L_Translate Transl;
        Translate.L_Ana iAna;
        Translate.L_Bastion iBastion;
        Translate.L_DVa iDVa;
        Translate.L_Doomfist iDoomfist;
        Translate.L_Genji iGenji;
        Translate.L_Hanzo iHanzo;
        Translate.L_Junkrat iJunkrat;
        Translate.L_Lúcio iLúcio;
        Translate.L_McCree iMcCree;
        Translate.L_Mei iMei;
        Translate.L_Mercy iMercy;
        Translate.L_Orisa iOrisa;
        Translate.L_Pharah iPharah;
        Translate.L_Reaper iReaper;
        Translate.L_Reinhardt iReinhardt;
        Translate.L_Roadhog iRoadhog;
        Translate.L_Soldier_76 iSoldier_76;
        Translate.L_Sombra iSombra;
        Translate.L_Symmetra iSymmetra;
        Translate.L_Torbjörn iTorbjörn;
        Translate.L_Tracer iTracer;
        Translate.L_Widowmaker iWidowmaker;
        Translate.L_Winston iWinston;
        Translate.L_Zarya iZarya;
        Translate.L_Zenyatta iZenyatta;
        string Language;

        public Form1()
        {
            InitializeComponent();
            KlassenInst();
            ChangePos();
            this.Width = 912; this.Height = 751;

            //Auslesen der "Settings.ini" Datei und speichern in IniStream inisSettings
            inisSettings = new IniStream("Settings.ini");

            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            IniRead();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            MessageBox.Show(Transl.AppClose);
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
            Transl.ChangeLang = Language;

            Texte();
        }

        private void KlassenInst()
        {
            Cost = new CCost();
            Transl = new Translate.L_Translate(Language);
            iAna = new Translate.L_Ana(Language);
            iBastion = new Translate.L_Bastion(Language);
            iDVa = new Translate.L_DVa(Language);
            iDoomfist = new Translate.L_Doomfist(Language);
            iGenji = new Translate.L_Genji(Language);
            iHanzo = new Translate.L_Hanzo(Language);
            iJunkrat = new Translate.L_Junkrat(Language);
            iLúcio = new Translate.L_Lúcio(Language);
            iMcCree = new Translate.L_McCree(Language);
            iMei = new Translate.L_Mei(Language);
            iMercy = new Translate.L_Mercy(Language);
            iOrisa = new Translate.L_Orisa(Language);
            iPharah = new Translate.L_Pharah(Language);
            iReaper = new Translate.L_Reaper(Language);
            iReinhardt = new Translate.L_Reinhardt(Language);
            iRoadhog = new Translate.L_Roadhog(Language);
            iSoldier_76 = new Translate.L_Soldier_76(Language);
            iSombra = new Translate.L_Sombra(Language);
            iSymmetra = new Translate.L_Symmetra(Language);
            iTorbjörn = new Translate.L_Torbjörn(Language);
            iTracer = new Translate.L_Tracer(Language);
            iWidowmaker = new Translate.L_Widowmaker(Language);
            iWinston = new Translate.L_Winston(Language);
            iZarya = new Translate.L_Zarya(Language);
            iZenyatta = new Translate.L_Zenyatta(Language);
        }

        private void Texte()
        {
            //Erste mal ausrechnen, wieviel alles zusammen Kostet
            lblChanges.Text = Transl.ChangesText;
            lblKosten.Text = Transl.Remaining;

            gbAll.Visible = false;
            gBLang.Visible = false;
            gBWelcome.Text = Transl.A;
            btnWelcomeClose.Text = Transl.Close;
            //Settings
            btnSettings.Text = Transl.Settings;
            gBLang.Text = Transl.LangChange;
            //Itembuttons
            btnSkins.Text = Transl.Skins;
            btnEmotes.Text = Transl.Emotes;
            btnVictoryPoses.Text = Transl.VictoryPoses;
            btnVoiceLines.Text = Transl.VoiceLines;
            btnSprays.Text = Transl.Sprays;
            btnHighlightIntros.Text = Transl.HighlightIntros;
            btnWeapons.Text = Transl.Weapons;
            btnPlayerIcons.Text = Transl.PlayerIcons;
            //Eventbuttons
            btnSummer.Text = Transl.Summer;
            btnHalloween.Text = Transl.Halloween;
            btnWinter.Text = Transl.Winter;
            btnRooster.Text = Transl.Rooster;
            btnUprising.Text = Transl.Uprising;
            btnAnnyver.Text = Transl.Annyver;
            //More info about remaining costs
            btnMoreCost.Text = Transl.MoreCost;
            lblMoreInfoCost.Text = Transl.RemMoreInfo1;
            lblMoreInfoCost2.Text = Transl.RemMoreInfo2;
        }

        private void ChangePos()
        {
            gBWelcome.Location = new Point(12, 12);
            gBWelcome.Width = 872; gBWelcome.Height = 688; tmrWelcome.Enabled = true;

            gBLang.Location = new Point(684, 600);
            gBLang.Width = 200; gBLang.Height = 100;

            gbAll.Location = new Point(122, 29);
            gbAll.Width = 762; gbAll.Height = 671;

            gBMoreCost.Location = new Point(16, 29);
            gBMoreCost.Width = 868; gBMoreCost.Height = 671;
        }

        private void ChangeLang()
        {
            Transl.ChangeLang = Language;
            iAna.ChangeLang = Language;
            iBastion.ChangeLang = Language;
            iDVa.ChangeLang = Language;
            iDoomfist.ChangeLang = Language;
            iGenji.ChangeLang = Language;
            iHanzo.ChangeLang = Language;
            iJunkrat.ChangeLang = Language;
            iLúcio.ChangeLang = Language;
            iMcCree.ChangeLang = Language;
            iMei.ChangeLang = Language;
            iMercy.ChangeLang = Language;
            iOrisa.ChangeLang = Language;
            iPharah.ChangeLang = Language;
            iReaper.ChangeLang = Language;
            iReinhardt.ChangeLang = Language;
            iRoadhog.ChangeLang = Language;
            iSoldier_76.ChangeLang = Language;
            iSombra.ChangeLang = Language;
            iSymmetra.ChangeLang = Language;
            iTorbjörn.ChangeLang = Language;
            iTracer.ChangeLang = Language;
            iWidowmaker.ChangeLang = Language;
            iWinston.ChangeLang = Language;
            iZarya.ChangeLang = Language;
            iZenyatta.ChangeLang = Language;

            Texte();
        }

        /*
        // Ab hier beginnt der richtige Code
        */

        private void btnLangGerman_Click(object sender, EventArgs e)
        {
            Language = "DE";
            ChangeLang();
        }

        private void btnLangEnglish_Click(object sender, EventArgs e)
        {
            Language = "EN";
            ChangeLang();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            gBLang.Visible = !gBLang.Visible;
            gBLang.BringToFront();
        }

        private void btnSkins_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.Skins)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.Skins;
        }

        private void btnEmotes_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.Emotes)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.Emotes;
        }

        private void btnVictoryPoses_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.VictoryPoses)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.VictoryPoses;
        }

        private void btnVoiceLines_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.VoiceLines)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.VoiceLines;
        }

        private void btnSprays_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.Sprays)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.Sprays;
        }

        private void btnHighlightIntros_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.HighlightIntros)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.HighlightIntros;
        }

        private void btnWeapons_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.Weapons)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.Weapons;
        }

        private void btnPlayerIcons_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.PlayerIcons)
            {
                gbAll.Visible = !gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.PlayerIcons;
        }

        private void btnMoreCost_Click(object sender, EventArgs e)
        {
            if (btnMoreCost.Text == Transl.Close)
            {
                gBMoreCost.Visible = false;
                btnMoreCost.Text = Transl.MoreCost;
            }
            else
            {
                gbAll.Visible = false;
                gBMoreCost.Visible = true;
                gBMoreCost.BringToFront();
                btnMoreCost.Text = Transl.Close;
                gBLang.Visible = false;
            }
        }

        private void tmrWelcome_Tick(object sender, EventArgs e)
        {
            btnWelcomeClose.Visible = true;
            tmrWelcome.Enabled = false;
        }

        private void btnWelcomeClose_Click(object sender, EventArgs e)
        {
            gBWelcome.Visible = false;
            btnMoreCost.Visible = true;//Da der Button sonst sichtbar und klickbar ist :/
        }
    }
}
