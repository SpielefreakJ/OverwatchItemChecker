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
            gBWelcome.Text = Lang.A;
            btnWelcomeClose.Text = Lang.Close;
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

        private void btnAna_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Ana.Name;

            //Auslesen der "Settings.ini" Datei und speichern in IniStream inisSettings
            String appdata = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            appdata += "\\OWItemTracker";
            Directory.CreateDirectory(appdata);
            inisHeroes = new IniStream(appdata + "\\Ana.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
                chB04.Visible = true;
                chB05.Visible = true;
                chB06.Visible = true;
                chB07.Visible = true;
                chB08.Visible = true;
                chB09.Visible = true;
                chB10.Visible = true;
                chB11.Visible = true;
                chB12.Visible = true;
                chB13.Visible = true;
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
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
                chB04.Visible = true;
                chB05.Visible = true;
                chB06.Visible = true;
                chB07.Visible = true;
                chB08.Visible = true;
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
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
                chB04.Visible = true;
                chB05.Visible = true;
                chB06.Visible = true;
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
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
                chB04.Visible = true;
                chB05.Visible = true;
                chB06.Visible = true;
                chB07.Visible = true;
                chB08.Visible = true;
                chB09.Visible = true;
                chB10.Visible = true;
                chB11.Visible = true;
                chB12.Visible = true;
                chB13.Visible = true;
                chB14.Visible = true;
                chB15.Visible = true;
                chB16.Visible = true;
                chB17.Visible = true;
                chB18.Visible = true;
                chB19.Visible = true;
                chB20.Visible = true;
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
            }
            if (BackSave == Lang.Sprays)
            {
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
                chB04.Visible = true;
                chB05.Visible = true;
                chB06.Visible = true;
                chB07.Visible = true;
                chB08.Visible = true;
                chB09.Visible = true;
                chB10.Visible = true;
                chB11.Visible = true;
                chB12.Visible = true;
                chB13.Visible = true;
                chB14.Visible = true;
                chB15.Visible = true;
                chB16.Visible = true;
                chB17.Visible = true;
                chB18.Visible = true;
                chB19.Visible = true;
                chB20.Visible = true;
                chB21.Visible = true;
                chB22.Visible = true;
                chB23.Visible = true;
                chB24.Visible = true;
                chB25.Visible = true;
                chB26.Visible = true;
                chB27.Visible = true;
                chB28.Visible = true;
                chB29.Visible = true;
                chB30.Visible = true;
                chB31.Visible = true;
                chB32.Visible = true;
                chB33.Visible = true;
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
            }
            if (BackSave == Lang.HighlightIntros)
            {
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
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
            if (BackSave == Lang.HighlightIntros)
            {
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
                chB04.Visible = true;
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
            }
        }

        private void btnBastion_Click(object sender, EventArgs e)
        {
            btnHeroeinvisible();
            gbAll.Text += " / " + Bastion.Name;

            //Auslesen der "Settings.ini" Datei und speichern in IniStream inisSettings
            String appdata = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            appdata += "\\OWItemTracker";
            Directory.CreateDirectory(appdata);
            inisHeroes = new IniStream(appdata + "\\Bastion.ini");
            Heroe = "H";

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave == Lang.Skins)
            {
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
                chB04.Visible = true;
                chB05.Visible = true;
                chB06.Visible = true;
                chB07.Visible = true;
                chB08.Visible = true;
                chB09.Visible = true;
                chB10.Visible = true;
                chB11.Visible = true;
                chB12.Visible = true;
                chB13.Visible = true;
                chB14.Visible = true;
                chB15.Visible = true;
                chB16.Visible = true;
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
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
                chB04.Visible = true;
                chB05.Visible = true;
                chB06.Visible = true;
                chB07.Visible = true;
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
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
                chB04.Visible = true;
                chB05.Visible = true;
                chB06.Visible = true;
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
                chB01.Visible = true;
                chB02.Visible = true;
                chB03.Visible = true;
                chB04.Visible = true;
                chB05.Visible = true;
                chB06.Visible = true;
                chB07.Visible = true;
                chB08.Visible = true;
                chB09.Visible = true;
                chB10.Visible = true;
                chB11.Visible = true;
                chB12.Visible = true;
                chB13.Visible = true;
                chB14.Visible = true;
                chB15.Visible = true;
                chB16.Visible = true;
                chB17.Visible = true;
                chB18.Visible = true;
                chB19.Visible = true;
                chB20.Visible = true;
                chB21.Visible = true;
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
                if (chB01.Checked == true)
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
    }
}
