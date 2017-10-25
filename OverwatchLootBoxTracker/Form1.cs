using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        IniStream inisHeroes = null;
        IniStream inisPI = null;
        CCost Cost;
        Translate.L_Translate Lang;
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
        int gBAllWeited3, gBAllWeited3p1, gBAllWeited3p2;
        int gBAllWeited4, gBAllWeited4p1, gBAllWeited4p2, gBAllWeited4p3;
        int gBAllWeited5, gBAllWeited5p1, gBAllWeited5p2, gBAllWeited5p3, gBAllWeited5p4;

        string BackSave;

        String appdata = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public Form1()
        {
            InitializeComponent();
            KlassenInst();
            ChangePos();
            this.Width = 912; this.Height = 751;

            //Erstellen des Verzeichnisses "OWItemTracker" in C:\\User\[Username]\AppData\Local
            appdata += "\\OWItemTracker";
            Directory.CreateDirectory(appdata);

            //Auslesen der "Settings.ini" Datei und speichern in IniStream inisSettings
            inisSettings = new IniStream(appdata + "\\Settings.ini");

            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            IniRead();
            IniHeroes();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            //MessageBox.Show(Lang.AppClose);
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
            Cost = new CCost();
            Lang = new Translate.L_Translate(Language);
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
            lblChanges.Text = Lang.ChangesText;
            lblKosten.Text = Lang.Remaining;

            gbAll.Visible = false;
            gBLang.Visible = false;
            gBWelcome.Text = Lang.Welcome;
            btnWelcomeClose.Text = Lang.Close + " (3)";
            lblCopyrightVersion.Text = Lang.CopyrightVersion;
            lblContributor.Text = "Contributor:\nProgramm: SpielefreakJ\n\nLanguages:\nEnglish: SpielefreakJ\nGerman: SpielefreakJ";
            //Settings
            btnSettings.Text = Lang.Settings;
            gBLang.Text = Lang.LangChange;
            //Itembuttons
            btnSkins.Text = Lang.Skins;
            btnEmotes.Text = Lang.Emotes;
            btnVictoryPoses.Text = Lang.VictoryPoses;
            btnVoiceLines.Text = Lang.VoiceLines;
            btnSprays.Text = Lang.Sprays;
            btnHighlightIntros.Text = Lang.HighlightIntros;
            btnWeapons.Text = Lang.Weapons;
            btnPlayerIcons.Text = Lang.PlayerIcons;
            //Eventbuttons
            btnSummer.Text = Lang.Summer;
            btnHalloween.Text = Lang.Halloween;
            btnWinter.Text = Lang.Winter;
            btnRooster.Text = Lang.Rooster;
            btnUprising.Text = Lang.Uprising;
            btnAnnyver.Text = Lang.Annyver;
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
            btnBackHeroe.Text = Lang.Back;
            //More info about remaining costs
            btnMoreCost.Text = Lang.MoreCost;
            gBMoreCost.Text = "";
            lblMoreInfoCost.Text = Lang.RemMoreInfo1;
            lblMoreInfoCost2.Text = Lang.RemMoreInfo2;
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

            btnBackHeroe.Location = new Point(16, 677);

            //Buttons der Helden
            btnAna.Location = new Point(7, 20);
            btnBastion.Location = new Point(7, 49);
            btnDVa.Location = new Point(7, 78);
            btnDoomfist.Location = new Point(7, 107);
            btnGeji.Location = new Point(7, 136);
            btnHanzo.Location = new Point(7, 165);
            btnJunkrat.Location = new Point(7, 194);
            btnLúcio.Location = new Point(7, 223);
            btnMcCree.Location = new Point(7, 252);
            btnMei.Location = new Point(7, 281);
            btnMercy.Location = new Point(7, 310);
            btnOrisa.Location = new Point(7, 339);
            btnPharah.Location = new Point(7, 368);

            btnReaper.Location = new Point(114, 20);
            btnReinhardt.Location = new Point(114, 49);
            btnRoadhog.Location = new Point(114, 78);
            btnSoldier_76.Location = new Point(114, 107);
            btnSombra.Location = new Point(114, 136);
            btnSymmetra.Location = new Point(114, 165);
            btnTorbjörn.Location = new Point(114, 194);
            btnTracer.Location = new Point(114, 223);
            btnWidowmaker.Location = new Point(114, 252);
            btnWinston.Location = new Point(114, 281);
            btnZarya.Location = new Point(114, 310);
            btnZenyatta.Location = new Point(114, 339);


            gBAllWeited3 = gbAll.Width;
            gBAllWeited3 /= 3;
            gBAllWeited3p1 = gBAllWeited3 - 57;
            gBAllWeited3p2 = gBAllWeited3 * 2 - 57;

            gBAllWeited4 = gbAll.Width;
            gBAllWeited4 /= 4;
            gBAllWeited4p1 = gBAllWeited4 - 57;
            gBAllWeited4p2 = gBAllWeited4 * 2 - 57;
            gBAllWeited4p3 = gBAllWeited4 * 3 - 57;
        }

        private void ChangeLang()
        {
            Lang.ChangeLang = Language;
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

        private void IniHeroes()
        {
            //Auslesen der "Settings.ini" Datei und speichern in IniStream inisSettings
            inisHeroes = new IniStream("Ana.ini");
        }

        /*
        // Ab hier beginnt der richtige Code
        */

        private void btnLangGerman_Click(object sender, EventArgs e)
        {
            Language = "DE";
            ChangeLang();
            IniSave();
        }

        private void btnLangEnglish_Click(object sender, EventArgs e)
        {
            Language = "EN";
            ChangeLang();
            IniSave();
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

            gbAll.Text = Lang.Skins;
        }

        private void btnEmotes_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.Emotes)
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

            gbAll.Text = Lang.Emotes;
        }

        private void btnVictoryPoses_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.VictoryPoses)
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

            gbAll.Text = Lang.VictoryPoses;
        }

        private void btnVoiceLines_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.VoiceLines)
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

            gbAll.Text = Lang.VoiceLines;
        }

        private void btnSprays_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.Sprays)
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

            gbAll.Text = Lang.Sprays;
        }

        private void btnHighlightIntros_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.HighlightIntros)
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

            gbAll.Text = Lang.HighlightIntros;
        }

        private void btnWeapons_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.Weapons)
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

            gbAll.Text = Lang.Weapons;
        }

        private void btnPlayerIcons_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.PlayerIcons)
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

            gbAll.Text = Lang.PlayerIcons;
        }

        private void btnMoreCost_Click(object sender, EventArgs e)
        {
            if (btnMoreCost.Text == Lang.Close)
            {
                gBMoreCost.Visible = false;
                btnMoreCost.Text = Lang.MoreCost;
                btnBackHeroe.Visible = false;
            }
            else
            {
                gbAll.Visible = false;
                gBMoreCost.Visible = true;
                gBMoreCost.BringToFront();
                btnMoreCost.Text = Lang.Close;
                gBLang.Visible = false;
            }
        }

        int i = 3;
        private void tmrWelcome_Tick(object sender, EventArgs e)
        {
            if (i == 1)
            {
                i--;
                btnWelcomeClose.Text = Lang.Close;
                btnWelcomeClose.Enabled = true;
                tmrWelcome.Enabled = false;
            }
            if (i == 2)
            {
                i--;
                btnWelcomeClose.Text = Lang.Close + " (" + i + ")";
            }
            if (i >= 3)
            {
                i--;
                btnWelcomeClose.Text = Lang.Close + " (" + i + ")";
            }
        }

        private void btnWelcomeClose_Click(object sender, EventArgs e)
        {
            gBWelcome.Visible = false;
            btnMoreCost.Visible = true;//Da der Button sonst sichtbar und klickbar ist :/
        }

        //Für hier benötigte Variablen
        int chBSave; string Heroe = "PI";

        private void btnBackHeroe_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == Lang.Skins || gbAll.Text == Lang.Emotes || gbAll.Text == Lang.VictoryPoses || gbAll.Text == Lang.VoiceLines || gbAll.Text == Lang.Sprays || gbAll.Text == Lang.HighlightIntros || gbAll.Text == Lang.Weapons || gbAll.Text == Lang.PlayerIcons)
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
                //Erst sagen, dass die Checkboxen nicht speichern sollen
                chBSave = 0;
                //Resetten aller Checkboxen und Ausblenden
                chB01.Checked = false; chB01.Visible = false;
                chB02.Checked = false; chB02.Visible = false;
                chB03.Checked = false; chB03.Visible = false;
                chB04.Checked = false; chB04.Visible = false;
                chB05.Checked = false; chB05.Visible = false;
                chB06.Checked = false; chB06.Visible = false;
                chB07.Checked = false; chB07.Visible = false;
                chB08.Checked = false; chB08.Visible = false;
                chB09.Checked = false; chB09.Visible = false;
                chB10.Checked = false; chB10.Visible = false;
                chB11.Checked = false; chB11.Visible = false;
                chB12.Checked = false; chB12.Visible = false;
                chB13.Checked = false; chB13.Visible = false;
                chB14.Checked = false; chB14.Visible = false;
                chB15.Checked = false; chB15.Visible = false;
                chB16.Checked = false; chB16.Visible = false;
                chB17.Checked = false; chB17.Visible = false;
                chB18.Checked = false; chB18.Visible = false;
                chB19.Checked = false; chB19.Visible = false;
                chB20.Checked = false; chB20.Visible = false;

                chB21.Checked = false; chB21.Visible = false;
                chB22.Checked = false; chB22.Visible = false;
                chB23.Checked = false; chB23.Visible = false;
                chB24.Checked = false; chB24.Visible = false;
                chB25.Checked = false; chB25.Visible = false;
                chB26.Checked = false; chB26.Visible = false;
                chB27.Checked = false; chB27.Visible = false;
                chB28.Checked = false; chB28.Visible = false;
                chB29.Checked = false; chB29.Visible = false;
                chB30.Checked = false; chB30.Visible = false;
                chB31.Checked = false; chB31.Visible = false;
                chB32.Checked = false; chB32.Visible = false;
                chB33.Checked = false; chB33.Visible = false;
                chB34.Checked = false; chB34.Visible = false;
                chB35.Checked = false; chB35.Visible = false;
                chB36.Checked = false; chB36.Visible = false;
                chB37.Checked = false; chB37.Visible = false;
                chB38.Checked = false; chB38.Visible = false;
                chB39.Checked = false; chB39.Visible = false;
                chB40.Checked = false; chB40.Visible = false;
                //Nun sagen, dass die Checkboxen speichern sollen
                chBSave = 1;
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
            chBSave = 1;
        }

        int p1 = 194; int p2 = 217; int p3 = 240; int p4 = 263; int p5 = 286; int p6 = 309; int p7 = 332; int p8 = 355; int p9 = 378; int p10 = 401;

        private void btnAna_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Ana.Name;

            inisHeroes = new IniStream(appdata + "\\Ana.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p5);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Ana.Citrine_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Ana.Garnet_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Ana.Peridot_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Ana.Turquoise_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Ana.Merciful_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Ana.Shrike_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Ana.Ghoul_SK + " (" + Cost.Epic + ")";//Halloween 16
                chB08.BackColor = Color.DarkViolet; chB08.Text = Ana.Tal_SK + " (" + Cost.EpicEvent + ")";//Rooster 17
                chB09.BackColor = Color.Gold; chB09.Text = Ana.Wadjet_SK + " (" + Cost.Legendary + ")";//Legendary
                chB10.BackColor = Color.Gold; chB10.Text = Ana.Wasteland_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Ana.Captain_Amari_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Ana.Horus_SK + " (" + Cost.Legendary + ")";
                chB13.BackColor = Color.Gold; chB13.Text = Ana.Corsair_SK + " (" + Cost.LegendaryEvent + ")";//Halloween 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
            }
            if (BackSave == Lang.Emotes)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p1); chB01.Text = Ana.Not_Impressed_EM + " (" + Cost.Epic + ")";//Epic
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p2); chB02.Text = Ana.Disapproving_EM + " (" + Cost.Epic + ")";
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p3); chB03.Text = Ana.Protector_EM + " (" + Cost.Epic + ")";
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p1, p4); chB04.Text = Ana.Take_A_Knee_EM + " (" + Cost.Epic + ")";
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p1); chB05.Text = Ana.Tea_Time_EM + " (" + Cost.Epic + ")";
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p2); chB06.Text = Ana.Beach_Ball_EM + " (" + Cost.EpicEvent + ")";//Summer 17
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = Ana.Candy_EM + " (" + Cost.Epic + ")";//Halloween 16
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited3p2, p4); chB08.Text = Ana.Dance_EM + " (" + Cost.EpicEvent + ")";//Annyver 17
                if (inisHeroes.Read("EM01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("EM02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("EM03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("EM04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("EM05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("EM06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("EM07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("EM08") == "1")
                {
                    chB08.Checked = true;
                }
            }
            if (BackSave == Lang.VictoryPoses)
            {
                chB01.Visible = true; chB01.Text = Ana.Mission_Complete_VP + " (" + Cost.Rare + ")";//Rare
                chB02.Visible = true; chB02.Text = Ana.Protector_VP + " (" + Cost.Rare + ")";
                chB03.Visible = true; chB03.Text = Ana.Seated_VP + " (" + Cost.Rare + ")";
                chB04.Visible = true; chB04.Text = Ana.RIP_VP + " (" + Cost.Rare + ")";//Halloween 16
                chB05.Visible = true; chB05.Text = Ana.Toast_VP + " (" + Cost.RareEvent + ")";//Winter 16
                chB06.Visible = true; chB06.Text = Ana.Folded_Hands_VP + " (" + Cost.RareEvent + ")";//Rooster 17
                if (inisHeroes.Read("VP01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("VP02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("VP03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("VP04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("VP05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("VP06") == "1")
                {
                    chB06.Checked = true;
                }
            }
            if (BackSave == Lang.VoiceLines)
            {
                chB01.Visible = true; chB01.Text = Ana.Justice_Delivered_VL + " (" + Cost.Common + ")";//Common
                chB02.Visible = true; chB02.Text = Ana.Children_behave_VL + " (" + Cost.Common + ")";
                chB03.Visible = true; chB03.Text = Ana.Everyone_dies_VL + " (" + Cost.Common + ")";
                chB04.Visible = true; chB04.Text = Ana.It_takes_a_woman_to_know_VL + " (" + Cost.Common + ")";
                chB05.Visible = true; chB05.Text = Ana.Justice_rains_from_above_VL + " (" + Cost.Common + ")";
                chB06.Visible = true; chB06.Text = Ana.Mother_knows_best_VL + " (" + Cost.Common + ")";
                chB07.Visible = true; chB07.Text = Ana.No_scope_needed_VL + " (" + Cost.Common + ")";
                chB08.Visible = true; chB08.Text = Ana.What_are_you_thinking_VL + " (" + Cost.Common + ")";
                chB09.Visible = true; chB09.Text = Ana.Witness_me_VL + " (" + Cost.Common + ")";
                chB10.Visible = true; chB10.Text = Ana.You_know_nothing_VL + " (" + Cost.Common + ")";
                chB11.Visible = true; chB11.Text = Ana.Someone_to_tuck_you_in_VL + " (" + Cost.Common + ")";
                chB12.Visible = true; chB12.Text = Ana.Better_than_retirement_VL + " (" + Cost.CommonEvent + ")";//Summer 17
                chB13.Visible = true; chB13.Text = Ana.Learn_from_the_pain_VL + " (" + Cost.Common + ")";//Summer 16
                chB14.Visible = true; chB14.Text = Ana.Are_you_scared_VL + " (" + Cost.Common + ")";//Halloween 16
                chB15.Visible = true; chB15.Text = Ana.Dont_be_scared_VL + " (" + Cost.CommonEvent + ")";//Halloween 17
                chB16.Visible = true; chB16.Text = Ana.Im_watching_out_for_you_VL + " (" + Cost.CommonEvent + ")";//Winter 16
                chB17.Visible = true; chB17.Text = Ana.The_Moon_in_Winter_VL + " (" + Cost.CommonEvent + ")";//Rooster 17
                chB18.Visible = true; chB18.Text = Ana.Damn_VL + " (" + Cost.CommonEvent + ")";//Uprising 17
                chB19.Visible = true; chB19.Text = Ana.The_Ghost_watches_VL + " (" + Cost.CommonEvent + ")";//Uprising 17
                chB20.Visible = true; chB20.Text = Ana.Follow_me_VL + " (" + Cost.CommonEvent + ")";//Annyver 17
                chB21.Visible = true; chB21.Text = Ana.The_adults_are_talking_VL + " (" + Cost.CommonEvent + ")";//Annyver 17
                if (inisHeroes.Read("VL01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("VL02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("VL03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("VL04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("VL05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("VL06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("VL07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("VL08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("VL09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("VL10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("VL11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("VL12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("VL13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("VL14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("VL15") == "1")
                {
                    chB15.Checked = true;
                }
                if (inisHeroes.Read("VL16") == "1")
                {
                    chB16.Checked = true;
                }
                if (inisHeroes.Read("VL17") == "1")
                {
                    chB17.Checked = true;
                }
                if (inisHeroes.Read("VL18") == "1")
                {
                    chB18.Checked = true;
                }
                if (inisHeroes.Read("VL19") == "1")
                {
                    chB19.Checked = true;
                }
                if (inisHeroes.Read("VL20") == "1")
                {
                    chB20.Checked = true;
                }
                if (inisHeroes.Read("VL21") == "1")
                {
                    chB21.Checked = true;
                }
            }
            if (BackSave == Lang.Sprays)
            {
                chB01.Visible = true; chB01.Text = Ana.Action_SP + " (" + Cost.Common + ")";//Common
                chB02.Visible = true; chB02.Text = Ana.Ana_SP + " (" + Cost.Common + ")";
                chB03.Visible = true; chB03.Text = Ana.Bearer_SP + " (" + Cost.Common + ")";
                chB04.Visible = true; chB04.Text = Ana.Cheer_SP + " (" + Cost.Common + ")";
                chB05.Visible = true; chB05.Text = Ana.Cracked_SP + " (" + Cost.Common + ")";
                chB06.Visible = true; chB06.Text = Ana.Cute_SP + " (" + Cost.Common + ")";
                chB07.Visible = true; chB07.Text = Ana.Eyepatch_SP + " (" + Cost.Common + ")";
                chB08.Visible = true; chB08.Text = Ana.Fareeha_SP + " (" + Cost.Common + ")";
                chB09.Visible = true; chB09.Text = Ana.Gaze_SP + " (" + Cost.Common + ")";
                chB10.Visible = true; chB10.Text = Ana.Grenade_SP + " (" + Cost.Common + ")";
                chB11.Visible = true; chB11.Text = Ana.Guardian_SP + " (" + Cost.Common + ")";
                chB12.Visible = true; chB12.Text = Ana.Hesitation_SP + " (" + Cost.Common + ")";
                chB13.Visible = true; chB13.Text = Ana.Icon_SP + " (" + Cost.Common + ")";
                chB14.Visible = true; chB14.Text = Ana.Letter_SP + " (" + Cost.Common + ")";
                chB15.Visible = true; chB15.Text = Ana.Old_Soldier_SP + " (" + Cost.Common + ")";
                chB16.Visible = true; chB16.Text = Ana.Overhead_SP + " (" + Cost.Common + ")";
                chB17.Visible = true; chB17.Text = Ana.Pillow_SP + " (" + Cost.Common + ")";
                chB18.Visible = true; chB18.Text = Ana.Photograph_SP + " (" + Cost.Common + ")";
                chB19.Visible = true; chB19.Text = Ana.Pixel_SP + " (" + Cost.Common + ")";
                chB20.Visible = true; chB20.Text = Ana.Rifle_SP + " (" + Cost.Common + ")";
                chB21.Visible = true; chB21.Text = Ana.Shadow_SP + " (" + Cost.Common + ")";
                chB22.Visible = true; chB22.Text = Ana.Shhh_SP + " (" + Cost.Common + ")";
                chB23.Visible = true; chB23.Text = Ana.Sidearm_SP + " (" + Cost.Common + ")";
                chB24.Visible = true; chB24.Text = Ana.Wedjat_SP + " (" + Cost.Common + ")";
                chB25.Visible = true; chB25.Text = Ana.Wrist_Launcher_SP + " (" + Cost.Common + ")";
                chB26.Visible = true; chB26.Text = Ana.Zzz_SP + " (" + Cost.Common + ")";
                chB27.Visible = true; chB27.Text = Ana.Shooting_SP + " (" + Cost.Common + ")";//Summer 16
                chB28.Visible = true; chB28.Text = Ana.Trick_or_Treat_SP + " (" + Cost.Common + ")";//Halloween 16
                chB29.Visible = true; chB29.Text = Ana.Ornament_SP + " (" + Cost.RareEvent + ")";//Winter 16
                chB30.Visible = true; chB30.Text = Ana.Warm_SP + " (" + Cost.RareEvent + ")";//Winter 16
                chB31.Visible = true; chB31.Text = Ana.Dance_SP + " (" + Cost.RareEvent + ")";//Rooster 17
                chB32.Visible = true; chB32.Text = Ana.Dragon_Dance_SP + " (" + Cost.RareEvent + ")";//Rooster 17
                chB33.Visible = true; chB33.Text = Ana.Newborn_SP + " (" + Cost.RareEvent + ")";//Uprising 17
                chB34.Visible = true; chB34.Text = Ana.Ace_of_Hearts_SP + " (" + Cost.RareEvent + ")";//Annyver 17
                if (inisHeroes.Read("SP01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SP02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SP03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SP04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SP05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SP06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SP07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SP08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SP09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SP10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SP11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SP12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SP13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SP14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SP15") == "1")
                {
                    chB15.Checked = true;
                }
                if (inisHeroes.Read("SP16") == "1")
                {
                    chB16.Checked = true;
                }
                if (inisHeroes.Read("SP17") == "1")
                {
                    chB17.Checked = true;
                }
                if (inisHeroes.Read("SP18") == "1")
                {
                    chB18.Checked = true;
                }
                if (inisHeroes.Read("SP19") == "1")
                {
                    chB19.Checked = true;
                }
                if (inisHeroes.Read("SP20") == "1")
                {
                    chB20.Checked = true;
                }
                if (inisHeroes.Read("SP21") == "1")
                {
                    chB21.Checked = true;
                }
                if (inisHeroes.Read("SP22") == "1")
                {
                    chB22.Checked = true;
                }
                if (inisHeroes.Read("SP23") == "1")
                {
                    chB23.Checked = true;
                }
                if (inisHeroes.Read("SP24") == "1")
                {
                    chB24.Checked = true;
                }
                if (inisHeroes.Read("SP25") == "1")
                {
                    chB25.Checked = true;
                }
                if (inisHeroes.Read("SP26") == "1")
                {
                    chB26.Checked = true;
                }
                if (inisHeroes.Read("SP27") == "1")
                {
                    chB27.Checked = true;
                }
                if (inisHeroes.Read("SP28") == "1")
                {
                    chB28.Checked = true;
                }
                if (inisHeroes.Read("SP29") == "1")
                {
                    chB29.Checked = true;
                }
                if (inisHeroes.Read("SP30") == "1")
                {
                    chB30.Checked = true;
                }
                if (inisHeroes.Read("SP31") == "1")
                {
                    chB31.Checked = true;
                }
                if (inisHeroes.Read("SP32") == "1")
                {
                    chB32.Checked = true;
                }
                if (inisHeroes.Read("SP33") == "1")
                {
                    chB33.Checked = true;
                }
                if (inisHeroes.Read("SP34") == "1")
                {
                    chB34.Checked = true;
                }
            }
            if (BackSave == Lang.HighlightIntros)
            {
                chB01.Visible = true; chB01.Text = Ana.Guardian_HI + " (" + Cost.Epic + ")";//Epic
                chB02.Visible = true; chB02.Text = Ana.Locked_on_HI + " (" + Cost.Epic + ")";
                chB03.Visible = true; chB03.Text = Ana.Shh_HI + " (" + Cost.Epic + ")";
                if (inisHeroes.Read("HI01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("HI02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("HI03") == "1")
                {
                    chB03.Checked = true;
                }
            }
            if (BackSave == Lang.PlayerIcons)
            {
                chB01.Visible = true; chB01.Text = Ana.Ana_PI;//Rare
                chB02.Visible = true; chB02.Text = Ana.Watcher_PI;
                chB03.Visible = true; chB03.Text = Ana.Wedjat_PI;
                chB04.Visible = true; chB04.Text = Ana.Shooting_PI;//Summer 16
                chB04.Visible = true; chB04.Text = Ana.Corsair_PI;//Halloween 17
                chB04.Visible = true; chB04.Text = Ana.Anaversary_PI;//Annyver 17
                if (inisHeroes.Read("PI01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("PI02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("PI03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("PI04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("PI05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("PI06") == "1")
                {
                    chB06.Checked = true;
                }
            }
        }

        private void btnBastion_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Bastion.Name;

            inisHeroes = new IniStream(appdata + "\\Bastion.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p2, p5);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p2, p6);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p1);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p2);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p3);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p4);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p5);
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p6);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Bastion.Dawn_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Bastion.Meadow_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Bastion.Sky_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Bastion.Soot_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Bastion.Defense_Matrix_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Bastion.Omnic_Crisis_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Bastion.BlizzCon_2016_SK + " (" + Lang.BlizzCon + ")";//BlizzCon 16
                chB08.BackColor = Color.DarkViolet; chB08.Text = Bastion.Tombstone_SK + " (" + Cost.Epic + ")";//Halloween 16
                chB09.BackColor = Color.DarkViolet; chB09.Text = Bastion.Rooster_SK + " (" + Cost.EpicEvent + ")";//Rooster 17
                chB10.BackColor = Color.DarkViolet; chB10.Text = Bastion.Null_Sector_SK + " (" + Cost.EpicEvent + ")";//Uprising 17
                chB11.BackColor = Color.Gold; chB11.Text = Bastion.Antique_SK + " (" + Cost.Legendary + ")";//Legendary
                chB12.BackColor = Color.Gold; chB12.Text = Bastion.Woodbot_SK + " (" + Cost.Legendary + ")";
                chB13.BackColor = Color.Gold; chB13.Text = Bastion.Gearbot_SK + " (" + Cost.Legendary + ")";
                chB14.BackColor = Color.Gold; chB14.Text = Bastion.Steambot_SK + " (" + Cost.Legendary + ")";
                chB15.BackColor = Color.Gold; chB15.Text = Bastion.Overgrown_SK + " (" + Lang.OriginGotY + ")";//Origin
                chB16.BackColor = Color.Gold; chB16.Text = Bastion.Dune_Buggy_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SK15") == "1")
                {
                    chB15.Checked = true;
                }
                if (inisHeroes.Read("SK16") == "1")
                {
                    chB16.Checked = true;
                }
            }
            if (BackSave == Lang.Emotes)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p1); chB01.Text = Bastion.Alert_Alert_EM + " (" + Cost.Epic + ")";//Epic
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p2); chB02.Text = Bastion.Chortle_EM + " (" + Cost.Epic + ")";
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p3); chB03.Text = Bastion.Dizzy_EM + " (" + Cost.Epic + ")";
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p1, p4); chB04.Text = Bastion.Rest_Mode_EM + " (" + Cost.Epic + ")";
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p1); chB05.Text = Bastion.Robot_EM + " (" + Cost.Epic + ")";
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p2); chB06.Text = Bastion.Boxing_EM + " (" + Cost.Epic + ")";//Summer 16
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = Bastion.Robo_Boogie_EM + " (" + Cost.EpicEvent + ")";//Annyver 17
                if (inisHeroes.Read("EM01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("EM02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("EM03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("EM04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("EM05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("EM06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("EM07") == "1")
                {
                    chB07.Checked = true;
                }
            }
            if (BackSave == Lang.VictoryPoses)
            {
                chB01.Visible = true; chB01.Text = Bastion.Birdwatching_VP + " (" + Cost.Rare + ")";//Rare
                chB02.Visible = true; chB02.Text = Bastion.Pop_up_VP + " (" + Cost.Rare + ")";
                chB03.Visible = true; chB03.Text = Bastion.Tank_EM + " (" + Cost.Rare + ")";
                chB04.Visible = true; chB04.Text = Bastion.Medal_VP;//Summer 17
                chB05.Visible = true; chB05.Text = Bastion.RIP_VP + " (" + Cost.Rare + ")";//Halloween 16
                chB06.Visible = true; chB06.Text = Bastion.Firework_VP;//Rooster 17
                if (inisHeroes.Read("VP01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("VÜ02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("VP03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("VP04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("VP05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("VP06") == "1")
                {
                    chB06.Checked = true;
                }
            }
            if (BackSave == Lang.VoiceLines)
            {
                chB01.Visible = true; chB01.Text = Bastion.Doo_Woo_VL + " (" + Cost.Common + ")";//Common
                chB02.Visible = true; chB02.Text = Bastion.Beeple_VL + " (" + Cost.Common + ")";
                chB03.Visible = true; chB03.Text = Bastion.Boo_Boo_Doo_De_Doo_VL + " (" + Cost.Common + ")";
                chB04.Visible = true; chB04.Text = Bastion.Bweeeeeeeeeee_VL + " (" + Cost.Common + ")";
                chB05.Visible = true; chB05.Text = Bastion.Chirr_Chirr_Chirr_VL + " (" + Cost.Common + ")";
                chB06.Visible = true; chB06.Text = Bastion.Dah_Dah_Weeeee_VL + " (" + Cost.Common + ")";
                chB07.Visible = true; chB07.Text = Bastion.Dun_Dun_Boop_Boop_VL + " (" + Cost.Common + ")";
                chB08.Visible = true; chB08.Text = Bastion.Dweet_Dweet_Dweet_VL + " (" + Cost.Common + ")";
                chB09.Visible = true; chB09.Text = Bastion.Hee_Hoo_Hoo_VL + " (" + Cost.Common + ")";
                chB10.Visible = true; chB10.Text = Bastion.Sh_Sh_Sh_VL + " (" + Cost.Common + ")";
                chB11.Visible = true; chB11.Text = Bastion.Zwee_VL + " (" + Cost.Common + ")";
                chB12.Visible = true; chB12.Text = Bastion.Doo_Do_Doo_Dee_VL + " (" + Cost.RareEvent + ")";//Summer 17
                chB13.Visible = true; chB13.Text = Bastion.Whoo_Vweeeeee_VL + " (" + Cost.Common + ")";//Summer 16
                chB14.Visible = true; chB14.Text = Bastion.Oooooooooooo_VL + " (" + Cost.RareEvent + ")";//Halloween 17
                chB15.Visible = true; chB15.Text = Bastion.W_W_Wooooo_VL + " (" + Cost.Common + ")";//Halloween 16
                chB16.Visible = true; chB16.Text = Bastion.Dwee_Doo_Hoo_VL + " (" + Cost.RareEvent + ")";//Winter 16
                chB17.Visible = true; chB17.Text = Bastion.Woop_Doo_Woo_Dun_Woop_VL + " (" + Cost.RareEvent + ")";//Rooster 17
                chB18.Visible = true; chB18.Text = Bastion.Dwee_Wee_Woh_VL + " (" + Cost.RareEvent + ")";//Uprising 17
                chB19.Visible = true; chB19.Text = Bastion.Zwee_Ah_Wheee_Doo_Woo_VL + " (" + Cost.RareEvent + ")";//Uprising 17
                chB20.Visible = true; chB20.Text = Bastion.Bew_Woo_Bew_Woo_VL + " (" + Cost.RareEvent + ")";//Annyver 17
                chB21.Visible = true; chB21.Text = Bastion.Doo_Dun_Dun_Woo_VL + " (" + Cost.RareEvent + ")";//Annyver 17
                if (inisHeroes.Read("VL01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("VL02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("VL03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("VL04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("VL05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("VL06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("VL07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("VL08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("VL09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("VL10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("VL11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("VL12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("VL13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("VL14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("VL15") == "1")
                {
                    chB15.Checked = true;
                }
                if (inisHeroes.Read("VL16") == "1")
                {
                    chB16.Checked = true;
                }
                if (inisHeroes.Read("VL17") == "1")
                {
                    chB17.Checked = true;
                }
                if (inisHeroes.Read("VL18") == "1")
                {
                    chB18.Checked = true;
                }
                if (inisHeroes.Read("VL19") == "1")
                {
                    chB19.Checked = true;
                }
                if (inisHeroes.Read("VL20") == "1")
                {
                    chB20.Checked = true;
                }
                if (inisHeroes.Read("VL21") == "1")
                {
                    chB21.Checked = true;
                }
            }
        }

        private void btnDVa_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + DVa.Name;

            inisHeroes = new IniStream(appdata + "\\DVa.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = DVa.Blueberry_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = DVa.Lemon_Lime_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = DVa.Tangerine_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = DVa.Watermelon_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = DVa.Carbon_Fiber_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = DVa.White_Rabbit_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = DVa.Taegeukgi_SK + " (" + Cost.Epic + ")";//Summer 16
                chB08.BackColor = Color.Gold; chB08.Text = DVa.Junker_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = DVa.Scavenger_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = DVa.BVa_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = DVa.Junebug_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = DVa.Officer_SK + " (" + Cost.Legendary + ")";
                chB13.BackColor = Color.Gold; chB13.Text = DVa.Palanquin_SK + " (" + Cost.LegendaryEvent + ")";//Rooster 17
                chB14.BackColor = Color.Gold; chB14.Text = DVa.Cruiser_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
            }
        }

        private void btnDoomfist_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Doomfist.Name;

            inisHeroes = new IniStream(appdata + "\\Doomfist.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p3, p1);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Doomfist.Daisy_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Doomfist.Lake_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Doomfist.Plains_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Doomfist.Sunset_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Doomfist.Leopard_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Doomfist.Painted_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.Gold; chB07.Text = Doomfist.Caution_SK + " (" + Cost.Legendary + ")";//Legendary
                chB08.BackColor = Color.Gold; chB08.Text = Doomfist.Irin_SK + " (" + Cost.Legendary + ")";
                chB09.BackColor = Color.Gold; chB09.Text = Doomfist.Avatar_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Doomfist.Spirit_SK + " (" + Cost.Legendary + ")";

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
            }
        }

        private void btnGeji_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Genji.Name;

            inisHeroes = new IniStream(appdata + "\\Genji.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Genji.Azurite_SK + " (" + Cost.Rare + ")";//Common
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Genji.Cinnabar_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Genji.Malachite_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Genji.Ochre_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Genji.Carbon_Fiber_SK + " (" + Cost.Epic + ")";//Rare
                chB06.BackColor = Color.DarkViolet; chB06.Text = Genji.Chrome_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Genji.Nihon_SK + " (" + Cost.Epic + ")";//Summer 16
                chB08.BackColor = Color.Gold; chB08.Text = Genji.Sparrow_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Genji.Young_Genji_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Genji.Bedouin_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Genji.Nomad_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Genji.Oni_SK + " (" + Cost.Legendary + ")";
                chB13.BackColor = Color.Gold; chB13.Text = Genji.Blackwatch_SK + " (" + Cost.LegendaryEvent + ")";//Uprising 17
                chB14.BackColor = Color.Gold; chB14.Text = Genji.Sentai_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
            }
        }

        private void btnHanzo_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Hanzo.Name;

            inisHeroes = new IniStream(appdata + "\\Hanzo.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Hanzo.Azuki_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Hanzo.Kinoko_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Hanzo.Midori_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Hanzo.Sora_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Hanzo.Cloud_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Hanzo.Dragon_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Hanzo.Demon_SK + " (" + Cost.Epic + ")";//Halloween 16
                chB08.BackColor = Color.Gold; chB08.Text = Hanzo.Young_Hanzo_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Hanzo.Young_Master_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Hanzo.Lone_Wolf_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Hanzo.Okami_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Hanzo.Cyberninja_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
            }
        }

        private void btnJunkrat_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Junkrat.Name;

            inisHeroes = new IniStream(appdata + "\\Junkrat.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Junkrat.Bleached_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Junkrat.Drowned_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Junkrat.Irradiated_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Junkrat.Rusted_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Junkrat.Jailbird_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Junkrat.Toasted_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Junkrat.Firework_SK + " (" + Cost.EpicEvent + ")";//Rooster 17
                chB08.BackColor = Color.Gold; chB08.Text = Junkrat.Fool_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Junkrat.Jester_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Junkrat.Hayseed_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Junkrat.Scarecrow_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Junkrat.Dr_Junkenstein_SK + " (" + Cost.Legendary + ")";//Halloween 16
                chB13.BackColor = Color.Gold; chB13.Text = Junkrat.Cricket_SK + " (" + Cost.LegendaryEvent + ")";//Summer 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
            }
        }

        private void btnLúcio_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Lúcio.Name;

            inisHeroes = new IniStream(appdata + "\\Lucio.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Lúcio.Azul_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Lúcio.Laranja_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Lúcio.Roxo_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Lúcio.Vermelho_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Lúcio.Auditiva_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Lúcio.Synaesthesia_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Lúcio.Andes_SK + " (" + Cost.EpicEvent + ")";//Winter 16
                chB08.BackColor = Color.Gold; chB08.Text = Lúcio.Hippityhop_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Lúcio.Ribbit_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Lúcio.Breakaway_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Lúcio.Slapshot_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Lúcio.Seleção_SK + " (" + Cost.Legendary + ")";//Summer 16
                chB13.BackColor = Color.Gold; chB13.Text = Lúcio.Striker_SK + " (" + Cost.Legendary + ")";//Summer 16
                chB14.BackColor = Color.Gold; chB14.Text = Lúcio.Jazzy_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
            }
        }

        private void btnMcCree_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + McCree.Name;

            inisHeroes = new IniStream(appdata + "\\McCree.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p5);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p6);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p7);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = McCree.Ebony_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = McCree.Lake_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = McCree.Sage_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = McCree.Wheat_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = McCree.On_The_Range_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = McCree.White_Hat_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = McCree.American_SK + " (" + Cost.Epic + ")";//Summer 16
                chB08.BackColor = Color.DarkViolet; chB08.Text = McCree.Scrooge_SK + " (" + Cost.EpicEvent + ")";//Winter 16
                chB09.BackColor = Color.Gold; chB09.Text = McCree.Gambler_SK + " (" + Cost.Legendary + ")";//Legendary
                chB10.BackColor = Color.Gold; chB10.Text = McCree.Riverboat_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = McCree.Mystery_Man_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = McCree.Vigilante_SK + " (" + Cost.Legendary + ")";
                chB13.BackColor = Color.Gold; chB13.Text = McCree.Lifeguard_SK + " (" + Cost.LegendaryEvent + ")";//Summer 17
                chB14.BackColor = Color.Gold; chB14.Text = McCree.Van_Helsing_SK + " (" + Cost.LegendaryEvent + ")";//Halloween 17
                chB15.BackColor = Color.Gold; chB15.Text = McCree.Blackwatch_SK + " (" + Cost.LegendaryEvent + ")";//Uprising 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SK15") == "1")
                {
                    chB15.Checked = true;
                }
            }
        }

        private void btnMei_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Mei.Name;

            inisHeroes = new IniStream(appdata + "\\Mei.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p3, p1);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p5);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p6);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p7);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p8);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p9);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Mei.Chrysanthemum_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Mei.Heliotrope_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Mei.Jade_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Mei.Persimmon_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Mei.Earthen_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Mei.Snow_Plum_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.Gold; chB07.Text = Mei.Firefighter_SK + " (" + Cost.Legendary + ")";//Legendary
                chB08.BackColor = Color.Gold; chB08.Text = Mei.Rescue_Mei_SK + " (" + Cost.Legendary + ")";
                chB09.BackColor = Color.Gold; chB09.Text = Mei.Abominable_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Mei.Yeti_Hunter_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Mei.Jiangshi_SK + " (" + Cost.LegendaryEvent + ")";//Halloween 17
                chB12.BackColor = Color.Gold; chB12.Text = Mei.Mei_rry_SK + " (" + Cost.LegendaryEvent + ")";//Winter 16
                chB13.BackColor = Color.Gold; chB13.Text = Mei.Chang_e_SK + " (" + Cost.LegendaryEvent + ")";//Rooster 17
                chB14.BackColor = Color.Gold; chB14.Text = Mei.Luna_SK + " (" + Cost.LegendaryEvent + ")";//Rooster 17
                chB15.BackColor = Color.Gold; chB15.Text = Mei.Beekeeper_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SK15") == "1")
                {
                    chB15.Checked = true;
                }
            }
        }

        private void btnMercy_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Mercy.Name;

            inisHeroes = new IniStream(appdata + "\\Mercy.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p3, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p4);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p5);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p6);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p7);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Mercy.Celestial_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Mercy.Mist_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Mercy.Orchid_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Mercy.Verdant_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Mercy.Amber_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Mercy.Cobalt_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Mercy.Eidgenossin_SK + " (" + Cost.Epic + ")";//Summer 16
                chB08.BackColor = Color.DarkViolet; chB08.Text = Mercy.Fortune_SK + " (" + Cost.EpicEvent + ")";//Rooster 17
                chB09.BackColor = Color.Gold; chB09.Text = Mercy.Sigrun_SK + " (" + Cost.Legendary + ")";//Legendary
                chB10.BackColor = Color.Gold; chB10.Text = Mercy.Valkyrie_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Mercy.Devil_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Mercy.IMP_SK + " (" + Cost.Legendary + ")";
                chB13.BackColor = Color.Gold; chB13.Text = Mercy.Winged_Victory_SK + " (" + Cost.LegendaryEvent + ")";//Summer 17
                chB14.BackColor = Color.Gold; chB14.Text = Mercy.Witch_SK + " (" + Cost.Legendary + ")";//Halloween 16
                chB15.BackColor = Color.Gold; chB15.Text = Mercy.Combat_Medic_Ziegler_SK + " (" + Cost.LegendaryEvent + ")";//Uprising 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SK15") == "1")
                {
                    chB15.Checked = true;
                }
            }
        }

        private void btnOrisa_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Orisa.Name;

            inisHeroes = new IniStream(appdata + "\\Orisa.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p3, p1);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p5);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Orisa.Dawn_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Orisa.Plains_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Orisa.Sunrise_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Orisa.Twilight_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Orisa.Camouflage_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Orisa.OR15_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.Gold; chB07.Text = Orisa.Dynastinae_SK + " (" + Cost.Legendary + ")";//Legendary
                chB08.BackColor = Color.Gold; chB08.Text = Orisa.Megasoma_SK + " (" + Cost.Legendary + ")";
                chB09.BackColor = Color.Gold; chB09.Text = Orisa.Carbon_Fiber_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Orisa.Protector_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Orisa.Null_Sector_SK + " (" + Cost.LegendaryEvent + ")";//Uprising 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
            }
        }

        private void btnPharah_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Pharah.Name;

            inisHeroes = new IniStream(appdata + "\\Pharah.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p5);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p6);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Pharah.Amethyst_SK + " (" + Cost.Rare + ")";//Rare
                chB01.BackColor = Color.DeepSkyBlue; chB02.Text = Pharah.Copper_SK + " (" + Cost.Rare + ")";
                chB01.BackColor = Color.DeepSkyBlue; chB03.Text = Pharah.Emerald_SK + " (" + Cost.Rare + ")";
                chB01.BackColor = Color.DeepSkyBlue; chB04.Text = Pharah.Titanium_SK + " (" + Cost.Rare + ")";
                chB01.BackColor = Color.DarkViolet; chB05.Text = Pharah.Anubis_SK + " (" + Cost.Epic + ")";//Epic
                chB01.BackColor = Color.DarkViolet; chB06.Text = Pharah.Jackal_SK + " (" + Cost.Epic + ")";
                chB01.BackColor = Color.DarkViolet; chB07.Text = Pharah.Possessed_SK + " (" + Cost.Epic + ")";//Halloween 16
                chB01.BackColor = Color.DarkViolet; chB08.Text = Pharah.Frostbite_SK + " (" + Cost.EpicEvent + ")";//Winter 16
                chB01.BackColor = Color.Gold; chB09.Text = Pharah.Mechaqueen_SK + " (" + Cost.Legendary + ")";//Legendary
                chB01.BackColor = Color.Gold; chB10.Text = Pharah.Raptorion_SK + " (" + Cost.Legendary + ")";
                chB01.BackColor = Color.Gold; chB11.Text = Pharah.Raindancer_SK + " (" + Cost.Legendary + ")";
                chB01.BackColor = Color.Gold; chB12.Text = Pharah.Thunderbird_SK + " (" + Cost.Legendary + ")";
                chB01.BackColor = Color.Gold; chB13.Text = Pharah.Security_Chief_SK + " (" + Lang.OriginGotY + ")";//Origin
                chB01.BackColor = Color.Gold; chB14.Text = Pharah.Bedouin_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
            }
        }

        private void btnReaper_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Reaper.Name;

            inisHeroes = new IniStream(appdata + "\\Reaper.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p8);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Reaper.Blood_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Reaper.Midnight_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Reaper.Moss_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Reaper.Royal_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Reaper.Desert_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Reaper.Wight_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Reaper.Shiver_SK + " (" + Cost.EpicEvent + ")";//Winter 16
                chB08.BackColor = Color.Gold; chB08.Text = Reaper.Nevermore_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Reaper.Plague_Doctor_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Reaper.El_Blanco_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Reaper.Mariachi_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Reaper.Blackwatch_Reyes_SK + " (" + Lang.OriginGotY + ")";//Origin
                chB13.BackColor = Color.Gold; chB13.Text = Reaper.Biker_SK + " (" + Cost.LegendaryEvent + ")";//Summer 17
                chB14.BackColor = Color.Gold; chB14.Text = Reaper.Dracula_SK + " (" + Cost.LegendaryEvent + ")";//Halloween 17
                chB15.BackColor = Color.Gold; chB15.Text = Reaper.Pumpkin_SK + " (" + Cost.Legendary + ")";//Halloween 16

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SK15") == "1")
                {
                    chB15.Checked = true;
                }
            }
        }

        private void btnReinhardt_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Reinhardt.Name;

            inisHeroes = new IniStream(appdata + "\\Reinhardt.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p5);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p6);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p7);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Reinhardt.Brass_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Reinhardt.Cobalt_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Reinhardt.Copper_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Reinhardt.Viridian_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Reinhardt.Bundeswehr_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Reinhardt.Paragon_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Reinhardt.Coldhardt_SK + " (" + Cost.Epic + ")";//Halloween 16
                chB08.BackColor = Color.Gold; chB08.Text = Reinhardt.Lieutenant_Wilhelm_SK + " (" + Cost.EpicEvent + ")";//Uprising 17
                chB09.BackColor = Color.Gold; chB09.Text = Reinhardt.Blackhardt_SK + " (" + Cost.Legendary + ")";//Legendary
                chB10.BackColor = Color.Gold; chB10.Text = Reinhardt.Bloodhardt_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Reinhardt.Lionhardt_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Reinhardt.Stonehardt_SK + " (" + Cost.Legendary + ")";
                chB13.BackColor = Color.Gold; chB13.Text = Reinhardt.Balderich_SK + " (" + Cost.Legendary + ")";
                chB14.BackColor = Color.Gold; chB14.Text = Reinhardt.Greifhardt_SK + " (" + Cost.Legendary + ")";
                chB15.BackColor = Color.Gold; chB15.Text = Reinhardt.Wujing_SK + " (" + Cost.LegendaryEvent + ")";//Rooster 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SK15") == "1")
                {
                    chB15.Checked = true;
                }
            }
        }

        private void btnRoadhog_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Roadhog.Name;

            inisHeroes = new IniStream(appdata + "\\Roadhog.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Roadhog.Kiwi_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Roadhog.Mud_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Roadhog.Sand_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Roadhog.Thistle_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Roadhog.Pigpen_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Roadhog.Stitched_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Roadhog.Rudolph_SK + " (" + Cost.EpicEvent + ")";//Winter 16
                chB08.BackColor = Color.Gold; chB08.Text = Roadhog.Islander_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Roadhog.Toa_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Roadhog.Mako_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Roadhog.Sharkbait_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Roadhog.Junkensteins_Monster_SK + " (" + Cost.Legendary + ")";//Halloween 16
                chB13.BackColor = Color.Gold; chB13.Text = Roadhog.Bajie_SK + " (" + Cost.LegendaryEvent + ")";//Rooster 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
            }
        }

        private void btnSoldier_76_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Soldier_76.Name;

            inisHeroes = new IniStream(appdata + "\\Soldier_76.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Soldier_76.Jet_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Soldier_76.Olive_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Soldier_76.Russet_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Soldier_76.Smoke_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Soldier_76.Bone_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Soldier_76.Golden_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Soldier_76.Immortal_SK + " (" + Cost.Epic + ")";//Halloween 16
                chB08.BackColor = Color.Gold; chB08.Text = Soldier_76.Commando_76_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Soldier_76.Night_Ops_76_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Soldier_76.Daredevil_76_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Soldier_76.Stunt_Rider_76_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Soldier_76.Strike_Commander_Morrison_SK + " (" + Lang.OriginGotY + ")";//Origin
                chB13.BackColor = Color.Gold; chB13.Text = Soldier_76.Grillmaster_76_SK + " (" + Cost.LegendaryEvent + ")";//Summer 17
                chB14.BackColor = Color.Gold; chB14.Text = Soldier_76.Cyborg_76_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SK15") == "1")
                {
                    chB15.Checked = true;
                }
            }
        }

        private void btnSombra_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Sombra.Name;

            inisHeroes = new IniStream(appdata + "\\Sombra.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Sombra.Cidro_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Sombra.Incendio_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Sombra.Mar_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Sombra.Noche_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Sombra.Glitch_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Sombra.Virus_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Sombra.Peppermint_SK + " (" + Cost.EpicEvent + ")";//Winter 16
                chB08.BackColor = Color.Gold; chB08.Text = Sombra.Azúcar_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Sombra.Los_Muertos_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Sombra.Augmented_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Sombra.Cyberspace_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Sombra.Tulum_SK + " (" + Cost.LegendaryEvent + ")";//Summer 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
            }
        }

        private void btnSymmetra_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Symmetra.Name;

            inisHeroes = new IniStream(appdata + "\\Symmetra.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p5);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p6);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Symmetra.Cardamom_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Symmetra.Hyacinth_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Symmetra.Saffron_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Symmetra.Technomancer_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Symmetra.Regal_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Symmetra.Utopaea_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Symmetra.Vampire_SK + " (" + Cost.Epic + ")";//Halloween 16
                chB08.BackColor = Color.DarkViolet; chB08.Text = Symmetra.Qipao_SK + " (" + Cost.EpicEvent + ")";//Rooster 17
                chB09.BackColor = Color.Gold; chB09.Text = Symmetra.Architech_SK + " (" + Cost.Legendary + ")";//Legendary
                chB10.BackColor = Color.Gold; chB10.Text = Symmetra.Vishkar_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Symmetra.Devi_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Symmetra.Goddess_SK + " (" + Cost.Legendary + ")";
                chB13.BackColor = Color.Gold; chB13.Text = Symmetra.Dragon_SK + " (" + Cost.LegendaryEvent + ")";//Halloween 17
                chB14.BackColor = Color.Gold; chB14.Text = Symmetra.Oasis_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
            }
        }

        private void btnTorbjörn_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Torbjörn.Name;

            inisHeroes = new IniStream(appdata + "\\Torbjorn.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p8);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Torbjörn.Blå_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Torbjörn.Citron_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Torbjörn.Grön_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Torbjörn.Plommon_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Torbjörn.Cathode_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Torbjörn.Woodclad_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Torbjörn.Tre_Kronor_SK + " (" + Cost.Epic + ")";//Summer 16
                chB08.BackColor = Color.Gold; chB08.Text = Torbjörn.Chopper_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Torbjörn.Deadlock_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Torbjörn.Barbarossa_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Torbjörn.Blackbeard_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Torbjörn.Viking_SK + " (" + Cost.LegendaryEvent + ")";//Halloween 17
                chB13.BackColor = Color.Gold; chB13.Text = Torbjörn.Santaclad_SK + " (" + Cost.LegendaryEvent + ")";//Winter 16
                chB14.BackColor = Color.Gold; chB14.Text = Torbjörn.Chief_Engineer_Lindholm_SK + " (" + Cost.LegendaryEvent + ")";//Uprising 17
                chB15.BackColor = Color.Gold; chB15.Text = Torbjörn.Ironclad_SK + " (" + Cost.LegendaryEvent + ")";//Uprising 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SK15") == "1")
                {
                    chB15.Checked = true;
                }
            }
        }

        private void btnTracer_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Tracer.Name;

            inisHeroes = new IniStream(appdata + "\\Tracer.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p8);
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p9);
                chB17.Visible = true; chB17.Location = new Point(gBAllWeited4p3, p10);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Tracer.Electric_Purple_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Tracer.Hot_Pink_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Tracer.Neon_Green_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Tracer.Royal_Blue_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Tracer.Posh_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Tracer.Sporty_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Tracer.Rose_SK + " (" + Cost.EpicEvent + ")";//Rooster 17
                chB08.BackColor = Color.Gold; chB08.Text = Tracer.Punk_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Tracer.Ultraviolet_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Tracer.Mach_T_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Tracer.T_Racer_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Tracer.Slipstream_SK + " (" + Lang.OriginGotY + ")";//Origin
                chB13.BackColor = Color.Gold; chB13.Text = Tracer.Sprinter_SK + " (" + Cost.Legendary + ")";//Summer 16
                chB14.BackColor = Color.Gold; chB14.Text = Tracer.Track_and_Field_SK + " (" + Cost.Legendary + ")";//Summer 16
                chB15.BackColor = Color.Gold; chB15.Text = Tracer.Jingle_SK + " (" + Cost.LegendaryEvent + ")";//Winter 16
                chB16.BackColor = Color.Gold; chB16.Text = Tracer.Cadet_Oxton_SK + " (" + Cost.LegendaryEvent + ")";//Uprising 17
                chB17.BackColor = Color.Gold; chB17.Text = Tracer.Graffiti_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SK15") == "1")
                {
                    chB15.Checked = true;
                }
                if (inisHeroes.Read("SK16") == "1")
                {
                    chB16.Checked = true;
                }
                if (inisHeroes.Read("SK17") == "1")
                {
                    chB17.Checked = true;
                }
            }
        }

        private void btnWidowmaker_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Widowmaker.Name;

            inisHeroes = new IniStream(appdata + "\\Widowmaker.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Widowmaker.Ciel_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Widowmaker.Nuit_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Widowmaker.Rose_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Widowmaker.Vert_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Widowmaker.Patina_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Widowmaker.Winter_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Widowmaker.Tricolore_SK + " (" + Cost.Epic + ")";//Summer 16
                chB08.BackColor = Color.Gold; chB08.Text = Widowmaker.Odette_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Widowmaker.Odile_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Widowmaker.Comtesse_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Widowmaker.Huntress_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Widowmaker.Noire_SK + " (" + Lang.Prepurchase + ")";//Prepurchase
                chB13.BackColor = Color.Gold; chB13.Text = Widowmaker.Côte_DAzur_SK + " (" + Cost.LegendaryEvent + ")";//Summer 17
                chB14.BackColor = Color.Gold; chB14.Text = Widowmaker.Talon_SK + " (" + Cost.LegendaryEvent + ")";//Uprising 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
            }
        }

        private void btnWinston_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Winston.Name;

            inisHeroes = new IniStream(appdata + "\\Winston.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Winston.Atmosphere_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Winston.Banana_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Winston.Forest_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Winston.Red_Planet_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Winston.Desert_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Winston.Horizon_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Winston.Blizzcon_2017_SK + " (" + Lang.BlizzCon + ")";//BlizzCon 17
                chB08.BackColor = Color.Gold; chB08.Text = Winston.Frogston_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Winston.Undersea_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Winston.Explorer_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Winston.Safari_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Winston.Yeti_SK + " (" + Cost.LegendaryEvent + ")";//Winter 16
                chB13.BackColor = Color.Gold; chB13.Text = Winston.Wukong_SK + " (" + Cost.LegendaryEvent + ")";//Rooster 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
            }
        }

        private void btnZarya_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Zarya.Name;

            inisHeroes = new IniStream(appdata + "\\Zarya.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p8);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Zarya.Brick_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Zarya.Goldenrod_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Zarya.Taiga_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Zarya.Violet_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Zarya.Dawn_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Zarya.Midnight_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Zarya.Frosted_SK + " (" + Cost.EpicEvent + ")";//Winter 16
                chB08.BackColor = Color.Gold; chB08.Text = Zarya.Arctic_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Zarya.Siberian_Front_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Zarya.Cybergoth_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Zarya.Industrial_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Zarya.Champion_SK + " (" + Cost.Legendary + ")";//Summer 16
                chB13.BackColor = Color.Gold; chB13.Text = Zarya.Weightlifter_SK + " (" + Cost.Legendary + ")";//Summer 16
                chB14.BackColor = Color.Gold; chB14.Text = Zarya.Totally_80s_SK + " (" + Cost.LegendaryEvent + ")";//Halloween 17
                chB15.BackColor = Color.Gold; chB15.Text = Zarya.Cyberian_SK + " (" + Cost.LegendaryEvent + ")";//Annyver 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
                if (inisHeroes.Read("SK15") == "1")
                {
                    chB15.Checked = true;
                }
            }
        }

        private void btnZenyatta_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Zenyatta.Name;

            inisHeroes = new IniStream(appdata + "\\Zenyatta.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7);

                chB01.BackColor = Color.DeepSkyBlue; chB01.Text = Zenyatta.Air_SK + " (" + Cost.Rare + ")";//Rare
                chB02.BackColor = Color.DeepSkyBlue; chB02.Text = Zenyatta.Earth_SK + " (" + Cost.Rare + ")";
                chB03.BackColor = Color.DeepSkyBlue; chB03.Text = Zenyatta.Leaf_SK + " (" + Cost.Rare + ")";
                chB04.BackColor = Color.DeepSkyBlue; chB04.Text = Zenyatta.Water_SK + " (" + Cost.Rare + ")";
                chB05.BackColor = Color.DarkViolet; chB05.Text = Zenyatta.Ascendant_SK + " (" + Cost.Epic + ")";//Epic
                chB06.BackColor = Color.DarkViolet; chB06.Text = Zenyatta.Harmonious_SK + " (" + Cost.Epic + ")";
                chB07.BackColor = Color.DarkViolet; chB07.Text = Zenyatta.Skullyatta_SK + " (" + Cost.Epic + ")";//Halloween 16
                chB08.BackColor = Color.Gold; chB08.Text = Zenyatta.Djinnyatta_SK + " (" + Cost.Legendary + ")";//Legendary
                chB09.BackColor = Color.Gold; chB09.Text = Zenyatta.Ifrit_SK + " (" + Cost.Legendary + ")";
                chB10.BackColor = Color.Gold; chB10.Text = Zenyatta.Ra_SK + " (" + Cost.Legendary + ")";
                chB11.BackColor = Color.Gold; chB11.Text = Zenyatta.Sunyatta_SK + " (" + Cost.Legendary + ")";
                chB12.BackColor = Color.Gold; chB12.Text = Zenyatta.Cultist_SK + " (" + Cost.LegendaryEvent + ")";//Halloween 17
                chB13.BackColor = Color.Gold; chB13.Text = Zenyatta.Nutcracker_SK + " (" + Cost.LegendaryEvent + ")";//Winter 16
                chB14.BackColor = Color.Gold; chB14.Text = Zenyatta.Sanzang_SK + " (" + Cost.LegendaryEvent + ")";//Rooser 17

                if (inisHeroes.Read("SK01") == "1")
                {
                    chB01.Checked = true;
                }
                if (inisHeroes.Read("SK02") == "1")
                {
                    chB02.Checked = true;
                }
                if (inisHeroes.Read("SK03") == "1")
                {
                    chB03.Checked = true;
                }
                if (inisHeroes.Read("SK04") == "1")
                {
                    chB04.Checked = true;
                }
                if (inisHeroes.Read("SK05") == "1")
                {
                    chB05.Checked = true;
                }
                if (inisHeroes.Read("SK06") == "1")
                {
                    chB06.Checked = true;
                }
                if (inisHeroes.Read("SK07") == "1")
                {
                    chB07.Checked = true;
                }
                if (inisHeroes.Read("SK08") == "1")
                {
                    chB08.Checked = true;
                }
                if (inisHeroes.Read("SK09") == "1")
                {
                    chB09.Checked = true;
                }
                if (inisHeroes.Read("SK10") == "1")
                {
                    chB10.Checked = true;
                }
                if (inisHeroes.Read("SK11") == "1")
                {
                    chB11.Checked = true;
                }
                if (inisHeroes.Read("SK12") == "1")
                {
                    chB12.Checked = true;
                }
                if (inisHeroes.Read("SK13") == "1")
                {
                    chB13.Checked = true;
                }
                if (inisHeroes.Read("SK14") == "1")
                {
                    chB14.Checked = true;
                }
            }
        }

        private void HeroeRead()
        {

        }

        private void chB01_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB01.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK01", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM01", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP01", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL01", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP01", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI01", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI01", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("01", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK01", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM01", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP01", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL01", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP01", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI01", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI01", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("01", "0");
                    }
                }
            }
        }

        private void chB02_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB02.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK02", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM02", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP02", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL02", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP02", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI02", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI02", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("02", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK02", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM02", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP02", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL02", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP02", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI02", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI02", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("02", "0");
                    }
                }
            }
        }

        private void chB03_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB03.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK03", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM03", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP03", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL03", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP03", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI03", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI03", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("03", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK03", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM03", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP03", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL03", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP03", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI03", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI03", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("03", "0");
                    }
                }
            }
        }

        private void chB04_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB04.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK04", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM04", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP04", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL04", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP04", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI04", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI04", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("04", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK04", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM04", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP04", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL04", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP04", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI04", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI04", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("04", "0");
                    }
                }
            }
        }

        private void chB05_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB05.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK05", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM05", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP05", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL05", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP05", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI05", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI05", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("05", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK05", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM05", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP05", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL05", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP05", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI05", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI05", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("05", "0");
                    }
                }
            }
        }

        private void chB06_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB06.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK06", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM06", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP06", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL06", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP06", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI06", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI06", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("06", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK06", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM06", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP06", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL06", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP06", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI06", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI06", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("06", "0");
                    }
                }
            }
        }

        private void chB07_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB07.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK07", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM07", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP07", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL07", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP07", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI07", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI07", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("07", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK07", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM07", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP07", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL07", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP07", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI07", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI07", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("07", "0");
                    }
                }
            }
        }

        private void chB08_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB08.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK08", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM08", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP08", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL08", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP08", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI08", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI08", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("08", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK08", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM08", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP08", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL08", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP08", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI08", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI08", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("08", "0");
                    }
                }
            }
        }

        private void chB09_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB09.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK09", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM09", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP09", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL09", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP09", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI09", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI09", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("09", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK09", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM09", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP09", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL09", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP09", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI09", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI09", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("09", "0");
                    }
                }
            }
        }

        private void chB10_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB10.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK10", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM10", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP10", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL10", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP10", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI10", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI10", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("10", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK10", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM10", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP10", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL10", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP10", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI10", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI10", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("10", "0");
                    }
                }
            }
        }

        private void chB11_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB11.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK11", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM11", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP11", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL11", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP11", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI11", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI11", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("11", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK11", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM11", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP11", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL11", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP11", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI11", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI11", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("11", "0");
                    }
                }
            }
        }

        private void chB12_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB12.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK12", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM12", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP12", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL12", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP12", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI12", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI12", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("12", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK12", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM12", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP12", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL12", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP12", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI12", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI12", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("12", "0");
                    }
                }
            }
        }

        private void chB13_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB13.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK13", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM13", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP13", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL13", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP13", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI13", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI13", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("13", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK13", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM13", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP13", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL13", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP13", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI13", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI13", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("13", "0");
                    }
                }
            }
        }

        private void chB14_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB14.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK14", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM14", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP14", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL14", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP14", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI14", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI14", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("14", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK14", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM14", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP14", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL14", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP14", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI14", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI14", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("14", "0");
                    }
                }
            }
        }

        private void chB15_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB15.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK15", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM15", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP15", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL15", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP15", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI15", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI15", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("15", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK15", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM15", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP15", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL15", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP15", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI15", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI15", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("15", "0");
                    }
                }
            }
        }

        private void chB16_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB16.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK16", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM16", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP16", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL16", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP16", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI16", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI16", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("16", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK16", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM16", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP16", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL16", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP16", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI16", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI16", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("16", "0");
                    }
                }
            }
        }

        private void chB17_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB17.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK17", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM17", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP17", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL17", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP17", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI17", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI17", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("17", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK17", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM17", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP17", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL17", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP17", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI17", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI17", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("17", "0");
                    }
                }
            }
        }

        private void chB18_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB18.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK18", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM18", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP18", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL18", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP18", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI18", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI18", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("18", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK18", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM18", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP18", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL18", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP18", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI18", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI18", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("18", "0");
                    }
                }
            }
        }

        private void chB19_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB19.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK19", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM19", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP19", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL19", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP19", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI19", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI19", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("19", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK19", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM19", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP19", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL19", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP19", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI19", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI19", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("19", "0");
                    }
                }
            }
        }

        private void chB20_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB20.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK20", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM20", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP20", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL20", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP20", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI20", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI20", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("20", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK20", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM20", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP20", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL20", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP20", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI20", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI20", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("20", "0");
                    }
                }
            }
        }

        private void chB21_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB21.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK21", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM21", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP21", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL21", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP21", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI21", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI21", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("21", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK21", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM21", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP21", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL21", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP21", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI21", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI21", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("21", "0");
                    }
                }
            }
        }

        private void chB22_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB22.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK22", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM22", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP22", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL22", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP22", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI22", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI22", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("22", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK22", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM22", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP22", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL22", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP22", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI22", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI22", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("22", "0");
                    }
                }
            }
        }

        private void chB23_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB23.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK23", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM23", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP23", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL23", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP23", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI23", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI23", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("23", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK23", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM23", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP23", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL23", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP23", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI23", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI23", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("23", "0");
                    }
                }
            }
        }

        private void chB24_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB24.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK24", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM24", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP24", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL24", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP24", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI24", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI24", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("24", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK24", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM24", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP24", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL24", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP24", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI24", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI24", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("24", "0");
                    }
                }
            }
        }

        private void chB25_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB25.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK25", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM25", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP25", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL25", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP25", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI25", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI25", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("25", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK25", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM25", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP25", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL25", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP25", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI25", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI25", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("25", "0");
                    }
                }
            }
        }

        private void chB26_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB26.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK26", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM26", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP26", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL26", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP26", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI26", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI26", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("26", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK26", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM26", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP26", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL26", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP26", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI26", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI26", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("26", "0");
                    }
                }
            }
        }

        private void chB27_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB27.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK27", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM27", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP27", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL27", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP27", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI27", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI27", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("27", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK27", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM27", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP27", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL27", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP27", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI27", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI27", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("27", "0");
                    }
                }
            }
        }

        private void chB28_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB28.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK28", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM28", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP28", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL28", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP28", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI28", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI28", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("28", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK28", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM28", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP28", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL28", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP28", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI28", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI28", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("28", "0");
                    }
                }
            }
        }

        private void chB29_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB29.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK29", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM29", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP29", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL29", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP29", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI29", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI29", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("29", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK29", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM29", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP29", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL29", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP29", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI29", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI29", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("29", "0");
                    }
                }
            }
        }

        private void chB30_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB30.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK30", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM30", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP30", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL30", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP30", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI30", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI30", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("30", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK30", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM30", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP30", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL30", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP30", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI30", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI30", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("30", "0");
                    }
                }
            }
        }

        private void chB31_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB31.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK31", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM31", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP31", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL31", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP31", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI31", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI31", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("31", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK31", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM31", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP31", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL31", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP31", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI31", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI31", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("31", "0");
                    }
                }
            }
        }

        private void chB32_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB32.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK32", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM32", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP32", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL32", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP32", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI32", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI32", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("32", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK32", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM32", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP32", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL32", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP32", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI32", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI32", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("32", "0");
                    }
                }
            }
        }

        private void chB33_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB33.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK33", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM33", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP33", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL33", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP33", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI33", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI33", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("33", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK33", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM33", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP33", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL33", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP33", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI33", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI33", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("33", "0");
                    }
                }
            }
        }

        private void chB34_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB34.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK34", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM34", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP34", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL34", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP34", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI34", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI34", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("34", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK34", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM34", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP34", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL34", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP34", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI34", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI34", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("34", "0");
                    }
                }
            }
        }

        private void chB35_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB35.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK35", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM35", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP35", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL35", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP35", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI35", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI35", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("35", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK35", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM35", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP35", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL35", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP35", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI35", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI35", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("35", "0");
                    }
                }
            }
        }

        private void chB36_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB36.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK36", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM36", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP36", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL36", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP36", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI36", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI36", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("36", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK36", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM36", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP36", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL36", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP36", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI36", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI36", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("36", "0");
                    }
                }
            }
        }

        private void chB37_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB37.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK37", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM37", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP37", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL37", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP37", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI37", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI37", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("37", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK37", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM37", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP37", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL37", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP37", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI37", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI37", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("37", "0");
                    }
                }
            }
        }

        private void chB38_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB38.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK38", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM38", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP38", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL38", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP38", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI38", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI38", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("38", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK38", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM38", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP38", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL38", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP38", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI38", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI38", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("38", "0");
                    }
                }
            }
        }

        private void chB39_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB39.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK39", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM39", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP39", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL39", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP39", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI39", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI39", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("39", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK39", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM39", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP39", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL39", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP39", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI39", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI39", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("39", "0");
                    }
                }
            }
        }

        private void chB40_CheckedChanged(object sender, EventArgs e)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (chB40.Checked == true)
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK40", "1");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM40", "1");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP40", "1");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL40", "1");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP40", "1");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI40", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI40", "1");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("40", "1");
                    }
                }
                else
                {
                    if (BackSave == Lang.Skins)
                    {
                        inisHeroes.Write("SK40", "0");
                    }
                    if (BackSave == Lang.Emotes)
                    {
                        inisHeroes.Write("EM40", "0");
                    }
                    if (BackSave == Lang.VictoryPoses)
                    {
                        inisHeroes.Write("VP40", "0");
                    }
                    if (BackSave == Lang.VoiceLines)
                    {
                        inisHeroes.Write("VL40", "0");
                    }
                    if (BackSave == Lang.Sprays)
                    {
                        inisHeroes.Write("SP40", "0");
                    }
                    if (BackSave == Lang.HighlightIntros)
                    {
                        inisHeroes.Write("HI40", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe != "PI")
                    {
                        inisHeroes.Write("PI40", "0");
                    }
                    if (BackSave == Lang.PlayerIcons && Heroe == "PI")
                    {
                        inisPI.Write("40", "0");
                    }
                }
            }
        }
    }
}
