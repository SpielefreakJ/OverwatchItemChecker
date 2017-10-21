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
        Translate.L_Ana Ana;
        Translate.L_Bastion Bastion;
        Translate.L_DVa DVa;
        Translate.L_Doomfist Doomfist;
        Translate.L_Genji Genji;
        Translate.L_Hanzo Hanzo;
        Translate.L_Junkrat Junkrat;
        Translate.L_Lúcio Lúcio;
        Translate.L_McCree McCree;
        Translate.L_Mei Mei;
        Translate.L_Mercy Mercy;
        Translate.L_Orisa Orisa;
        Translate.L_Pharah Pharah;
        Translate.L_Reaper Reaper;
        Translate.L_Reinhardt Reinhardt;
        Translate.L_Roadhog Roadhog;
        Translate.L_Soldier_76 Soldier_76;
        Translate.L_Sombra Sombra;
        Translate.L_Symmetra Symmetra;
        Translate.L_Torbjörn Torbjörn;
        Translate.L_Tracer Tracer;
        Translate.L_Widowmaker Widowmaker;
        Translate.L_Winston Winston;
        Translate.L_Zarya Zarya;
        Translate.L_Zenyatta Zenyatta;
        string Language;

        string BackSave;

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
            Ana = new Translate.L_Ana(Language);
            Bastion = new Translate.L_Bastion(Language);
            DVa = new Translate.L_DVa(Language);
            Doomfist = new Translate.L_Doomfist(Language);
            Genji = new Translate.L_Genji(Language);
            Hanzo = new Translate.L_Hanzo(Language);
            Junkrat = new Translate.L_Junkrat(Language);
            Lúcio = new Translate.L_Lúcio(Language);
            McCree = new Translate.L_McCree(Language);
            Mei = new Translate.L_Mei(Language);
            Mercy = new Translate.L_Mercy(Language);
            Orisa = new Translate.L_Orisa(Language);
            Pharah = new Translate.L_Pharah(Language);
            Reaper = new Translate.L_Reaper(Language);
            Reinhardt = new Translate.L_Reinhardt(Language);
            Roadhog = new Translate.L_Roadhog(Language);
            Soldier_76 = new Translate.L_Soldier_76(Language);
            Sombra = new Translate.L_Sombra(Language);
            Symmetra = new Translate.L_Symmetra(Language);
            Torbjörn = new Translate.L_Torbjörn(Language);
            Tracer = new Translate.L_Tracer(Language);
            Widowmaker = new Translate.L_Widowmaker(Language);
            Winston = new Translate.L_Winston(Language);
            Zarya = new Translate.L_Zarya(Language);
            Zenyatta = new Translate.L_Zenyatta(Language);
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
            //Heroebuttons
            btnAna.Text = Ana.Name;
            btnBastion.Text = Bastion.Name;
            btnDVa.Text = DVa.Name;
            btnDoomfist.Text = Doomfist.Name;
            btnGeji.Text = Genji.Name;
            btnHanzo.Text = Hanzo.Name;
            btnJunkrat.Text = Junkrat.Name;
            btnLúcio.Text = Lúcio.Name;
            btnMcCree.Text = McCree.Name;
            btnMei.Text = Mei.Name;
            btnMercy.Text = Mercy.Name;
            btnOrisa.Text = Orisa.Name;
            btnPharah.Text = Pharah.Name;
            btnReaper.Text = Reaper.Name;
            btnReinhardt.Text = Reinhardt.Name;
            btnRoadhog.Text = Roadhog.Name;
            btnSoldier_76.Text = Soldier_76.Name;
            btnSombra.Text = Sombra.Name;
            btnSymmetra.Text = Symmetra.Name;
            btnTorbjörn.Text = Torbjörn.Name;
            btnTracer.Text = Tracer.Name;
            btnWidowmaker.Text = Widowmaker.Name;
            btnWinston.Text = Winston.Name;
            btnZarya.Text = Zarya.Name;
            btnZenyatta.Text = Zenyatta.Name;
            btnBackHeroe.Text = Transl.Back;
            //More info about remaining costs
            btnMoreCost.Text = Transl.MoreCost;
            gBMoreCost.Text = "";
            lblMoreInfoCost.Text = Transl.RemMoreInfo1;
            lblMoreInfoCost2.Text = Transl.RemMoreInfo2;
        }

        private void ChangePos()
        {
            gBWelcome.Location = new Point(12, 12);
            gBWelcome.Width = 872; gBWelcome.Height = 688; tmrWelcome.Enabled = true;

            gBLang.Location = new Point(684, 600);
            gBLang.Width = 200; gBLang.Height = 100;

            gbAll.Location = new Point(16, 29);
            gbAll.Width = 868; gbAll.Height = 642;

            gBMoreCost.Location = new Point(16, 29);
            gBMoreCost.Width = 868; gBMoreCost.Height = 671;
        }

        private void ChangeLang()
        {
            Transl.ChangeLang = Language;
            Ana.ChangeLang = Language;
            Bastion.ChangeLang = Language;
            DVa.ChangeLang = Language;
            Doomfist.ChangeLang = Language;
            Genji.ChangeLang = Language;
            Hanzo.ChangeLang = Language;
            Junkrat.ChangeLang = Language;
            Lúcio.ChangeLang = Language;
            McCree.ChangeLang = Language;
            Mei.ChangeLang = Language;
            Mercy.ChangeLang = Language;
            Orisa.ChangeLang = Language;
            Pharah.ChangeLang = Language;
            Reaper.ChangeLang = Language;
            Reinhardt.ChangeLang = Language;
            Roadhog.ChangeLang = Language;
            Soldier_76.ChangeLang = Language;
            Sombra.ChangeLang = Language;
            Symmetra.ChangeLang = Language;
            Torbjörn.ChangeLang = Language;
            Tracer.ChangeLang = Language;
            Widowmaker.ChangeLang = Language;
            Winston.ChangeLang = Language;
            Zarya.ChangeLang = Language;
            Zenyatta.ChangeLang = Language;

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
                btnBackHeroe.Visible = gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
                btnBackHeroe.Visible = true;
                btnBackHeroe.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.Skins;
        }

        private void btnEmotes_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.Emotes)
            {
                gbAll.Visible = !gbAll.Visible;
                btnBackHeroe.Visible = gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
                btnBackHeroe.Visible = true;
                btnBackHeroe.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.Emotes;
        }

        private void btnVictoryPoses_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.VictoryPoses)
            {
                gbAll.Visible = !gbAll.Visible;
                btnBackHeroe.Visible = gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
                btnBackHeroe.Visible = true;
                btnBackHeroe.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.VictoryPoses;
        }

        private void btnVoiceLines_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.VoiceLines)
            {
                gbAll.Visible = !gbAll.Visible;
                btnBackHeroe.Visible = gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
                btnBackHeroe.Visible = true;
                btnBackHeroe.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.VoiceLines;
        }

        private void btnSprays_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.Sprays)
            {
                gbAll.Visible = !gbAll.Visible;
                btnBackHeroe.Visible = gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
                btnBackHeroe.Visible = true;
                btnBackHeroe.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.Sprays;
        }

        private void btnHighlightIntros_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.HighlightIntros)
            {
                gbAll.Visible = !gbAll.Visible;
                btnBackHeroe.Visible = gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
                btnBackHeroe.Visible = true;
                btnBackHeroe.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.HighlightIntros;
        }

        private void btnWeapons_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.Weapons)
            {
                gbAll.Visible = !gbAll.Visible;
                btnBackHeroe.Visible = gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
                btnBackHeroe.Visible = true;
                btnBackHeroe.BringToFront();
            }
            gBLang.Visible = false;

            gbAll.Text = Transl.Weapons;
        }

        private void btnPlayerIcons_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.PlayerIcons)
            {
                gbAll.Visible = !gbAll.Visible;
                btnBackHeroe.Visible = gbAll.Visible;
            }
            else
            {
                gbAll.Visible = true;
                gbAll.BringToFront();
                btnBackHeroe.Visible = true;
                btnBackHeroe.BringToFront();
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
                btnBackHeroe.Visible = false;
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

        private void btnBackHeroe_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Transl.Skins || gbAll.Text == Transl.Emotes || gbAll.Text == Transl.VictoryPoses || gbAll.Text == Transl.VoiceLines || gbAll.Text == Transl.Sprays || gbAll.Text == Transl.HighlightIntros || gbAll.Text == Transl.Weapons || gbAll.Text == Transl.PlayerIcons)
            {
                gbAll.Visible = false;
                btnBackHeroe.Visible = false;
            }
            else
            {
                btnAna.Visible = true;
                btnBastion.Visible = true;
                btnDVa.Visible = true;
                btnDoomfist.Visible = true;
                btnGeji.Visible = true;
                btnHanzo.Visible = true;
                btnJunkrat.Visible = true;
                btnLúcio.Visible = true;
                btnMcCree.Visible = true;
                btnMei.Visible = true;
                btnMercy.Visible = true;
                btnOrisa.Visible = true;
                btnPharah.Visible = true;
                btnReaper.Visible = true;
                btnReinhardt.Visible = true;
                btnRoadhog.Visible = true;
                btnSoldier_76.Visible = true;
                btnSombra.Visible = true;
                btnSymmetra.Visible = true;
                btnTorbjörn.Visible = true;
                btnTracer.Visible = true;
                btnWidowmaker.Visible = true;
                btnWinston.Visible = true;
                btnZarya.Visible = true;
                btnZenyatta.Visible = true;

                gbAll.Text = BackSave;

                //Rest Ausblenden
            }
        }

        private void btnHeroeinvisible()
        {
            btnAna.Visible = false;
            btnBastion.Visible = false;
            btnDVa.Visible = false;
            btnDoomfist.Visible = false;
            btnGeji.Visible = false;
            btnHanzo.Visible = false;
            btnJunkrat.Visible = false;
            btnLúcio.Visible = false;
            btnMcCree.Visible = false;
            btnMei.Visible = false;
            btnMercy.Visible = false;
            btnOrisa.Visible = false;
            btnPharah.Visible = false;
            btnReaper.Visible = false;
            btnReinhardt.Visible = false;
            btnRoadhog.Visible = false;
            btnSoldier_76.Visible = false;
            btnSombra.Visible = false;
            btnSymmetra.Visible = false;
            btnTorbjörn.Visible = false;
            btnTracer.Visible = false;
            btnWidowmaker.Visible = false;
            btnWinston.Visible = false;
            btnZarya.Visible = false;
            btnZenyatta.Visible = false;

            BackSave = gbAll.Text;
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Ana.Name;
        }

        private void btnBastion_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Bastion.Name;
        }

        private void btnDVa_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + DVa.Name;
        }

        private void btnDoomfist_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Doomfist.Name;
        }

        private void btnGeji_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Genji.Name;
        }

        private void btnHanzo_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Hanzo.Name;
        }

        private void btnJunkrat_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Junkrat.Name;
        }

        private void btnLúcio_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Lúcio.Name;
        }

        private void btnMcCree_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + McCree.Name;
        }

        private void btnMei_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Mei.Name;
        }

        private void btnMercy_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Mercy.Name;
        }

        private void btnOrisa_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Orisa.Name;
        }

        private void btnPharah_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Pharah.Name;
        }

        private void btnReaper_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Reaper.Name;
        }

        private void btnReinhardt_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Reinhardt.Name;
        }

        private void btnRoadhog_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Roadhog.Name;
        }

        private void btnSoldier_76_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Soldier_76.Name;
        }

        private void btnSombra_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Sombra.Name;
        }

        private void btnSymmetra_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Symmetra.Name;
        }

        private void btnTorbjörn_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Torbjörn.Name;
        }

        private void btnTracer_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Tracer.Name;
        }

        private void btnWidowmaker_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Widowmaker.Name;
        }

        private void btnWinston_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Winston.Name;
        }

        private void btnZarya_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Zarya.Name;
        }

        private void btnZenyatta_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Zenyatta.Name;
        }
    }
}
