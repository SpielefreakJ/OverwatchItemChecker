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

        #region Variablen

        IniStream inisSettings = null;
        IniStream inisHeroes = null;
        //IniStream inisPI = null;
        CIniCreator inic;
        CCost Cost;
        //Languages and Costs
        Translate.L_Translate Lang;
        Translate.L_Ana Ana;
        Translate.L_Bastion Bastion;
        Translate.L_Brigitte Brigitte;
        Translate.L_DVa DVa;
        Translate.L_Doomfist Doomfist;
        Translate.L_Genji Genji;
        Translate.L_Hanzo Hanzo;
        Translate.L_Junkrat Junkrat;
        Translate.L_Lúcio Lúcio;
        Translate.L_McCree McCree;
        Translate.L_Mei Mei;
        Translate.L_Mercy Mercy;
        Translate.L_Moira Moira;
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
        Translate.L_WreckingBall WreckingBall;
        Translate.L_Zarya Zarya;
        Translate.L_Zenyatta Zenyatta;
        //Images
        CHeroImage ItemImage;
        CMediaPlayer MediaPlayer;
        //
        //Others
        bool NoChangeText = false;
        string Language = "EN", LangBrücke = "", sBackColor = "Blue";
        int newSave = 0;
        int gBAllWeited3, gBAllWeited3p1, gBAllWeited3p2;
        int gBAllWeited4, gBAllWeited4p1, gBAllWeited4p2, gBAllWeited4p3;
        //int gBAllWeited5, gBAllWeited5p1, gBAllWeited5p2, gBAllWeited5p3, gBAllWeited5p4;
        int p1 = 194; int p2 = 217; int p3 = 240; int p4 = 263; int p5 = 286; int p6 = 309; int p7 = 332; int p8 = 355; int p9 = 378; int p10 = 401;

        string BackSave, BackSave2;

        String MyDocuments = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        #endregion

        public Form1()
        {
            Lang = new Translate.L_Translate(Language);

            //Erstellen des Verzeichnisses "OWItemTracker" in C:\\User\[Username]\Dokumente
            MyDocuments += "\\OWItemTracker";
            Directory.CreateDirectory(MyDocuments);
            inic = new CIniCreator(MyDocuments);
            Lang.Path = MyDocuments;

            //Auslesen der "Settings.ini" Datei und speichern in IniStream inisSettings
            inisSettings = new IniStream(MyDocuments + "\\Settings.ini");

            try
            {
                if (inisSettings.Read("SaveVersion") == "2")
                {

                }
                else
                {
                    DialogResult result = MessageBox.Show("Incompatible Save-File found!\nWhen pressing OK, the Save-Folder will be deletet!", "Incompatible Save-File", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    //MessageBox.Show("Incompatible Save-File found!\nPlease delete the OverwatchItemTracker-Folder \nin your Documents!", "Incompatible Save-File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                    if (result == DialogResult.OK)
                    {
                        Directory.Delete(MyDocuments, true);
                        Directory.CreateDirectory(MyDocuments);
                        newSave = 1;
                        MessageBox.Show(Lang.DeleteSavesS, "Deleting...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                inisSettings.Write("SaveVersion", "2");
            }


            #region OldSave
            //Absicherung, damit alle die die alten saves benutzt haben auch neue anlegen und alle, die das programm zum ersten mal starten diese nachricht nicht bekommen.
            //try
            //{
            //    if ("" == inisSettings.Read("NewStart") && "" == inisSettings.Read("Lang"))
            //    {
            //        inisSettings.Write("NewStart", "1");
            //        inisSettings.Write("NewSave", "true");
            //    }
            //    if (true == Convert.ToBoolean(inisSettings.Read("NewSave")) && "1" == inisSettings.Read("NewStart"))
            //    { }
            //    else
            //    {
            //        bool i = false;
            //        i = Convert.ToBoolean(inisSettings.Read("t"));
            //    }
            //}
            //catch
            //{
            //    DialogResult result = MessageBox.Show(Lang.DeleteSaves, "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //    if (result == DialogResult.Cancel)
            //    {
            //        this.Close();
            //    }
            //    if (result == DialogResult.OK)
            //    {
            //        Directory.Delete(MyDocuments, true);
            //        Directory.CreateDirectory(MyDocuments);
            //        newSave = 1;
            //        MessageBox.Show(Lang.DeleteSavesS, "Deleting...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            #endregion

            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            InitializeComponent();
            IniRead();
            KlassenInst();
            ChangePos();
            Texte();
            Tooltips();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            IniSave();
            //MessageBox.Show(Lang.AppClose);
        }

        private void IniSave()
        {
            Directory.CreateDirectory(MyDocuments);
            //Speichern der änderrung unter "Lang" in der Settings.ini
            inisSettings.Write("SaveVersion", "2");

            if (Language == "")
            {
                Language = "EN";
            }
            inisSettings.Write("Lang", Language);
            if (sBackColor == "")
            {
                sBackColor = "Blue";
            }
            inisSettings.Write("BackColor", sBackColor);
        }

        private void IniRead()
        {
            //Farbe auslesen und auf dem Hintergrund anwenden
            Language = inisSettings.Read("Lang");
            sBackColor = inisSettings.Read("BackColor");
            DisabledLangs();
            Lang.ChangeLang = Language;

            if (sBackColor == "White")
            {
                this.BackColor = Color.White;
            }
            if (sBackColor == "Gray")
            {
                this.BackColor = Color.DimGray;
            }
        }
        private void DisabledLangs()
        {
            if (Language == "DE")
            {
                Language = "EN";
            }

            btnLangGerman.Enabled = false;
        }

        private void KlassenInst()
        {
            Cost = new CCost();

            //Languages and Costs
            Ana = new Translate.L_Ana(Language);
            Bastion = new Translate.L_Bastion(Language);
            Brigitte = new Translate.L_Brigitte(Language);
            DVa = new Translate.L_DVa(Language);
            Doomfist = new Translate.L_Doomfist(Language);
            Genji = new Translate.L_Genji(Language);
            Hanzo = new Translate.L_Hanzo(Language);
            Junkrat = new Translate.L_Junkrat(Language);
            Lúcio = new Translate.L_Lúcio(Language);
            McCree = new Translate.L_McCree(Language);
            Mei = new Translate.L_Mei(Language);
            Mercy = new Translate.L_Mercy(Language);
            Moira = new Translate.L_Moira(Language);
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
            WreckingBall = new Translate.L_WreckingBall(Language);
            Zarya = new Translate.L_Zarya(Language);
            Zenyatta = new Translate.L_Zenyatta(Language);

            ItemImage = new CHeroImage(Language);
        }

        private void Texte()
        {
            //Erste mal ausrechnen, wieviel alles zusammen Kostet
            lblChanges.Text = Lang.ChangesText;

            gbAll.Visible = false;
            gBLang.Visible = false;
            gBWelcome.Text = Lang.Welcome;
            btnWelcomeClose.Text = Lang.Close + " (3)"; tmrWelcome.Enabled = true;
            lblCopyrightVersion.Text = Lang.CopyrightVersion;
            lblContributor.Text = "Contributor:\nProgramm: SpielefreakJ\n\nLanguages:\nEnglish: SpielefreakJ\nGerman: SpielefreakJ\n\nInstaller: @SnowBlinderP";
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
            btnOWLeague.Text = Lang.OWLeague;
            btnPlayerIcons.Text = Lang.PlayerIcons;
            //Eventbuttons
            btnSummer.Text = Lang.Summer;
            btnHalloween.Text = Lang.Halloween;
            btnWinter.Text = Lang.Winter;
            btnRooster.Text = Lang.Rooster;
            btnUprising.Text = Lang.Uprising;
            btnAnnyver.Text = Lang.Annyver;
            //Heroebuttons
            btnBackHero.Text = Lang.Back;
            //More info about remaining costs
            TextRemaining("All");
        }

        private void TextRemaining(string Heroe)
        {
            Lang.RemainingHeroe = Heroe;
            lblKosten.Text = Lang.Remaining;

            //More info about remaining costs
            btnMoreCost.Text = Lang.MoreCost;
            gBMoreCost.Text = "";
            lblMoreInfoCost.Text = Lang.RemMoreInfo1;
            lblMoreInfoCost2.Text = Lang.RemMoreInfo2;
        }

        private void ChangePos()
        {
            this.Width = 912; this.Height = 751;

            gBAllWeited3 = gbAll.Width;
            gBAllWeited3 /= 3;
            gBAllWeited3p1 = gBAllWeited3 - 57;
            gBAllWeited3p2 = gBAllWeited3 * 2 - 57;

            gBAllWeited4 = gbAll.Width;
            gBAllWeited4 /= 4;
            gBAllWeited4p1 = gBAllWeited4 - 57;
            gBAllWeited4p2 = gBAllWeited4 * 2 - 57;
            gBAllWeited4p3 = gBAllWeited4 * 3 - 57;


            gBWelcome.Location = new Point(12, 12);
            gBWelcome.Width = 872; gBWelcome.Height = 688;

            gBLang.Location = new Point(684, 493);
            gBLang.Width = 200; gBLang.Height = 207;

            gbAll.Location = new Point(16, 29);
            gbAll.Width = 868; gbAll.Height = 642;

            gBMoreCost.Location = new Point(16, 29);
            gBMoreCost.Width = 868; gBMoreCost.Height = 671;

            btnBackHero.Location = new Point(16, 677);

            HeroButton();

            //Farben der Checkboxen entfernen
            chB01.BackColor = Color.Transparent;
            chB02.BackColor = Color.Transparent;
            chB03.BackColor = Color.Transparent;
            chB04.BackColor = Color.Transparent;
        }

        private void HeroButton()
        {

            int Breite = this.Width / 10;
            int Breite5 = this.Width / 2 - 60 - 28;
            int Breite1 = Breite5 - 240, Breite2 = Breite5 - 180, Breite3 = Breite5 - 120, Breite4 = Breite5 - 60;
            int Breite6 = Breite5 + 60, Breite7 = Breite5 + 120, Breite8 = Breite5 + 180, Breite9 = Breite5 + 240, Breite10 = Breite5 + 300;
            int Zeile2 = this.Height / 2 - 50;
            int Zeile1 = Zeile2 - 100, Zeile3 = Zeile2 + 100;

            #region HeroesImageCreate
            //Ana
            Controls.Add(Ana);
            Ana.Location = new Point(Breite1, Zeile1);
            Ana.Click += Ana_Click;

            //Bastion
            Controls.Add(Bastion);
            Bastion.Location = new Point(Breite2, Zeile1);
            Bastion.Click += Bastion_Click;

            //Brigitte
            Controls.Add(Brigitte);
            Brigitte.Location = new Point(Breite3, Zeile1);
            Brigitte.Click += Brigitte_Click;

            //D.Va
            Controls.Add(DVa);
            DVa.Location = new Point(Breite4, Zeile1);
            DVa.Click += DVa_Click;

            //Doomfist
            Controls.Add(Doomfist);
            Doomfist.Location = new Point(Breite5, Zeile1);
            Doomfist.Click += Doomfist_Click;

            //Genji
            Controls.Add(Genji);
            Genji.Location = new Point(Breite6, Zeile1);
            Genji.Click += Genji_Click;

            //Hanzo
            Controls.Add(Hanzo);
            Hanzo.Location = new Point(Breite7, Zeile1);
            Hanzo.Click += Hanzo_Click;

            //Junkrat
            Controls.Add(Junkrat);
            Junkrat.Location = new Point(Breite8, Zeile1);
            Junkrat.Click += Junkrat_Click;

            //Lúcio
            Controls.Add(Lúcio);
            Lúcio.Location = new Point(Breite9, Zeile1);
            Lúcio.Click += Lúcio_Click;

            //McCree
            Controls.Add(McCree);
            McCree.Location = new Point(Breite10, Zeile1);
            McCree.Click += McCree_Click;

            ////////---------------

            //Mei
            Controls.Add(Mei);
            Mei.Location = new Point(Breite1, Zeile2);
            Mei.Click += Mei_Click;

            //Mercy
            Controls.Add(Mercy);
            Mercy.Location = new Point(Breite2, Zeile2);
            Mercy.Click += Mercy_Click;

            //Moira
            Controls.Add(Moira);
            Moira.Location = new Point(Breite3, Zeile2);
            Moira.Click += Moira_Click;

            //Orisa
            Controls.Add(Orisa);
            Orisa.Location = new Point(Breite4, Zeile2);
            Orisa.Click += Orisa_Click;

            //Pharah
            Controls.Add(Pharah);
            Pharah.Location = new Point(Breite5, Zeile2);
            Pharah.Click += Pharah_Click;

            //Reaper
            Controls.Add(Reaper);
            Reaper.Location = new Point(Breite6, Zeile2);
            Reaper.Click += Reaper_Click;

            //Reinhardt
            Controls.Add(Reinhardt);
            Reinhardt.Location = new Point(Breite7, Zeile2);
            Reinhardt.Click += Reinhardt_Click;

            //Roadhog
            Controls.Add(Roadhog);
            Roadhog.Location = new Point(Breite8, Zeile2);
            Roadhog.Click += Roadhog_Click;

            //Soldier_76
            Controls.Add(Soldier_76);
            Soldier_76.Location = new Point(Breite9, Zeile2);
            Soldier_76.Click += Soldier_76_Click;

            //Sombra
            Controls.Add(Sombra);
            Sombra.Location = new Point(Breite10, Zeile2);
            Sombra.Click += Sombra_Click;

            ////////---------------

            int Extrabreite = 0;//0 oder 30 (für ungrade)

            //Symmetra
            Controls.Add(Symmetra);
            Symmetra.Location = new Point(Breite2 + Extrabreite, Zeile3);
            Symmetra.Click += Symmetra_Click;

            //Torbjörn
            Controls.Add(Torbjörn);
            Torbjörn.Location = new Point(Breite3 + Extrabreite, Zeile3);
            Torbjörn.Click += Torbjörn_Click;

            //Tracer
            Controls.Add(Tracer);
            Tracer.Location = new Point(Breite4 + Extrabreite, Zeile3);
            Tracer.Click += Tracer_Click;

            //Widowmaker
            Controls.Add(Widowmaker);
            Widowmaker.Location = new Point(Breite5 + Extrabreite, Zeile3);
            Widowmaker.Click += Widowmaker_Click;

            //Winston
            Controls.Add(Winston);
            Winston.Location = new Point(Breite6 + Extrabreite, Zeile3);
            Winston.Click += Winston_Click;

            //Wrecking Ball
            Controls.Add(WreckingBall);
            WreckingBall.Location = new Point(Breite7 + Extrabreite, Zeile3);
            WreckingBall.Click += WreckingBall_Click;

            //Zarya
            Controls.Add(Zarya);
            Zarya.Location = new Point(Breite8 + Extrabreite, Zeile3);
            Zarya.Click += Zarya_Click;

            //Zenyatta
            Controls.Add(Zenyatta);
            Zenyatta.Location = new Point(Breite9 + Extrabreite, Zeile3);
            Zenyatta.Click += Zenyatta_Click;
            #endregion
            ////////---------------

            //CHeroImage MenuImage = new CHeroImage(Language);
            //Controls.Add(MenuImage);
            //MenuImage.SetImage = Image.FromFile("Images\\MenuBackground\\Winter 16.png");

            //Image for Items (Skin, etc.)
            Controls.Add(ItemImage);
            ItemImage.Location = new Point((this.Width / 2) - (ItemImage.Width / 2), (this.Height / 2) - (ItemImage.Height / 2) - 19);
            ItemImage.Visible = false;
            ItemImage.Click += ItemImage_Click;
        }

        private void ItemImage_Click(object sender, EventArgs e)
        {
            ItemImage.Visible = false;
            lblCloseImage.Visible = false;
            ImageChangeHintergrundButtons(true);
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
            Moira.ChangeLang = Language;
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
            WreckingBall.ChangeLang = Language;
            Zarya.ChangeLang = Language;
            Zenyatta.ChangeLang = Language;

            ItemImage.ChangeLang = Language;

            if (NoChangeText==false)
            {
                Texte();
            }
        }

        private void Tooltips()
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip tt = new ToolTip();

            // Set up the delays for the ToolTip.
            tt.AutoPopDelay = 10000;
            tt.InitialDelay = 100;
            tt.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            tt.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            //tt.SetToolTip(this.btnLangGerman, "Currently disabled!");

            #region HeroesToolTips
            tt.SetToolTip(this.Ana, Ana.GetName());
            tt.SetToolTip(this.Bastion, Bastion.GetName());
            tt.SetToolTip(this.Brigitte, Brigitte.GetName());
            tt.SetToolTip(this.DVa, DVa.GetName());
            tt.SetToolTip(this.Doomfist, Doomfist.GetName());
            tt.SetToolTip(this.Genji, Genji.GetName());
            tt.SetToolTip(this.Hanzo, Hanzo.GetName());
            tt.SetToolTip(this.Junkrat, Junkrat.GetName());
            tt.SetToolTip(this.Lúcio, Lúcio.GetName());
            tt.SetToolTip(this.McCree, McCree.GetName());
            tt.SetToolTip(this.Mei, Mei.GetName());
            //
            tt.SetToolTip(this.Mercy, Mercy.GetName());
            tt.SetToolTip(this.Moira, Moira.GetName());
            tt.SetToolTip(this.Orisa, Orisa.GetName());
            tt.SetToolTip(this.Pharah, Pharah.GetName());
            tt.SetToolTip(this.Reaper, Reaper.GetName());
            tt.SetToolTip(this.Reinhardt, Reinhardt.GetName());
            tt.SetToolTip(this.Roadhog, Roadhog.GetName());
            tt.SetToolTip(this.Soldier_76, Soldier_76.GetName());
            tt.SetToolTip(this.Sombra, Sombra.GetName());
            tt.SetToolTip(this.Symmetra, Symmetra.GetName());
            //
            tt.SetToolTip(this.Torbjörn, Torbjörn.GetName());
            tt.SetToolTip(this.Tracer, Tracer.GetName());
            tt.SetToolTip(this.Widowmaker, Widowmaker.GetName());
            tt.SetToolTip(this.Winston, Winston.GetName());
            tt.SetToolTip(this.WreckingBall, WreckingBall.GetName());
            tt.SetToolTip(this.Zarya, Zarya.GetName());
            tt.SetToolTip(this.Zenyatta, Zenyatta.GetName());
            #endregion
        }

        #region Settingsbuttons
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

        private void btnGbLangBlue_Click(object sender, EventArgs e)
        {
            sBackColor = "Blue";
            this.BackColor = Color.DodgerBlue;
            IniSave();
        }

        private void btnGbLangWhite_Click(object sender, EventArgs e)
        {
            sBackColor = "White";
            this.BackColor = Color.White;
            IniSave();
        }

        private void btnGbLangGray_Click(object sender, EventArgs e)
        {
            sBackColor = "Gray";
            this.BackColor = Color.DimGray;
            IniSave();
        }
        #endregion

        /*
        // Ab hier beginnt der richtige Code
        */

        private void btnSettings_Click(object sender, EventArgs e)
        {
            gBLang.Visible = !gBLang.Visible;
            gBLang.BringToFront();

            if (gBLang.Visible)
                btnSettings.Text = Lang.Close;
            else
                btnSettings.Text = Lang.Settings;
        }

        private void btnSkins_Click(object sender, EventArgs e)
        {
            BackSave2 = Lang.Skins;
            BtnSichtbar();

            gbAll.Text += " / " + BackSave2;
        }

        private void btnEmotes_Click(object sender, EventArgs e)
        {
            BackSave2 = Lang.Emotes;
            BtnSichtbar();

            gbAll.Text += " / " + BackSave2;
        }

        private void btnVictoryPoses_Click(object sender, EventArgs e)
        {
            BackSave2 = Lang.VictoryPoses;
            BtnSichtbar();

            gbAll.Text += " / " + BackSave2;
        }

        private void btnVoiceLines_Click(object sender, EventArgs e)
        {
            BackSave2 = Lang.VoiceLines;
            BtnSichtbar();

            gbAll.Text += " / " + BackSave2;
        }

        private void btnSprays_Click(object sender, EventArgs e)
        {
            BackSave2 = Lang.Sprays;
            BtnSichtbar();

            gbAll.Text += " / " + BackSave2;
        }

        private void btnHighlightIntros_Click(object sender, EventArgs e)
        {
            BackSave2 = Lang.HighlightIntros;
            BtnSichtbar();

            gbAll.Text += " / " + BackSave2;
        }

        private void btnOWLeague_Click(object sender, EventArgs e)
        {
            BackSave2 = Lang.OWLeague;
            BtnSichtbar();

            gbAll.Text += " / " + BackSave2;
        }

        private void BtnSichtbar()
        {
            btnSkins.Visible = false;
            btnEmotes.Visible = false;
            btnVictoryPoses.Visible = false;
            btnVoiceLines.Visible = false;
            btnSprays.Visible = false;
            btnHighlightIntros.Visible = false;
            btnOWLeague.Visible = false;

            #region btnsichtbarhelden
            //
            if (Heroe == "Ana")
                btnAna();
            if (Heroe == "Bastion")
                btnBastion();
            if (Heroe == "Brigitte")
                btnBrigitte();
            if (Heroe == "D.Va")
                btnDVa();
            if (Heroe == "Doomfist")
                btnDoomfist();
            if (Heroe == "Genji")
                btnGenji();
            if (Heroe == "Hanzo")
                btnHanzo();
            if (Heroe == "Junkrat")
                btnJunkrat();
            if (Heroe == "Lúcio")
                btnLúcio();
            if (Heroe == "McCree")
                btnMcCree();
            //
            if (Heroe == "Mei")
                btnMei();
            if (Heroe == "Mercy")
                btnMercy();
            if (Heroe == "Moira")
                btnMoira();
            if (Heroe == "Orisa")
                btnOrisa();
            if (Heroe == "Pharah")
                btnPharah();
            if (Heroe == "Reaper")
                btnReaper();
            if (Heroe == "Reinhardt")
                btnReinhardt();
            if (Heroe == "Roadhog")
                btnRoadhog();
            if (Heroe == "Soldier 76")
                btnSoldier_76();
            if (Heroe == "Sombra")
                btnSombra();
            //
            if (Heroe == "Symmetra")
                btnSymmetra();
            if (Heroe == "Torbjörn")
                btnTorbjörn();
            if (Heroe == "Tracer")
                btnTracer();
            if (Heroe == "Widowmaker")
                btnWidowmaker();
            if (Heroe == "Winston")
                btnWinston();
            if (Heroe == "WreckingBall")
                btnWreckingBall();
            if (Heroe == "Zarya")
                btnZarya();
            if (Heroe == "Zenyatta")
                btnZenyatta();
            #endregion
        }

        private void btnPlayerIcons_Click(object sender, EventArgs e)
        {/*
            BackSave2 = Lang.OWLeague;
            gBLang.Visible = false;
            btnMoreCost.Visible = false;

            BtnSichtbar();
            //Command for non PI

            gbAll.Text += " / " + BackSave2;
        */
        }

        private void btnMoreCost_Click(object sender, EventArgs e)
        {
            if (btnMoreCost.Text == Lang.Close)
            {
                gBMoreCost.Visible = false;
                btnMoreCost.Text = Lang.MoreCost;
                btnBackHero.Visible = false;
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

        int i_timer = 3;
        private void tmrWelcome_Tick(object sender, EventArgs e)
        {
            if (i_timer == 1)
            {
                i_timer--;
                btnWelcomeClose.Text = Lang.Close;
                btnWelcomeClose.Enabled = true;
                tmrWelcome.Enabled = false;
            }
            if (i_timer == 2)
            {
                i_timer--;
                btnWelcomeClose.Text = Lang.Close + " (" + i_timer + ")";
            }
            if (i_timer >= 3)
            {
                i_timer--;
                btnWelcomeClose.Text = Lang.Close + " (" + i_timer + ")";
            }
        }

        private void btnWelcomeClose_Click(object sender, EventArgs e)
        {
            gBWelcome.Visible = false;
            btnMoreCost.Visible = true;//Da der Button sonst sichtbar und klickbar ist :/
        }

        //Für hier benötigte Variablen
        int chBSave; string Heroe = "All"; ToolTip HeroTT;

        private void btnBackHeroe_Click(object sender, EventArgs e)
        {
            if (gbAll.Text == BackSave)
            {
                Ana.Visible = true;
                Bastion.Visible = true;
                Brigitte.Visible = true;
                DVa.Visible = true;
                Doomfist.Visible = true;
                Genji.Visible = true;
                Hanzo.Visible = true;
                Junkrat.Visible = true;
                Lúcio.Visible = true;
                McCree.Visible = true;
                Mei.Visible = true;
                Mercy.Visible = true;
                Moira.Visible = true;
                Orisa.Visible = true;
                Pharah.Visible = true;
                Reaper.Visible = true;
                Reinhardt.Visible = true;
                Roadhog.Visible = true;
                Soldier_76.Visible = true;
                Sombra.Visible = true;
                Symmetra.Visible = true;
                Torbjörn.Visible = true;
                Tracer.Visible = true;
                Widowmaker.Visible = true;
                Winston.Visible = true;
                WreckingBall.Visible = true;
                Zarya.Visible = true;
                Zenyatta.Visible = true;

                gbAll.Visible = false;
                btnBackHero.Visible = false;
                btnMoreCost.Visible = true;

                btnSettings.Text = Lang.Settings;
            }
            else if (gbAll.Text == BackSave + " / " + BackSave2)
            {
                btnSkins.Visible = true;
                btnEmotes.Visible = true;
                btnVictoryPoses.Visible = true;
                //btnSprays.Visible = true;
                //btnHighlightIntros.Visible = true;
                btnOWLeague.Visible = true;

                gbAll.Text = BackSave;

                //Rest Ausblenden
                //Erst sagen, dass die Checkboxen nicht speichern sollen
                chBSave = 0;
                //Resetten aller Checkboxen und Ausblenden
                #region Button zurücksetzten 
                chB00.Visible = false; chB00.BackColor = Color.Transparent; chB00.Enabled = false;
                chB01.Checked = false; /*chB01.Visible = false;*/ chB01.BackColor = Color.Transparent;
                chB02.Checked = false; chB02.Visible = false; chB02.BackColor = Color.Transparent;
                chB03.Checked = false; chB03.Visible = false; chB03.BackColor = Color.Transparent;
                chB04.Checked = false; chB04.Visible = false; chB04.BackColor = Color.Transparent;
                chB05.Checked = false; chB05.Visible = false; chB05.BackColor = Color.Transparent;
                chB06.Checked = false; chB06.Visible = false; chB06.BackColor = Color.Transparent;
                chB07.Checked = false; chB07.Visible = false; chB07.BackColor = Color.Transparent;
                chB08.Checked = false; chB08.Visible = false; chB08.BackColor = Color.Transparent;
                chB09.Checked = false; chB09.Visible = false; chB09.BackColor = Color.Transparent;
                chB10.Checked = false; chB10.Visible = false; chB10.BackColor = Color.Transparent;
                chB11.Checked = false; chB11.Visible = false; chB11.BackColor = Color.Transparent;
                chB12.Checked = false; chB12.Visible = false; chB12.BackColor = Color.Transparent;
                chB13.Checked = false; chB13.Visible = false; chB13.BackColor = Color.Transparent;
                chB14.Checked = false; chB14.Visible = false; chB14.BackColor = Color.Transparent;
                chB15.Checked = false; chB15.Visible = false; chB15.BackColor = Color.Transparent;
                chB16.Checked = false; chB16.Visible = false; chB16.BackColor = Color.Transparent;
                chB17.Checked = false; chB17.Visible = false; chB17.BackColor = Color.Transparent;
                chB18.Checked = false; chB18.Visible = false; chB18.BackColor = Color.Transparent;
                chB19.Checked = false; chB19.Visible = false; chB19.BackColor = Color.Transparent;
                chB20.Checked = false; chB20.Visible = false; chB20.BackColor = Color.Transparent;

                chB21.Checked = false; chB21.Visible = false; chB21.BackColor = Color.Transparent;
                chB22.Checked = false; chB22.Visible = false; chB22.BackColor = Color.Transparent;
                chB23.Checked = false; chB23.Visible = false; chB23.BackColor = Color.Transparent;
                chB24.Checked = false; chB24.Visible = false; chB24.BackColor = Color.Transparent;
                chB25.Checked = false; chB25.Visible = false; chB25.BackColor = Color.Transparent;
                chB26.Checked = false; chB26.Visible = false; chB26.BackColor = Color.Transparent;
                chB27.Checked = false; chB27.Visible = false; chB27.BackColor = Color.Transparent;
                chB28.Checked = false; chB28.Visible = false; chB28.BackColor = Color.Transparent;
                chB29.Checked = false; chB29.Visible = false; chB29.BackColor = Color.Transparent;
                chB30.Checked = false; chB30.Visible = false; chB30.BackColor = Color.Transparent;
                chB31.Checked = false; chB31.Visible = false; chB31.BackColor = Color.Transparent;
                chB32.Checked = false; chB32.Visible = false; chB32.BackColor = Color.Transparent;
                chB33.Checked = false; chB33.Visible = false; chB33.BackColor = Color.Transparent;
                chB34.Checked = false; chB34.Visible = false; chB34.BackColor = Color.Transparent;
                chB35.Checked = false; chB35.Visible = false; chB35.BackColor = Color.Transparent;
                chB36.Checked = false; chB36.Visible = false; chB36.BackColor = Color.Transparent;
                chB37.Checked = false; chB37.Visible = false; chB37.BackColor = Color.Transparent;
                chB38.Checked = false; chB38.Visible = false; chB38.BackColor = Color.Transparent;
                chB39.Checked = false; chB39.Visible = false; chB39.BackColor = Color.Transparent;

                btn00.Visible = false; btn00.Width = 75;
                btn01.Visible = false; btn01.Width = 75;
                btn02.Visible = false; btn02.Width = 75;
                btn03.Visible = false; btn03.Width = 75;
                btn04.Visible = false; btn04.Width = 75;
                btn05.Visible = false; btn05.Width = 75;
                btn06.Visible = false; btn06.Width = 75;
                btn07.Visible = false; btn07.Width = 75;
                btn08.Visible = false; btn08.Width = 75;
                btn09.Visible = false; btn09.Width = 75;
                btn10.Visible = false; btn10.Width = 75;
                btn11.Visible = false; btn11.Width = 75;
                btn12.Visible = false; btn12.Width = 75;
                btn13.Visible = false; btn13.Width = 75;
                btn14.Visible = false; btn14.Width = 75;
                btn15.Visible = false; btn15.Width = 75;
                btn16.Visible = false; btn16.Width = 75;
                btn17.Visible = false; btn17.Width = 75;
                btn18.Visible = false; btn18.Width = 75;
                btn19.Visible = false; btn19.Width = 75;
                btn20.Visible = false; btn20.Width = 75;
                btn21.Visible = false; btn21.Width = 75;
                btn22.Visible = false; btn22.Width = 75;
                #endregion

                HeroTT.RemoveAll();

                chB01.Text = Lang.GoldWeapon;
                chB01.Location = new Point(gBAllWeited4p1, p2);
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.GoldWeapon));

                //Nun sagen, dass die Checkboxen speichern sollen
                chBSave = 1;
            }
        }

        private void btnHeroeinvisible(string H, int SK, int EM, int VP/*, VL*/)
        {
            IniSave();

            if (inisSettings.Read(H) == "1")
            {

            }
            else
            {
                inic.Create(H);
                inisSettings.Write(H, "1");
            }

            #region Old
            //if (inisSettings.Read(H) == "Y")
            //{
            //    inisSettings.Write(H, "1");
            //}
            //if (inisSettings.Read(H) != "1" && inisSettings.Read(H) != "2" && inisSettings.Read(H) != "3" && inisSettings.Read(H) != "4" && inisSettings.Read(H) != "5" && inisSettings.Read(H) != "6" && inisSettings.Read(H) != "7" && inisSettings.Read(H) != "8" && inisSettings.Read(H) != "9" && inisSettings.Read(H) != "10" && inisSettings.Read(H) != "11" && inisSettings.Read(H) != "12" && inisSettings.Read(H) != "13" && inisSettings.Read(H) != "14" && inisSettings.Read(H) != "15" && inisSettings.Read(H) != "16" && inisSettings.Read(H) != "17")
            //{//Bis 17
            //    inic.Heroe(H, SK, EM);
            //    inisSettings.Write(H, "1");
            //}
            //if (inisSettings.Read(H) == "1")
            //{
            //    inic.VP(H, VP);
            //    inisSettings.Write(H, "2");
            //}
            //if (inisSettings.Read(H) == "2")
            //{
            //    inic.create3(H);
            //    inisSettings.Write(H, "3");
            //}
            //if (inisSettings.Read(H) == "3")
            //{
            //    inic.create4(H);
            //    inisSettings.Write(H, "4");
            //}
            //if (inisSettings.Read(H) == "4")
            //{
            //    inic.create5(H);
            //    inisSettings.Write(H, "5");
            //}
            //if (inisSettings.Read(H) == "5")
            //{
            //    inic.create6(H);
            //    inisSettings.Write(H, "6");
            //}
            //if (inisSettings.Read(H) == "6")
            //{
            //    inic.create7(H);
            //    inisSettings.Write(H, "7");
            //}
            //if (inisSettings.Read(H) == "7")
            //{
            //    inic.create8(H);
            //    inisSettings.Write(H, "8");
            //}
            //if (inisSettings.Read(H) == "8")
            //{
            //    inic.create9(H);
            //    inisSettings.Write(H, "9");
            //}
            //if (inisSettings.Read(H) == "9")
            //{
            //    inic.create10(H);
            //    inisSettings.Write(H, "10");
            //}
            //if (inisSettings.Read(H) == "10")
            //{//Adding Wrecking Ball + Summer
            //    inic.create10(H);
            //    inisSettings.Write(H, "11");
            //}
            #endregion

            gBLang.Visible = false;
            btnMoreCost.Visible = false;
            btnBackHero.Visible = true;

            #region Heroes
            Ana.Visible = false;
            Bastion.Visible = false;
            Brigitte.Visible = false;
            DVa.Visible = false;
            Doomfist.Visible = false;
            Genji.Visible = false;
            Hanzo.Visible = false;
            Junkrat.Visible = false;
            Lúcio.Visible = false;
            McCree.Visible = false;
            Mei.Visible = false;
            Mercy.Visible = false;
            Moira.Visible = false;
            Orisa.Visible = false;
            Pharah.Visible = false;
            Reaper.Visible = false;
            Reinhardt.Visible = false;
            Roadhog.Visible = false;
            Soldier_76.Visible = false;
            Sombra.Visible = false;
            Symmetra.Visible = false;
            Torbjörn.Visible = false;
            Tracer.Visible = false;
            Widowmaker.Visible = false;
            Winston.Visible = false;
            WreckingBall.Visible = false;
            Zarya.Visible = false;
            Zenyatta.Visible = false;
            #endregion

            gbAll.Visible = true;
            BackSave = gbAll.Text;
            chBSave = 1;

            //Create of Tooltips (if needed)
            HeroTT = new ToolTip();

            // Set up the delays for the ToolTip.
            HeroTT.AutoPopDelay = 10000;
            HeroTT.InitialDelay = 100;
        }


        #region Heroes

        private void Ana_Click(object sender, EventArgs e)
        {
            Heroe = "Ana";
            btnHeroeinvisible(Heroe, 13, 8, 6);
            gbAll.Text = Ana.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GoldWeapon"));
            chBSave = 1;
        }

        private void btnAna()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = Cost.Classic.ToString();
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = Ana.Citrine_SK[1]; HeroTT.SetToolTip(chB01, Ana.Citrine_SK[2]);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = Ana.Garnet_SK[1]; HeroTT.SetToolTip(chB02, Ana.Garnet_SK[2]);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = Ana.Peridot_SK[1]; HeroTT.SetToolTip(chB03, Ana.Peridot_SK[2]);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = Ana.Turquoise_SK[1]; HeroTT.SetToolTip(chB04, Ana.Turquoise_SK[2]);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = Ana.Merciful_SK[1]; HeroTT.SetToolTip(chB05, Ana.Merciful_SK[2]);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = Ana.Shrike_SK[1]; HeroTT.SetToolTip(chB06, Ana.Shrike_SK[2]);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = Ana.Ghoul_SK[1]; HeroTT.SetToolTip(chB07, Ana.Ghoul_SK[2]);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4); chB08.Text = Ana.Tal_SK[1]; HeroTT.SetToolTip(chB08, Ana.Tal_SK[2]);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1); chB09.Text = Ana.Wadjet_SK[1]; HeroTT.SetToolTip(chB09, Ana.Wadjet_SK[2]);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2); chB10.Text = Ana.Wasteland_SK[1]; HeroTT.SetToolTip(chB10, Ana.Wasteland_SK[2]);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3); chB11.Text = Ana.Captain_Amari_SK[1]; HeroTT.SetToolTip(chB11, Ana.Captain_Amari_SK[2]);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4); chB12.Text = Ana.Horus_SK[1]; HeroTT.SetToolTip(chB12, Ana.Horus_SK[2]);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p5); chB13.Text = Ana.Corsair_SK[1]; HeroTT.SetToolTip(chB13, Ana.Corsair_SK[2]);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p6); chB14.Text = Ana.Snow_Owl_SK[1]; HeroTT.SetToolTip(chB14, Ana.Snow_Owl_SK[2]);

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p2 + chB08.Width, p4 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p1 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p2 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p3 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p4 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p5 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p6 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Ana.Citrine_SK[0];//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Ana.Garnet_SK[0];
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Ana.Peridot_SK[0];
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Ana.Turquoise_SK[0];
                btn05.BackColor = Color.DarkViolet; btn05.Text = Ana.Merciful_SK[0];//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Ana.Shrike_SK[0];
                btn07.BackColor = Color.DarkViolet; btn07.Text = Ana.Ghoul_SK[0];//Halloween 16
                btn08.BackColor = Color.DarkViolet; btn08.Text = Ana.Tal_SK[0];//Rooster 17
                btn09.BackColor = Color.Gold; btn09.Text = Ana.Wadjet_SK[0];//Legendary
                btn10.BackColor = Color.Gold; btn10.Text = Ana.Wasteland_SK[0];
                btn11.BackColor = Color.Gold; btn11.Text = Ana.Captain_Amari_SK[0];
                btn12.BackColor = Color.Gold; btn12.Text = Ana.Horus_SK[0];
                btn13.BackColor = Color.Gold; btn13.Text = Ana.Corsair_SK[0];//Halloween 17
                btn14.BackColor = Color.Gold; btn14.Text = Ana.Snow_Owl_SK[0];//Winter 17

                if (Language != "EN")
                {
                    NoChangeText = true;
                    LangBrücke = Language;
                    Language = "EN";
                    ChangeLang();
                }
                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Citrine_SK[0]));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Garnet_SK[0]));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Peridot_SK[0]));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Turquoise_SK[0]));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Merciful_SK[0]));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Shrike_SK[0]));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Ghoul_SK[0]));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Tal_SK[0]));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Wadjet_SK[0]));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Wasteland_SK[0]));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Captain_Amari_SK[0]));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Horus_SK[0]));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Corsair_SK[0]));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Snow_Owl_SK[0]));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = Cost.Classic.ToString();
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = Ana.Not_Impressed_EM[1]; HeroTT.SetToolTip(chB01, Ana.Not_Impressed_EM[2]);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = Ana.Disapproving_EM[1]; HeroTT.SetToolTip(chB02, Ana.Disapproving_EM[2]);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = Ana.Protector_EM[1]; HeroTT.SetToolTip(chB03, Ana.Protector_EM[2]);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p1, p5); chB04.Text = Ana.Take_A_Knee_EM[1]; HeroTT.SetToolTip(chB04, Ana.Take_A_Knee_EM[2]);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p1); chB05.Text = Ana.Tea_Time_EM[1]; HeroTT.SetToolTip(chB05, Ana.Tea_Time_EM[2]);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p2); chB06.Text = Ana.Beach_Ball_EM[1]; HeroTT.SetToolTip(chB06, Ana.Beach_Ball_EM[2]);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = Ana.Candy_EM[1]; HeroTT.SetToolTip(chB07, Ana.Candy_EM[2]);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited3p2, p4); chB08.Text = Ana.Dance_EM[1]; HeroTT.SetToolTip(chB08, Ana.Dance_EM[2]);

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited3p2 + chB08.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//DEfault
                btn01.BackColor = Color.DarkViolet; btn01.Text = Ana.Not_Impressed_EM[0];//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Ana.Disapproving_EM[0];
                btn03.BackColor = Color.DarkViolet; btn03.Text = Ana.Protector_EM[0];
                btn04.BackColor = Color.DarkViolet; btn04.Text = Ana.Take_A_Knee_EM[0];
                btn05.BackColor = Color.DarkViolet; btn05.Text = Ana.Tea_Time_EM[0];
                btn06.BackColor = Color.DarkViolet; btn06.Text = Ana.Beach_Ball_EM[0];//Summer 17
                btn07.BackColor = Color.DarkViolet; btn07.Text = Ana.Candy_EM[0];//Halloween 16
                btn08.BackColor = Color.DarkViolet; btn08.Text = Ana.Dance_EM[0];//Annyver 17

                chB01.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Not_Impressed_EM[0]));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Disapproving_EM[0]));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Protector_EM[0]));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Take_A_Knee_EM[0]));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Tea_Time_EM[0]));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Beach_Ball_EM[0]));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Candy_EM[0]));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Dance_EM[0]));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = Cost.Classic.ToString();
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = Ana.Mission_Complete_VP[1]; HeroTT.SetToolTip(chB01, Ana.Mission_Complete_VP[2]);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = Ana.Protector_VP[1]; HeroTT.SetToolTip(chB02, Ana.Protector_VP[2]);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = Ana.Seated_VP[1]; HeroTT.SetToolTip(chB03, Ana.Seated_VP[2]);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = Ana.RIP_VP[1]; HeroTT.SetToolTip(chB04, Ana.RIP_VP[2]);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = Ana.Toast_VP[1]; HeroTT.SetToolTip(chB05, Ana.Toast_VP[2]);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = Ana.Folded_Hands_VP[1]; HeroTT.SetToolTip(chB06, Ana.Folded_Hands_VP[2]);

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Ana.Mission_Complete_VP[0];//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Ana.Protector_VP[0];
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Ana.Seated_VP[0];
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Ana.RIP_VP[0];//Halloween 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Ana.Toast_VP[0];//Winter 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Ana.Folded_Hands_VP[0];//Rooster 17

                chB01.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Mission_Complete_VP[0]));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Protector_VP[0]));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Seated_VP[0]));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.RIP_VP[0]));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Toast_VP[0]));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Folded_Hands_VP[0]));
            }
            #region Unimplemented
            if (BackSave2 == Lang.VoiceLines)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = Ana.Justice_Delivered_VL[1];
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = Ana.Children_behave_VL[1]; HeroTT.SetToolTip(chB01, Ana.Children_behave_VL[2]);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = Ana.Everyone_dies_VL[1]; HeroTT.SetToolTip(chB02, Ana.Everyone_dies_VL[2]);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = Ana.Go_on_i_can_wait_VL[1]; HeroTT.SetToolTip(chB03, Ana.Go_on_i_can_wait_VL[2]);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = Ana.It_takes_a_woman_to_know_VL[1]; HeroTT.SetToolTip(chB04, Ana.It_takes_a_woman_to_know_VL[2]);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p1, p6); chB05.Text = Ana.Justice_rains_from_above_VL[1]; HeroTT.SetToolTip(chB05, Ana.Justice_rains_from_above_VL[2]);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p1, p7); chB06.Text = Ana.Mother_knows_best_VL[1]; HeroTT.SetToolTip(chB06, Ana.Mother_knows_best_VL[2]);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p1, p8); chB07.Text = Ana.No_scope_needed_VL[1]; HeroTT.SetToolTip(chB07, Ana.No_scope_needed_VL[2]);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p1, p1); chB08.Text = Ana.What_are_you_thinking_VL[1]; HeroTT.SetToolTip(chB08, Ana.What_are_you_thinking_VL[2]);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p2, p2); chB09.Text = Ana.Witness_me_VL[1]; HeroTT.SetToolTip(chB09, Ana.Witness_me_VL[2]);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p2, p3); chB10.Text = Ana.You_know_nothing_VL[1]; HeroTT.SetToolTip(chB10, Ana.You_know_nothing_VL[2]);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p2, p4); chB11.Text = Ana.Someone_to_tuck_you_in_VL[1]; HeroTT.SetToolTip(chB11, Ana.Someone_to_tuck_you_in_VL[2]);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p2, p5); chB12.Text = Ana.Better_than_retirement_VL[1]; HeroTT.SetToolTip(chB12, Ana.Better_than_retirement_VL[2]);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p2, p6); chB13.Text = Ana.Learn_from_the_pain_VL[1]; HeroTT.SetToolTip(chB13, Ana.Learn_from_the_pain_VL[2]);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p2, p7); chB14.Text = Ana.Are_you_scared_VL[1]; HeroTT.SetToolTip(chB14, Ana.Are_you_scared_VL[2]);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p2, p8); chB15.Text = Ana.Dont_be_scared_VL[1]; HeroTT.SetToolTip(chB15, Ana.Dont_be_scared_VL[2]);
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p1); chB16.Text = Ana.Im_too_old_for_surprises_VL[1]; HeroTT.SetToolTip(chB16, Ana.Im_too_old_for_surprises_VL[2]);
                chB17.Visible = true; chB17.Location = new Point(gBAllWeited4p3, p2); chB17.Text = Ana.Im_watching_out_for_you_VL[1]; HeroTT.SetToolTip(chB17, Ana.Im_watching_out_for_you_VL[2]);
                chB18.Visible = true; chB18.Location = new Point(gBAllWeited4p3, p3); chB18.Text = Ana.The_Moon_in_Winter_VL[1]; HeroTT.SetToolTip(chB18, Ana.The_Moon_in_Winter_VL[2]);
                chB19.Visible = true; chB19.Location = new Point(gBAllWeited4p3, p4); chB19.Text = Ana.Damn_VL[1]; HeroTT.SetToolTip(chB19, Ana.Damn_VL[2]);
                chB20.Visible = true; chB20.Location = new Point(gBAllWeited4p3, p5); chB20.Text = Ana.The_Ghost_watches_VL[1]; HeroTT.SetToolTip(chB20, Ana.The_Ghost_watches_VL[2]);
                chB21.Visible = true; chB21.Location = new Point(gBAllWeited4p3, p6); chB21.Text = Ana.Follow_me_VL[1]; HeroTT.SetToolTip(chB21, Ana.Follow_me_VL[2]);
                chB22.Visible = true; chB22.Location = new Point(gBAllWeited4p3, p7); chB22.Text = Ana.The_adults_are_talking_VL[1]; HeroTT.SetToolTip(chB22, Ana.The_adults_are_talking_VL[2]);
                #region t
                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p1 + chB05.Width, p6 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p1 + chB06.Width, p7 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p1 + chB07.Width, p8 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p2 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p2 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p2 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p2 + chB11.Width, p4 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p2 + chB12.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p2 + chB13.Width, p6 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p2 + chB14.Width, p7 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p2 + chB14.Width, p8 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB14.Width, p1 - 5);
                btn17.Visible = true; btn17.Location = new Point(gBAllWeited4p3 + chB14.Width, p2 - 5);
                btn18.Visible = true; btn18.Location = new Point(gBAllWeited4p3 + chB14.Width, p3 - 5);
                btn19.Visible = true; btn19.Location = new Point(gBAllWeited4p3 + chB14.Width, p4 - 5);
                btn20.Visible = true; btn20.Location = new Point(gBAllWeited4p3 + chB14.Width, p5 - 5);
                btn21.Visible = true; btn21.Location = new Point(gBAllWeited4p3 + chB14.Width, p6 - 5);
                btn22.Visible = true; btn22.Location = new Point(gBAllWeited4p3 + chB14.Width, p7 - 5);
                #endregion
                btn00.BackColor = Color.Gainsboro; btn00.Text = Ana.Justice_Delivered_VL[0];//Default
                btn01.BackColor = Color.Gainsboro; btn01.Text = Ana.Children_behave_VL[0];//Common
                btn02.BackColor = Color.Gainsboro; btn02.Text = Ana.Everyone_dies_VL[0];
                btn03.BackColor = Color.Gainsboro; btn03.Text = Ana.Go_on_i_can_wait_VL[0];
                btn04.BackColor = Color.Gainsboro; btn04.Text = Ana.It_takes_a_woman_to_know_VL[0];
                btn05.BackColor = Color.Gainsboro; btn05.Text = Ana.Justice_rains_from_above_VL[0];
                btn06.BackColor = Color.Gainsboro; btn06.Text = Ana.Mother_knows_best_VL[0];
                btn07.BackColor = Color.Gainsboro; btn07.Text = Ana.No_scope_needed_VL[0];
                btn08.BackColor = Color.Gainsboro; btn08.Text = Ana.What_are_you_thinking_VL[0];
                btn09.BackColor = Color.Gainsboro; btn09.Text = Ana.Witness_me_VL[0];
                btn10.BackColor = Color.Gainsboro; btn10.Text = Ana.You_know_nothing_VL[0];
                btn11.BackColor = Color.Gainsboro; btn11.Text = Ana.Someone_to_tuck_you_in_VL[0];
                btn12.BackColor = Color.Gainsboro; btn12.Text = Ana.Better_than_retirement_VL[0];//Summer 17
                btn13.BackColor = Color.Gainsboro; btn13.Text = Ana.Learn_from_the_pain_VL[0];//Summer 16
                btn14.BackColor = Color.Gainsboro; btn14.Text = Ana.Are_you_scared_VL[0];//Halloween 16
                btn15.BackColor = Color.Gainsboro; btn15.Text = Ana.Dont_be_scared_VL[0];//Halloween 17
                btn16.BackColor = Color.Gainsboro; btn16.Text = Ana.Im_too_old_for_surprises_VL[0];//Winter 17
                btn17.BackColor = Color.Gainsboro; btn17.Text = Ana.Im_watching_out_for_you_VL[0];//Winter 16
                btn18.BackColor = Color.Gainsboro; btn18.Text = Ana.The_Moon_in_Winter_VL[0];//Rooster 17
                btn19.BackColor = Color.Gainsboro; btn19.Text = Ana.Damn_VL[0];//Uprising 17
                btn20.BackColor = Color.Gainsboro; btn20.Text = Ana.The_Ghost_watches_VL[0];//Uprising 17
                btn21.BackColor = Color.Gainsboro; btn21.Text = Ana.Follow_me_VL[0];//Annyver 17
                btn22.BackColor = Color.Gainsboro; btn22.Text = Ana.The_adults_are_talking_VL[0];//Annyver 17

                chB00.Checked = true;/*
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Children_behave_VL[0]));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Everyone_dies_VL[0]));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Go_on_i_can_wait_VL[0]));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.It_takes_a_woman_to_know_VL[0]));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Justice_rains_from_above_VL[0]));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Mother_knows_best_VL[0]));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.No_scope_needed_VL[0]));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.What_are_you_thinking_VL[0]));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Witness_me_VL[0]));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.You_know_nothing_VL[0]));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Someone_to_tuck_you_in_VL[0]));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Better_than_retirement_VL[0]));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Learn_from_the_pain_VL[0]));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Are_you_scared_VL[0]));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Dont_be_scared_VL[0]));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Im_too_old_for_surprises_VL[0]));
                chB17.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Im_watching_out_for_you_VL[0]));
                chB18.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.The_Moon_in_Winter_VL[0]));
                chB19.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Damn_VL[0]));
                chB20.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.The_Ghost_watches_VL[0]));
                chB21.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.Follow_me_VL[0]));
                chB22.Checked = Convert.ToBoolean(inisHeroes.Read(Ana.The_adults_are_talking_VL[0]));*/
            }
            if (BackSave2 == Lang.Sprays)
            {
                chB01.Visible = true; chB01.Text = Ana.Action_SP[0] + " (" + Cost.Common + ")";//Common
                chB02.Visible = true; chB02.Text = Ana.Ana_SP[0] + " (" + Cost.Common + ")";
                chB03.Visible = true; chB03.Text = Ana.Bearer_SP[0] + " (" + Cost.Common + ")";
                chB04.Visible = true; chB04.Text = Ana.Cheer_SP[0] + " (" + Cost.Common + ")";
                chB05.Visible = true; chB05.Text = Ana.Cracked_SP[0] + " (" + Cost.Common + ")";
                chB06.Visible = true; chB06.Text = Ana.Cute_SP[0] + " (" + Cost.Common + ")";
                chB07.Visible = true; chB07.Text = Ana.Eyepatch_SP[0] + " (" + Cost.Common + ")";
                chB08.Visible = true; chB08.Text = Ana.Fareeha_SP[0] + " (" + Cost.Common + ")";
                chB09.Visible = true; chB09.Text = Ana.Gaze_SP[0] + " (" + Cost.Common + ")";
                chB10.Visible = true; chB10.Text = Ana.Grenade_SP[0] + " (" + Cost.Common + ")";
                chB11.Visible = true; chB11.Text = Ana.Guardian_SP[0] + " (" + Cost.Common + ")";
                chB12.Visible = true; chB12.Text = Ana.Hesitation_SP[0] + " (" + Cost.Common + ")";
                chB13.Visible = true; chB13.Text = Ana.Icon_SP[0] + " (" + Cost.Common + ")";
                chB14.Visible = true; chB14.Text = Ana.Letter_SP[0] + " (" + Cost.Common + ")";
                chB15.Visible = true; chB15.Text = Ana.Old_Soldier_SP[0] + " (" + Cost.Common + ")";
                chB16.Visible = true; chB16.Text = Ana.Overhead_SP[0] + " (" + Cost.Common + ")";
                chB17.Visible = true; chB17.Text = Ana.Pillow_SP[0] + " (" + Cost.Common + ")";
                chB18.Visible = true; chB18.Text = Ana.Photograph_SP[0] + " (" + Cost.Common + ")";
                chB19.Visible = true; chB19.Text = Ana.Pixel_SP[0] + " (" + Cost.Common + ")";
                chB20.Visible = true; chB20.Text = Ana.Rifle_SP[0] + " (" + Cost.Common + ")";
                chB21.Visible = true; chB21.Text = Ana.Shadow_SP[0] + " (" + Cost.Common + ")";
                chB22.Visible = true; chB22.Text = Ana.Shhh_SP[0] + " (" + Cost.Common + ")";
                chB23.Visible = true; chB23.Text = Ana.Sidearm_SP[0] + " (" + Cost.Common + ")";
                chB24.Visible = true; chB24.Text = Ana.Wasteland_SP[0] + " (" + Cost.Common + ")";
                chB25.Visible = true; chB25.Text = Ana.Wedjat_SP[0] + " (" + Cost.Common + ")";
                chB26.Visible = true; chB26.Text = Ana.Wrist_Launcher_SP[0] + " (" + Cost.Common + ")";
                chB27.Visible = true; chB27.Text = Ana.Zzz_SP[0] + " (" + Cost.Common + ")";
                chB28.Visible = true; chB28.Text = Ana.Shooting_SP[0] + " (" + Cost.Common + ")";//Summer 16
                chB29.Visible = true; chB29.Text = Ana.Trick_or_Treat_SP[0] + " (" + Cost.Common + ")";//Halloween 16
                chB30.Visible = true; chB30.Text = Ana.Ornament_SP[0] + " (" + Cost.RareEvent + ")";//Winter 16
                chB31.Visible = true; chB31.Text = Ana.Warm_SP[0] + " (" + Cost.RareEvent + ")";//Winter 16
                chB32.Visible = true; chB32.Text = Ana.Dance_SP[0] + " (" + Cost.RareEvent + ")";//Rooster 17
                chB33.Visible = true; chB33.Text = Ana.Dragon_Dance_SP[0] + " (" + Cost.RareEvent + ")";//Rooster 17
                chB34.Visible = true; chB34.Text = Ana.Newborn_SP[0] + " (" + Cost.RareEvent + ")";//Uprising 17
                chB35.Visible = true; chB35.Text = Ana.Ace_of_Hearts_SP[0] + " (" + Cost.RareEvent + ")";//Annyver 17
            }
            if (BackSave2 == Lang.HighlightIntros)
            {
                chB01.Visible = true; chB01.Text = Ana.Guardian_HI[0] + " (" + Cost.Epic + ")";//Epic
                chB02.Visible = true; chB02.Text = Ana.Locked_on_HI[0] + " (" + Cost.Epic + ")";
                chB03.Visible = true; chB03.Text = Ana.Shh_HI[0] + " (" + Cost.Epic + ")";
                chB04.Visible = true; chB04.Text = Ana.Under_Fire_HI[0] + " (" + Cost.Epic + ")";
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
                if (inisHeroes.Read("HI04") == "1")
                {
                    chB04.Checked = true;
                }
            }
            if (BackSave2 == Lang.PlayerIcons)
            {
                chB01.Visible = true; chB01.Text = Ana.Ana_PI[0];//Rare
                chB02.Visible = true; chB02.Text = Ana.Watcher_PI[0];
                chB03.Visible = true; chB03.Text = Ana.Wedjat_PI[0];
                chB04.Visible = true; chB04.Text = Ana.Shooting_PI[0];//Summer 16
                chB04.Visible = true; chB04.Text = Ana.Corsair_PI[0];//Halloween 17
                chB04.Visible = true; chB04.Text = Ana.Anaversary_PI[0];//Annyver 17
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
            #endregion

            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            if (NoChangeText == true)
            {
                Language = LangBrücke;
                ChangeLang();
                NoChangeText = false;
            }
            chBSave = 1;
        }

        private void Bastion_Click(object sender, EventArgs e)
        {
            Heroe = "Bastion";
            btnHeroeinvisible(Heroe, 16, 7, 6);
            gbAll.Text = Bastion.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnBastion()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                Lang.BlizzCon2 = "2016";
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Lang.BlizzCon + ")"; HeroTT.SetToolTip(chB07, Lang.BlizzCon2);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4); chB08.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB08, Lang.Halloween + " 2016");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p2, p5); chB09.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB09, Lang.Rooster + " 2017");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p2, p6); chB10.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB10, Lang.Uprising + " 2017");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p1); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p2); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, "Legendary");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p3); chB13.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB13, "Legendary");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p4); chB14.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB14, "Legendary");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p5); chB15.Text = "(" + Lang.OriginGotY + ")"; HeroTT.SetToolTip(chB15, Lang.OriginGotY2);
                chB17.Visible = true; chB17.Location = new Point(gBAllWeited4p3, p6); chB17.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB17, Lang.Winter + " 2017");
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p7); chB16.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB16, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p2 + chB08.Width, p4 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p2 + chB09.Width, p5 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p2 + chB09.Width, p5 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p2 + chB09.Width, p5 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p2 + chB10.Width, p6 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p1 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p2 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p3 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p4 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p5 - 5);
                btn17.Visible = true; btn17.Location = new Point(gBAllWeited4p3 + chB17.Width, p6 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB16.Width, p7 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Bastion.Dawn_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Bastion.Meadow_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Bastion.Sky_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Bastion.Soot_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Bastion.Defense_Matrix_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Bastion.Omnic_Crisis_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Bastion.BlizzCon_2016_SK;//BlizzCon 16
                btn08.BackColor = Color.DarkViolet; btn08.Text = Bastion.Tombstone_SK;//Halloween 16
                btn09.BackColor = Color.DarkViolet; btn09.Text = Bastion.Rooster_SK;//Rooster 17
                btn10.BackColor = Color.DarkViolet; btn10.Text = Bastion.Null_Sector_SK;//Uprising 17
                btn11.BackColor = Color.Gold; btn11.Text = Bastion.Antique_SK;//Legendary
                btn12.BackColor = Color.Gold; btn12.Text = Bastion.Woodbot_SK;
                btn13.BackColor = Color.Gold; btn13.Text = Bastion.Gearbot_SK;
                btn14.BackColor = Color.Gold; btn14.Text = Bastion.Steambot_SK;
                btn15.BackColor = Color.Gold; btn15.Text = Bastion.Overgrown_SK;//Origin
                btn17.BackColor = Color.Gold; btn17.Text = Bastion.Avalanche_SK;//Winter 17
                btn16.BackColor = Color.Gold; btn16.Text = Bastion.Dune_Buggy_SK;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
                chB17.Checked = Convert.ToBoolean(inisHeroes.Read("SK17"));

            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, Lang.Summer + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Bastion.Alert_Alert_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Bastion.Chortle_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Bastion.Dizzy_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Bastion.Rest_Mode_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Bastion.Robot_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Bastion.Boxing_EM;//Summer 16
                btn07.BackColor = Color.DarkViolet; btn07.Text = Bastion.Robo_Boogie_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = " (" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2017");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = " (" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Winter + " 2017");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p4); chB06.Text = " (" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Rooster + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Bastion.Birdwatching_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Bastion.Pop_up_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Bastion.Tank_EM;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Bastion.Medal_VP;//Summer 17
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Bastion.RIP_VP;//Halloween 16
                btn07.BackColor = Color.DeepSkyBlue; btn07.Text = Bastion.Toast_VP;//Winter 17
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Bastion.Firework_VP;//Rooster 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VP07"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.VoiceLines)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1);
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p1, p6);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p1, p7);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p1, p8);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p1);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p2, p2);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p2, p3);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p2, p4);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p2, p5);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p2, p6);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p2, p7);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p2, p8);
                chB22.Visible = true; chB22.Location = new Point(gBAllWeited4p3, p1);
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p2);
                chB17.Visible = true; chB17.Location = new Point(gBAllWeited4p3, p3);
                chB18.Visible = true; chB18.Location = new Point(gBAllWeited4p3, p4);
                chB19.Visible = true; chB19.Location = new Point(gBAllWeited4p3, p5);
                chB20.Visible = true; chB20.Location = new Point(gBAllWeited4p3, p6);
                chB21.Visible = true; chB21.Location = new Point(gBAllWeited4p3, p7);

                chB00.BackColor = Color.Gainsboro; chB00.Text = Bastion.Doo_Woo_VL;//Default
                chB01.BackColor = Color.Gainsboro; chB01.Text = Bastion.Beeple_VL + " (" + Cost.Common + ")";
                chB02.BackColor = Color.Gainsboro; chB02.Text = Bastion.Boo_Boo_Doo_De_Doo_VL + " (" + Cost.Common + ")";
                chB03.BackColor = Color.Gainsboro; chB03.Text = Bastion.Bweeeeeeeeeee_VL + " (" + Cost.Common + ")";
                chB04.BackColor = Color.Gainsboro; chB04.Text = Bastion.Chirr_Chirr_Chirr_VL + " (" + Cost.Common + ")";
                chB05.BackColor = Color.Gainsboro; chB05.Text = Bastion.Dah_Dah_Weeeee_VL + " (" + Cost.Common + ")";
                chB06.BackColor = Color.Gainsboro; chB06.Text = Bastion.Dun_Dun_Boop_Boop_VL + " (" + Cost.Common + ")";
                chB07.BackColor = Color.Gainsboro; chB07.Text = Bastion.Dweet_Dweet_Dweet_VL + " (" + Cost.Common + ")";
                chB08.BackColor = Color.Gainsboro; chB08.Text = Bastion.Hee_Hoo_Hoo_VL + " (" + Cost.Common + ")";
                chB09.BackColor = Color.Gainsboro; chB09.Text = Bastion.Ooh_ooo_hoo_hoo_VL + " (" + Cost.Common + ")";
                chB10.BackColor = Color.Gainsboro; chB10.Text = Bastion.Sh_Sh_Sh_VL + " (" + Cost.Common + ")";
                chB11.BackColor = Color.Gainsboro; chB11.Text = Bastion.Zwee_VL + " (" + Cost.Common + ")";
                chB12.BackColor = Color.Gainsboro; chB12.Text = Bastion.Doo_Do_Doo_Dee_VL + " (" + Cost.RareEvent + ")";//Summer 17
                chB13.BackColor = Color.Gainsboro; chB13.Text = Bastion.Whoo_Vweeeeee_VL + " (" + Cost.Common + ")";//Summer 16
                chB14.BackColor = Color.Gainsboro; chB14.Text = Bastion.Oooooooooooo_VL + " (" + Cost.RareEvent + ")";//Halloween 17
                chB15.BackColor = Color.Gainsboro; chB15.Text = Bastion.W_W_Wooooo_VL + " (" + Cost.Common + ")";//Halloween 16
                chB22.BackColor = Color.Gainsboro; chB22.Text = Bastion.Bwoo_Bwoo_Bwoo_VL + " (" + Cost.RareEvent + ")";//Winter 17
                chB16.BackColor = Color.Gainsboro; chB16.Text = Bastion.Dwee_Doo_Hoo_VL + " (" + Cost.Rare + ")";//Winter 16
                chB17.BackColor = Color.Gainsboro; chB17.Text = Bastion.Woop_Doo_Woo_Dun_Woop_VL + " (" + Cost.RareEvent + ")";//Rooster 17
                chB18.BackColor = Color.Gainsboro; chB18.Text = Bastion.Dwee_Wee_Woh_VL + " (" + Cost.RareEvent + ")";//Uprising 17
                chB19.BackColor = Color.Gainsboro; chB19.Text = Bastion.Zwee_Ah_Wheee_Doo_Woo_VL + " (" + Cost.RareEvent + ")";//Uprising 17
                chB20.BackColor = Color.Gainsboro; chB20.Text = Bastion.Bew_Woo_Bew_Woo_VL + " (" + Cost.RareEvent + ")";//Annyver 17
                chB21.BackColor = Color.Gainsboro; chB21.Text = Bastion.Doo_Dun_Dun_Woo_VL + " (" + Cost.RareEvent + ")";//Annyver 17

                chB00.Checked = true;/*
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VL01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VL02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VL03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VL04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VL05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VL06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VL07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("VL08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("VL09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("VL10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("VL11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("VL12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("VL13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("VL14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("VL15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("VL16"));
                chB17.Checked = Convert.ToBoolean(inisHeroes.Read("VL17"));
                chB18.Checked = Convert.ToBoolean(inisHeroes.Read("VL18"));
                chB19.Checked = Convert.ToBoolean(inisHeroes.Read("VL19"));
                chB20.Checked = Convert.ToBoolean(inisHeroes.Read("VL20"));
                chB21.Checked = Convert.ToBoolean(inisHeroes.Read("VL21"));
                chB22.Checked = Convert.ToBoolean(inisHeroes.Read("VL22"));*/
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Brigitte_Click(object sender, EventArgs e)
        {
            Heroe = "Brigitte";
            btnHeroeinvisible("Brigitte", 10, 4, 3);
            gbAll.Text = Brigitte.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnBrigitte()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;
            chBSave = 1;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p3, p1); chB07.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB07, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p3 + chB07.Width, p1 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p2 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p3 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Brigitte.Blå_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Brigitte.Grön_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Brigitte.Plommon_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Brigitte.Röd_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Brigitte.Carbon_Fiber_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Brigitte.Ironclad_SK;
                btn07.BackColor = Color.Gold; btn07.Text = Brigitte.Máni_SK;//Legendary
                btn08.BackColor = Color.Gold; btn08.Text = Brigitte.Sól_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Brigitte.Engineer_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Brigitte.Mechanic_SK;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));

            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p2, p1); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p2); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p2 + chB03.Width, p1 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p2 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Brigitte.Cheer_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Brigitte.Hilarious_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Brigitte.Recalibrate_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Brigitte.Taunt_EM;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p2, p1); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p2, p2); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p2 + chB02.Width, p1 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p2 + chB03.Width, p2 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Brigitte.Confident_VL;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Brigitte.Rally_VL;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Brigitte.Relaxed_VL;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void DVa_Click(object sender, EventArgs e)
        {
            Heroe = "D.Va";
            btnHeroeinvisible(Heroe, 14, 7, 6);
            gbAll.Text = DVa.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GoldWeapon"));
            chBSave = 1;
        }

        private void btnDVa()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;


            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = DVa.Blueberry_SK[1]; HeroTT.SetToolTip(chB01, DVa.Blueberry_SK[2]);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = DVa.Lemon_Lime_SK[1]; HeroTT.SetToolTip(chB02, DVa.Lemon_Lime_SK[2]);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = DVa.Tangerine_SK[1]; HeroTT.SetToolTip(chB03, DVa.Tangerine_SK[2]);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = DVa.Watermelon_SK[1]; HeroTT.SetToolTip(chB04, DVa.Watermelon_SK[2]);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = DVa.Carbon_Fiber_SK[1]; HeroTT.SetToolTip(chB05, DVa.Carbon_Fiber_SK[2]);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = DVa.White_Rabbit_SK[1]; HeroTT.SetToolTip(chB06, DVa.White_Rabbit_SK[2]);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = DVa.Taegeukgi_SK[1]; HeroTT.SetToolTip(chB07, DVa.Taegeukgi_SK[2]);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1); chB08.Text = DVa.Junker_SK[1]; HeroTT.SetToolTip(chB08, DVa.Junker_SK[2]);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = DVa.Scavenger_SK[1]; HeroTT.SetToolTip(chB09, DVa.Scavenger_SK[2]);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = DVa.BVa_SK[1]; HeroTT.SetToolTip(chB10, DVa.BVa_SK[2]);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = DVa.Junebug_SK[1]; HeroTT.SetToolTip(chB11, DVa.Junebug_SK[2]);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p5); chB15.Text = DVa.Black_Cat_SK[1]; HeroTT.SetToolTip(chB15, DVa.Black_Cat_SK[2]);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p6); chB12.Text = DVa.Officer_SK[1]; HeroTT.SetToolTip(chB12, DVa.Officer_SK[2]);
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p7); chB16.Text = DVa.Waveracer_SK[1]; HeroTT.SetToolTip(chB16, DVa.Waveracer_SK[2]);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p8); chB13.Text = DVa.Palanquin_SK[1]; HeroTT.SetToolTip(chB13, DVa.Palanquin_SK[2]);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p9); chB14.Text = DVa.Cruiser_SK[1]; HeroTT.SetToolTip(chB14, DVa.Cruiser_SK[2]);

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p5 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p6 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB16.Width, p7 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p8 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p9 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = DVa.Blueberry_SK[0];//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = DVa.Lemon_Lime_SK[0];
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = DVa.Tangerine_SK[0];
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = DVa.Watermelon_SK[0];
                btn05.BackColor = Color.DarkViolet; btn05.Text = DVa.Carbon_Fiber_SK[0];//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = DVa.White_Rabbit_SK[0];
                btn07.BackColor = Color.DarkViolet; btn07.Text = DVa.Taegeukgi_SK[0];//Summer 16
                btn08.BackColor = Color.Gold; btn08.Text = DVa.Junker_SK[0];//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = DVa.Scavenger_SK[0];
                btn10.BackColor = Color.Gold; btn10.Text = DVa.BVa_SK[0];
                btn11.BackColor = Color.Gold; btn11.Text = DVa.Junebug_SK[0];
                btn15.BackColor = Color.Gold; btn15.Text = DVa.Black_Cat_SK[0];
                btn12.BackColor = Color.Gold; btn12.Text = DVa.Officer_SK[0];
                btn16.BackColor = Color.Gold; btn16.Text = DVa.Waveracer_SK[0];//Summer 18
                btn13.BackColor = Color.Gold; btn13.Text = DVa.Palanquin_SK[0];//Rooster 17
                btn14.BackColor = Color.Gold; btn14.Text = DVa.Cruiser_SK[0];//Annyver 17

                if (Language != "EN")
                {
                    NoChangeText = true;
                    LangBrücke = Language;
                    Language = "EN";
                    ChangeLang();
                }
                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Blueberry_SK[0]));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Lemon_Lime_SK[0]));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Tangerine_SK[0]));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Watermelon_SK[0]));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Carbon_Fiber_SK[0]));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.White_Rabbit_SK[0]));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Taegeukgi_SK[0]));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Junker_SK[0]));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Scavenger_SK[0]));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.BVa_SK[0]));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Junebug_SK[0]));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Officer_SK[0]));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Palanquin_SK[0]));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Cruiser_SK[0]));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Black_Cat_SK[0]));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read(DVa.Waveracer_SK[0]));

            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Rooster + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB07, "Legendary");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = DVa._O__EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = DVa.Bunny_Hop_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = DVa.Heartbreaker_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = DVa.Party_Time_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = DVa.Bow_EM;//Rooster 17
                btn06.BackColor = Color.DarkViolet; btn06.Text = DVa.Dance_EM;//Annyver 17
                btn07.BackColor = Color.Gold; btn07.Text = DVa.Game_On_EM;//Legendary

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Halloween + " 2016");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Winter + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Rooster + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = DVa.I_Heart_You_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = DVa.Peace_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = DVa.Sitting_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = DVa.RIP_VP;//Halloween 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = DVa.Festive_VP;//Winter 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = DVa.Lucky_Pouch_VP;//Rooster 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.VoiceLines)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Common + ")";
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Common + ")";
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Common + ")";
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Common + ")";
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p1, p6); chB05.Text = "(" + Cost.Common + ")";
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p1, p7); chB06.Text = "(" + Cost.Common + ")";
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p1, p8); chB07.Text = "(" + Cost.Common + ")";
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p1); chB08.Text = "(" + Cost.Common + ")";
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p2, p2); chB09.Text = "(" + Cost.Common + ")";
                chB22.Visible = true; chB22.Location = new Point(gBAllWeited4p2, p3); chB22.Text = "(" + Cost.Common + ")";
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p2, p4); chB10.Text = "(" + Cost.Common + ")";
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p2, p5); chB11.Text = "(" + Cost.Common + ")";
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p2, p6); chB12.Text = "(" + Cost.CommonEvent + ")";
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p2, p7); chB13.Text = "(" + Cost.Common + ")";
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p2, p8); chB14.Text = "(" + Cost.CommonEvent + ")";
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p1); chB15.Text = "(" + Cost.Common + ")";
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p2); chB16.Text = "(" + Cost.CommonEvent + ")";
                chB17.Visible = true; chB17.Location = new Point(gBAllWeited4p3, p3); chB17.Text = "(" + Cost.CommonEvent + ")";
                chB18.Visible = true; chB18.Location = new Point(gBAllWeited4p3, p4); chB18.Text = "(" + Cost.CommonEvent + ")";
                chB19.Visible = true; chB19.Location = new Point(gBAllWeited4p3, p5); chB19.Text = "(" + Cost.CommonEvent + ")";
                chB20.Visible = true; chB20.Location = new Point(gBAllWeited4p3, p6); chB20.Text = "(" + Cost.CommonEvent + ")";
                chB21.Visible = true; chB21.Location = new Point(gBAllWeited4p3, p7); chB21.Text = "(" + Cost.CommonEvent + ")";

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p1 + chB05.Width, p6 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p1 + chB06.Width, p7 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p1 + chB07.Width, p8 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p2 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p2 + chB09.Width, p2 - 5);
                btn22.Visible = true; btn22.Location = new Point(gBAllWeited4p2 + chB22.Width, p3 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p2 + chB10.Width, p4 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p2 + chB11.Width, p5 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p2 + chB12.Width, p6 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p2 + chB13.Width, p7 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p2 + chB02.Width, p8 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB03.Width, p1 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB04.Width, p2 - 5);
                btn17.Visible = true; btn17.Location = new Point(gBAllWeited4p3 + chB05.Width, p3 - 5);
                btn18.Visible = true; btn18.Location = new Point(gBAllWeited4p3 + chB06.Width, p4 - 5);
                btn19.Visible = true; btn19.Location = new Point(gBAllWeited4p3 + chB07.Width, p5 - 5);
                btn20.Visible = true; btn20.Location = new Point(gBAllWeited4p3 + chB08.Width, p6 - 5);
                btn21.Visible = true; btn21.Location = new Point(gBAllWeited4p3 + chB09.Width, p7 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = DVa.Love_DVa_VL;//Default
                btn01.BackColor = Color.Gainsboro; btn01.Text = DVa.Winkyface_VL;//Common
                btn02.BackColor = Color.Gainsboro; btn02.Text = DVa.A_new_challenger_VL;
                btn03.BackColor = Color.Gainsboro; btn03.Text = DVa.AFK_VL;
                btn04.BackColor = Color.Gainsboro; btn04.Text = DVa.Aw_Yeah_VL;
                btn05.BackColor = Color.Gainsboro; btn05.Text = DVa.DVa_1_Bad_Guys_0_VL;
                btn06.BackColor = Color.Gainsboro; btn06.Text = DVa.GG_VL;
                btn07.BackColor = Color.Gainsboro; btn07.Text = DVa.I_play_to_win_VL;
                btn08.BackColor = Color.Gainsboro; btn08.Text = DVa.Is_this_Easy_Mode_VL;
                btn09.BackColor = Color.Gainsboro; btn09.Text = DVa.LOL_VL;
                btn22.BackColor = Color.Gainsboro; btn22.Text = DVa.Nice_try_VL;
                btn10.BackColor = Color.Gainsboro; btn10.Text = DVa.No_hacks_required_VL;
                btn11.BackColor = Color.Gainsboro; btn11.Text = DVa.Im_N_1_VL;//Summer 16
                btn12.BackColor = Color.Gainsboro; btn12.Text = DVa.Scoreboard_VL;//Summer 17
                btn13.BackColor = Color.Gainsboro; btn13.Text = DVa.Happy_Halloween_VL;//Halloween 16
                btn14.BackColor = Color.Gainsboro; btn14.Text = DVa.Im_not_scared_VL;//Halloween 17
                btn15.BackColor = Color.Gainsboro; btn15.Text = DVa.Happy_Holidays_VL;//Winter 16
                btn16.BackColor = Color.Gainsboro; btn16.Text = DVa.Aw_you_shouldnt_have_VL;//Winter 17
                btn17.BackColor = Color.Gainsboro; btn17.Text = DVa.The_best_things_in_life_VL;//Rooster 17
                btn18.BackColor = Color.Gainsboro; btn18.Text = DVa.Not_taking_me_seriously_VL;//Uprising 17
                btn19.BackColor = Color.Gainsboro; btn19.Text = DVa.Try_and_keep_up_VL;//Uprising 17
                btn20.BackColor = Color.Gainsboro; btn20.Text = DVa.Level_Up_VL;//Annyver 17
                btn21.BackColor = Color.Gainsboro; btn21.Text = DVa.No_Way_VL;//Annyver 17

                chB00.Checked = true;/*
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VL01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VL02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VL03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VL04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VL05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VL06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VL07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("VL08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("VL09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("VL10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("VL11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("VL12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("VL13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("VL14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("VL15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("VL16"));
                chB17.Checked = Convert.ToBoolean(inisHeroes.Read("VL17"));
                chB18.Checked = Convert.ToBoolean(inisHeroes.Read("VL18"));
                chB19.Checked = Convert.ToBoolean(inisHeroes.Read("VL19"));
                chB20.Checked = Convert.ToBoolean(inisHeroes.Read("VL20"));
                chB21.Checked = Convert.ToBoolean(inisHeroes.Read("VL21"));*/
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            if (NoChangeText==true)
            {
                Language = LangBrücke;
                ChangeLang();
                NoChangeText = false;
            }
            chBSave = 1;

        }

        private void Doomfist_Click(object sender, EventArgs e)
        {
            Heroe = "Doomfist";
            btnHeroeinvisible(Heroe, 10, 5, 3);
            gbAll.Text = Doomfist.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnDoomfist()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p1); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p3, p2); chB07.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB07, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p3); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p4); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p5); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p1 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p3 + chB07.Width, p2 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p3 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p4 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p5 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Doomfist.Daisy_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Doomfist.Lake_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Doomfist.Plains_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Doomfist.Sunset_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Doomfist.Leopard_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Doomfist.Painted_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Doomfist.Blackhand_SK;//Legendary
                btn07.BackColor = Color.Gold; btn07.Text = Doomfist.Caution_SK;
                btn08.BackColor = Color.Gold; btn08.Text = Doomfist.Irin_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Doomfist.Avatar_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Doomfist.Spirit_SK;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Dog + " 2018");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Doomfist.Fake_Out_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Doomfist.Intimidate_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Doomfist.Ready_for_Battle_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Doomfist.Take_a_knee_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Doomfist.Thumbs_Down_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Doomfist.Crushing_EM;//Lunar 18

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p2, p1); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p2, p2); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p2 + chB02.Width, p1 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p2 + chB03.Width, p2 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Doomfist.Intense_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Doomfist.Seismic_Slam_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Doomfist.Superior_VP;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
            }
            if (BackSave2 == Lang.VoiceLines)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1);
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2);
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3);
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4);
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5);
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p1, p6);
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p1);
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p2);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p3);
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p2, p4);
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p2, p5);
                chB17.Visible = true; chB17.Location = new Point(gBAllWeited4p2, p6);
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p1);
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p2);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p3);
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p4);
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p5);
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p6);

                chB00.BackColor = Color.Gainsboro; chB00.Text = Doomfist.Try_me_VL;//Default
                chB01.BackColor = Color.Gainsboro; chB01.Text = Doomfist.Combo_Breakere_VL + " (" + Cost.Common + ")";//Common
                chB02.BackColor = Color.Gainsboro; chB02.Text = Doomfist.Dont_get_back_up_VL + " (" + Cost.Common + ")";
                chB03.BackColor = Color.Gainsboro; chB03.Text = Doomfist.Go_and_sit_down_VL + " (" + Cost.Common + ")";
                chB04.BackColor = Color.Gainsboro; chB04.Text = Doomfist.I_havent_even_started_VL + " (" + Cost.Common + ")";
                chB05.BackColor = Color.Gainsboro; chB05.Text = Doomfist.K_O_VL + " (" + Cost.Common + ")";
                chB06.BackColor = Color.Gainsboro; chB06.Text = Doomfist.One_punch_is_all_i_need_VL + " (" + Cost.Common + ")";
                chB07.BackColor = Color.Gainsboro; chB07.Text = Doomfist.Spare_me_the_commentary_VL + " (" + Cost.Common + ")";
                chB08.BackColor = Color.Gainsboro; chB08.Text = Doomfist.Talk_to_the_fist_VL + " (" + Cost.Common + ")";
                chB09.BackColor = Color.Gainsboro; chB09.Text = Doomfist.Youre_not_bad_VL + " (" + Cost.Common + ")";
                chB10.BackColor = Color.Gainsboro; chB10.Text = Doomfist.You_must_be_joking_VL + " (" + Cost.Common + ")";
                chB17.BackColor = Color.Gainsboro; chB17.Text = Doomfist.You_test_my_patience_VL + " (" + Cost.Common + ")";
                chB11.BackColor = Color.Gainsboro; chB11.Text = Doomfist.I_make_medicine_sick_VL + " (" + Cost.CommonEvent + ")";//Summer 17
                chB12.BackColor = Color.Gainsboro; chB12.Text = Doomfist.Make_you_punch_drunk_VL + " (" + Cost.CommonEvent + ")";//Summer 17
                chB13.BackColor = Color.Gainsboro; chB13.Text = Doomfist.I_have_something_for_you_VL + " (" + Cost.CommonEvent + ")";//Halloween 17
                chB14.BackColor = Color.Gainsboro; chB14.Text = Doomfist.You_should_be_scared_VL + " (" + Cost.CommonEvent + ")";//Halloween 17
                chB15.BackColor = Color.Gainsboro; chB15.Text = Doomfist.And_they_sais_chivalry_is_dead_VL + " (" + Cost.CommonEvent + ")";//Winter 17
                chB16.BackColor = Color.Gainsboro; chB16.Text = Doomfist.Did_you_bring_me_a_present_VL + " (" + Cost.CommonEvent + ")";//Winter 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VL01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VL02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VL03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VL04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VL05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VL06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VL07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("VL08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("VL09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("VL10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("VL11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("VL12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("VL13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("VL14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("VL15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("VL16"));
                chB17.Checked = Convert.ToBoolean(inisHeroes.Read("VL17"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Genji_Click(object sender, EventArgs e)
        {
            Heroe = "Genji";
            btnHeroeinvisible(Heroe, 14, 6, 5);
            gbAll.Text = Genji.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnGenji()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Summer + " 2016");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, "Legendary");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p6); chB15.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB15, Lang.Dog + " 2018");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p7); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Uprising + " 2017");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p8); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p5 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p6 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p7 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p8 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Genji.Azurite_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Genji.Cinnabar_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Genji.Malachite_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Genji.Ochre_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Genji.Carbon_Fiber_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Genji.Chrome_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Genji.Nihon_SK;//Summer 16
                btn08.BackColor = Color.Gold; btn08.Text = Genji.Sparrow_SK;//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = Genji.Young_Genji_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Genji.Bedouin_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Genji.Nomad_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Genji.Oni_SK;
                btn15.BackColor = Color.Gold; btn15.Text = Genji.Baihu_SK;
                btn13.BackColor = Color.Gold; btn13.Text = Genji.Blackwatch_SK;//Uprising 17
                btn14.BackColor = Color.Gold; btn14.Text = Genji.Sentai_SK;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p4); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Genji.Amusing_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Genji.Challenge_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Genji.Cutting_Edge_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Genji.Meditate_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Genji.Salute_EM;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Genji.Whirlwind_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Genji.Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p2); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB05, Lang.Winter + " 2017");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p3); chB05.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p2 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Genji.Kneeling_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Genji.Shuriken_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Genji.Sword_Stance_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Genji.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Genji.Toast_VP;//Winter 17
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Genji.Meditate_EM;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Hanzo_Click(object sender, EventArgs e)
        {
            Heroe = "Hanzo";
            btnHeroeinvisible(Heroe, 12, 7, 6);
            gbAll.Text = Hanzo.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnHanzo()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Halloween + " 2016");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p1); chB14.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB14, "Legndary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legndary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legndary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legndary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p5); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legndary");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Winter + " 2017");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p7); chB12.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB12, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p1 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p2 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p3 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p4 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p6 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p7 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Hanzo.Azuki_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Hanzo.Kinoko_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Hanzo.Midori_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Hanzo.Sora_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Hanzo.Cloud_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Hanzo.Dragon_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Hanzo.Demon_SK;//Halloween 16
                btn14.BackColor = Color.Gold; btn14.Text = Hanzo.Kabuki_SK;//Legendary
                btn08.BackColor = Color.Gold; btn08.Text = Hanzo.Young_Hanzo_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Hanzo.Young_Master_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Hanzo.Lone_Wolf_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Hanzo.Okami_SK;
                btn13.BackColor = Color.Gold; btn13.Text = Hanzo.Casual_SK;//Winter 17
                btn12.BackColor = Color.Gold; btn12.Text = Hanzo.Cyberninja_SK;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Uprising + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Hanzo.Beckon_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Hanzo.Brush_Shoulder_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Hanzo.Chuckle_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Hanzo.Meditate_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Hanzo.Victory_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Hanzo.Training_EM;//Uprising 17
                btn07.BackColor = Color.DarkViolet; btn07.Text = Hanzo.Fisherman_Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2017");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Halloween + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Hanzo.Confident_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Hanzo.Kneeling_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Hanzo.Over_the_shoulder_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Hanzo.Medal_VP;//Summer 17
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Hanzo.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Hanzo.Skewered_VP;//Halloween 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Junkrat_Click(object sender, EventArgs e)
        {
            Heroe = "Junkrat";
            btnHeroeinvisible(Heroe, 13, 7, 7);
            gbAll.Text = Junkrat.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnJunkrat()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p2, p1); chB15.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB15, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Rooster + " 2017");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Summer + " 2017");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, Lang.Halloween + " 2016");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Winter + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p2 + chB15.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p4 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p5 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p6 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p7 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Junkrat.Bleached_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Junkrat.Drowned_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Junkrat.Irradiated_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Junkrat.Rusted_SK;
                btn15.BackColor = Color.DarkViolet; btn15.Text = Junkrat.Caution_SK;//Epic
                btn05.BackColor = Color.DarkViolet; btn05.Text = Junkrat.Jailbird_SK;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Junkrat.Toasted_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Junkrat.Firework_SK;//Rooster 17
                btn08.BackColor = Color.Gold; btn08.Text = Junkrat.Fool_SK;//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = Junkrat.Jester_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Junkrat.Hayseed_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Junkrat.Scarecrow_SK;
                btn13.BackColor = Color.Gold; btn13.Text = Junkrat.Cricket_SK;//Summer 17
                btn12.BackColor = Color.Gold; btn12.Text = Junkrat.Dr_Junkenstein_SK;//Halloween 16
                btn14.BackColor = Color.Gold; btn14.Text = Junkrat.Beachrat_SK;//Winter 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Uprising + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Junkrat.Cant_Deal_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Junkrat.Juggling_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Junkrat.Lounging_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Junkrat.Puppet_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Junkrat.Vaudeville_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Junkrat.Dud_EM;//Uprising 17
                btn07.BackColor = Color.DarkViolet; btn07.Text = Junkrat.Running_Rat_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2017");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2017");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB06, Lang.Halloween + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Rooster + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Junkrat.Itll_freeze_that_way_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Junkrat.Kneeling_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Junkrat.Nyah_Nyah_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Junkrat.Medal_VP;//Summer 17
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Junkrat.Pumpkin_VP;//Halloween 17
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Junkrat.RIP_VP;//Halloween 16
                btn07.BackColor = Color.DeepSkyBlue; btn07.Text = Junkrat.Bad_for_your_health_VP;//Rooster 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VP07"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Lúcio_Click(object sender, EventArgs e)
        {
            Heroe = "Lúcio";
            btnHeroeinvisible(Heroe, 14, 7, 6);
            gbAll.Text = Lúcio.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnLúcio()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Winter + " 2016");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p1); chB15.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB15, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p5); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p6); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, Lang.Summer + " 2016");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p7); chB13.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB13, Lang.Summer + " 2016");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p8); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p1 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p2 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p3 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p4 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p6 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p7 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p8 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Lúcio.Azul_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Lúcio.Laranja_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Lúcio.Roxo_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Lúcio.Vermelho_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Lúcio.Auditiva_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Lúcio.Synaesthesia_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Lúcio.Andes_SK;//Winter 16
                btn15.BackColor = Color.Gold; btn15.Text = Lúcio.Capoeira_SK;//Legendary
                btn08.BackColor = Color.Gold; btn08.Text = Lúcio.Hippityhop_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Lúcio.Ribbit_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Lúcio.Breakaway_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Lúcio.Slapshot_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Lúcio.Seleção_SK;//Summer 16
                btn13.BackColor = Color.Gold; btn13.Text = Lúcio.Striker_SK;//Summer 16
                btn14.BackColor = Color.Gold; btn14.Text = Lúcio.Jazzy_SK;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, Lang.Summer + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Lúcio.Capoeira_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Lúcio.Chilling_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Lúcio.In_the_Groove_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Lúcio.Knee_Slapper_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Lúcio.Nah_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Lúcio.Juggle_EM;//Summer 16
                btn07.BackColor = Color.DarkViolet; btn07.Text = Lúcio.Smooth_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB04, Lang.Halloween + " 2017");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Lúcio.Configent_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Lúcio.Grooving_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Lúcio.Ready_for_action_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Lúcio.Pumpkin_Control_VP;//Halloween 17
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Lúcio.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Lúcio.Handstand_VP;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void McCree_Click(object sender, EventArgs e)
        {
            Heroe = "McCree";
            btnHeroeinvisible(Heroe, 15, 7, 5);
            gbAll.Text = McCree.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnMcCree()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p2, p2); chB16.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB16, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p4); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Summer + " 2016");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p5); chB08.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB08, Lang.Winter + " 2016");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, "Legendary");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p5); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Summer + " 2017");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p6); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Halloween + " 2017");
                chB17.Visible = true; chB17.Location = new Point(gBAllWeited4p3, p7); chB17.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB17, Lang.Dog + " 2018");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p8); chB15.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB15, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p2 + chB16.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p4 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p2 + chB08.Width, p5 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p1 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p2 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p3 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p4 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p5 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p6 - 5);
                btn17.Visible = true; btn17.Location = new Point(gBAllWeited4p3 + chB17.Width, p7 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p8 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = McCree.Ebony_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = McCree.Lake_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = McCree.Sage_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = McCree.Wheat_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = McCree.On_The_Range_SK;//Epic
                btn16.BackColor = Color.DarkViolet; btn16.Text = McCree.Royal_SK;
                btn06.BackColor = Color.DarkViolet; btn06.Text = McCree.White_Hat_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = McCree.American_SK;//Summer 16
                btn08.BackColor = Color.DarkViolet; btn08.Text = McCree.Scrooge_SK;//Winter 16
                btn09.BackColor = Color.Gold; btn09.Text = McCree.Gambler_SK;//Legendary
                btn10.BackColor = Color.Gold; btn10.Text = McCree.Riverboat_SK;
                btn11.BackColor = Color.Gold; btn11.Text = McCree.Mystery_Man_SK;
                btn12.BackColor = Color.Gold; btn12.Text = McCree.Vigilante_SK;
                btn13.BackColor = Color.Gold; btn13.Text = McCree.Lifeguard_SK;//Summer 17
                btn14.BackColor = Color.Gold; btn14.Text = McCree.Van_Helsing_SK;//Halloween 17
                btn17.BackColor = Color.Gold; btn17.Text = McCree.Magistrate_SK;//Lunar 18
                btn15.BackColor = Color.Gold; btn15.Text = McCree.Blackwatch_SK;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
                chB17.Checked = Convert.ToBoolean(inisHeroes.Read("SK17"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, Lang.Winter + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = " (" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = McCree.Gunspinning_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = McCree.Hat_Tip_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = McCree.Joker_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = McCree.Spit_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = McCree.Take_a_load_off_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = McCree.Hat_Trick_EM;//Winter 16
                btn07.BackColor = Color.DarkViolet; btn07.Text = McCree.Line_Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p2); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Dog + " 2018");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p3); chB05.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB05, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = McCree.Contemplative_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = McCree.Over_the_shoulder_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = McCree.Take_it_easy_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = McCree.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = McCree.Fire_in_the_hole_VP;//Lunar 18
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = McCree.Showdown_VP;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }
        //

        private void Mei_Click(object sender, EventArgs e)
        {
            Heroe = "Mei";
            btnHeroeinvisible(Heroe, 15, 9, 6);
            gbAll.Text = Mei.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnMei()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p1); chB16.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB16, "Legendary");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p3, p2); chB07.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB07, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p3); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p4); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p5); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p6); chB11.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB11, Lang.Halloween + " 2017");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p7); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, Lang.Winter + " 2016");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p8); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Rooster + " 2017");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p9); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Rooster + " 2017");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p10); chB15.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB15, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB16.Width, p1 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p3 + chB07.Width, p2 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p3 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p4 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p5 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p6 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p7 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p8 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p9 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p10 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Mei.Chrysanthemum_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Mei.Heliotrope_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Mei.Jade_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Mei.Persimmon_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Mei.Earthen_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Mei.Snow_Plum_SK;
                btn16.BackColor = Color.Gold; btn16.Text = Mei.Ecopoint_Antarctica_SK;//Legendary
                btn07.BackColor = Color.Gold; btn07.Text = Mei.Firefighter_SK;
                btn08.BackColor = Color.Gold; btn08.Text = Mei.Rescue_Mei_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Mei.Abominable_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Mei.Yeti_Hunter_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Mei.Jiangshi_SK;//Halloween 17
                btn12.BackColor = Color.Gold; btn12.Text = Mei.Mei_rry_SK;//Winter 16
                btn13.BackColor = Color.Gold; btn13.Text = Mei.Chang_e_SK;//Rooster 17
                btn14.BackColor = Color.Gold; btn14.Text = Mei.Luna_SK;//Rooster 17
                btn15.BackColor = Color.Gold; btn15.Text = Mei.Beekeeper_SK;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p1, p5); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p2); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Halloween + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Winter + " 2017");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited3p2, p4); chB08.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB08, Lang.Rooster + " 2017");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited3p2, p5); chB09.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB09, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited3p2 + chB08.Width, p4 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited3p2 + chB09.Width, p5 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Mei.Companion_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Mei.Gigle_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Mei.Kneel_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Mei.Spray_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Mei.Yaaaaaaaaay_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Mei.Hopping_EM;//Halloween 17
                btn07.BackColor = Color.DarkViolet; btn07.Text = Mei.Snowman_EM;//Winter 16
                btn08.BackColor = Color.DarkViolet; btn08.Text = Mei.So_excited_EM;//Rooster 17
                btn09.BackColor = Color.DarkViolet; btn09.Text = Mei.Sunny_Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("EM08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("EM09"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2016");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Rooster + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Mei.Casual_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Mei.Hands_on_hips_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Mei.Kneeling_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Mei.Medal_VP;//Summer 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Mei.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Mei.Lucky_VP;//Rooster 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Mercy_Click(object sender, EventArgs e)
        {
            Heroe = "Mercy";
            btnHeroeinvisible(Heroe, 15, 6, 6);
            gbAll.Text = Mercy.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnMercy()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Summer + " 2016");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4); chB08.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB08, Lang.Rooster + " 2017");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, "Legendary");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p5); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Summer + " 2017");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p6); chB14.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB14, Lang.Halloween + " 2016");
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p7); chB16.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Dog + " 2018");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p8); chB15.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB15, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p2 + chB08.Width, p4 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p1 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p2 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p3 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p4 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p5 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p6 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB16.Width, p7 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p8 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Mercy.Celestial_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Mercy.Mist_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Mercy.Orchid_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Mercy.Verdant_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Mercy.Amber_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Mercy.Cobalt_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Mercy.Eidgenossin_SK;//Summer 16
                btn08.BackColor = Color.DarkViolet; btn08.Text = Mercy.Fortune_SK;//Rooster 17
                btn09.BackColor = Color.Gold; btn09.Text = Mercy.Sigrun_SK;//Legendary
                btn10.BackColor = Color.Gold; btn10.Text = Mercy.Valkyrie_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Mercy.Devil_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Mercy.IMP_SK;
                btn13.BackColor = Color.Gold; btn13.Text = Mercy.Winged_Victory_SK;//Summer 17
                btn14.BackColor = Color.Gold; btn14.Text = Mercy.Witch_SK;//Halloween 16
                btn16.BackColor = Color.Gold; btn16.Text = Mercy.Zhuque_SK;//Lunar 18
                btn15.BackColor = Color.Gold; btn15.Text = Mercy.Combat_Medic_Ziegler_SK;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p1); chB07.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p2); chB04.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p3); chB05.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p4); chB06.Text = " (" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p1 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p2 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Mercy.Applause_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Mercy.Caduceus_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Mercy.No_Pulse_EM;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Mercy.Parasol_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Mercy.Relax_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Mercy.The_best_Medicine_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Mercy.Hustle_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = " (" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2017");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB06, Lang.Winter + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = " (" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Winter + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Mercy.Angelic_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Mercy.Carefree_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Mercy.Ready_for_Battle_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Mercy.Medal_VP;//Summer 17
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Mercy.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Mercy.Mistletoe_VP;//Winter 16
                btn07.BackColor = Color.DeepSkyBlue; btn07.Text = Mercy.Toast_VP;//Winter 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VP07"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Moira_Click(object sender, EventArgs e)
        {
            Heroe = "Moira";
            btnHeroeinvisible(Heroe, 10, 5, 3);
            gbAll.Text = Moira.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnMoira()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p3, p1); chB07.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB01, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB01, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB01, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB01, "Legendary");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p3 + chB07.Width, p1 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p2 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p3 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Moira.Fiery_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Moira.Royal_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Moira.Selkie_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Moira.Whiskey_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Moira.Ornate_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Moira.Pale_SK;
                btn07.BackColor = Color.Gold; btn07.Text = Moira.Minister_SK;//Legendary
                btn08.BackColor = Color.Gold; btn08.Text = Moira.Oasis_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Moira.Glam_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Moira.Moon_SK;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p1, p4); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p2, p1); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p2); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p3); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p1 + chB06.Width, p4 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p2 + chB03.Width, p1 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p2 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Moira.A_your_service_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Moira.Come_here_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Moira.Facepalm_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Moira.Give_and_take_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Moira.How_amusing_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Moira.Waiting_EM;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p2, p1); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p2, p2); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p2 + chB02.Width, p1 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p2 + chB03.Width, p2 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Moira.Orbs_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Moira.Prim_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Moira.Steepling_VP;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Orisa_Click(object sender, EventArgs e)
        {
            Heroe = "Orisa";
            btnHeroeinvisible(Heroe, 11, 6, 4);
            gbAll.Text = Orisa.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnOrisa()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p1); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, "Legendary");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p3, p2); chB07.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB07, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p3); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p4); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p5); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p6); chB11.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB11, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p1 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p3 + chB07.Width, p2 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p3 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p4 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p5 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p6 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Orisa.Dawn_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Orisa.Plains_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Orisa.Sunrise_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Orisa.Twilight_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Orisa.Camouflage_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Orisa.OR15_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Orisa.Immortal_SK;//Legendary
                btn07.BackColor = Color.Gold; btn07.Text = Orisa.Dynastinae_SK;
                btn08.BackColor = Color.Gold; btn08.Text = Orisa.Megasoma_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Orisa.Carbon_Fiber_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Orisa.Protector_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Orisa.Null_Sector_SK;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Annyver + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Winter + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Orisa.Cheer_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Orisa.Halt_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Orisa.Kicking_Dirt_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Orisa.Laugh_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Orisa.Sit_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Orisa.Dance_EM;//Annyver 17
                btn07.BackColor = Color.Gold; btn07.Text = Orisa.Puppy_EM;//Winter 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p2, p1); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p2); chB04.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB01, Lang.Halloween + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p2 + chB03.Width, p1 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p2 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Orisa.Confident_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Orisa.Flex_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Orisa.Halt_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Orisa.Pumpkin_Head_VP;//Halloween 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Pharah_Click(object sender, EventArgs e)
        {
            Heroe = "Pharah";
            btnHeroeinvisible(Heroe, 14, 7, 6);
            gbAll.Text = Pharah.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnPharah()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Halloween + " 2016");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4); chB08.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB08, Lang.Winter + " 2016");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p1); chB15.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB15, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, "Legendary");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6); chB13.Text = "(" + Lang.OriginGotY + ")"; HeroTT.SetToolTip(chB13, Lang.OriginGotY2);
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p7); chB16.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB16, Lang.Dog + " 2018");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p8); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p2 + chB08.Width, p4 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p6 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB16.Width, p7 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p8 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Pharah.Amethyst_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Pharah.Copper_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Pharah.Emerald_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Pharah.Titanium_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Pharah.Anubis_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Pharah.Jackal_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Pharah.Possessed_SK;//Halloween 16
                btn08.BackColor = Color.DarkViolet; btn08.Text = Pharah.Frostbite_SK;//Winter 16
                btn15.BackColor = Color.Gold; btn15.Text = Pharah.Asp_SK;//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = Pharah.Mechaqueen_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Pharah.Raptorion_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Pharah.Raindancer_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Pharah.Thunderbird_SK;
                btn13.BackColor = Color.Gold; btn13.Text = Pharah.Security_Chief_SK;//Origin
                btn16.BackColor = Color.Gold; btn16.Text = Pharah.Qinglong_SK;//Lunar 18
                btn14.BackColor = Color.Gold; btn14.Text = Pharah.Bedouin_SK;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Uprising + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Pharah.Cheer_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Pharah.Chuckle_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Pharah.Flourish_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Pharah.Knuckles_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Pharah.Take_a_knee_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Pharah.Flair_EM;//Uprising 17
                btn07.BackColor = Color.DarkViolet; btn07.Text = Pharah.Rocket_Guitar_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2016");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB06, Lang.Winter + " 2016");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Pharah.Guardian_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Pharah.Kneeling_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Pharah.Jump_Jet_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Pharah.Medal_VP;//Summer 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Pharah.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Pharah.Toast_VP;//Winter 16

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Reaper_Click(object sender, EventArgs e)
        {
            Heroe = "Reaper";
            btnHeroeinvisible(Heroe, 15, 7, 6);
            gbAll.Text = Reaper.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnReaper()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p2, p2); chB16.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB16, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p4); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Winter + " 2016");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5); chB12.Text = "(" + Lang.OriginGotY + ")"; HeroTT.SetToolTip(chB12, Lang.OriginGotY2);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Summer + " 2017");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Halloween + " 2017");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p8); chB15.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB15, Lang.Halloween + " 2016");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p2 + chB16.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p4 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p6 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p7 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p8 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Reaper.Blood_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Reaper.Midnight_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Reaper.Moss_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Reaper.Royal_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Reaper.Desert_SK;//Epic
                btn16.BackColor = Color.DarkViolet; btn16.Text = Reaper.Hellfire_SK;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Reaper.Wight_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Reaper.Shiver_SK;//Winter 16
                btn08.BackColor = Color.Gold; btn08.Text = Reaper.Nevermore_SK;//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = Reaper.Plague_Doctor_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Reaper.El_Blanco_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Reaper.Mariachi_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Reaper.Blackwatch_Reyes_SK;//Origin
                btn13.BackColor = Color.Gold; btn13.Text = Reaper.Biker_SK;//Summer 17
                btn14.BackColor = Color.Gold; btn14.Text = Reaper.Dracula_SK;//Halloween 17
                btn15.BackColor = Color.Gold; btn15.Text = Reaper.Pumpkin_SK;//Halloween 16

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Reaper.Cackle_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Reaper.Not_Impressed_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Reaper.Shrug_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Reaper.Slice_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Reaper.Slow_Clap_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Reaper.Take_a_knee_EM;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Reaper.Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, Lang.Summer + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, Lang.Halloween + " 2016");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Reaper.Casual_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Reaper.Enigmatic_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Reaper.Menacing_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Reaper.Shrug_EM;
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Reaper.Medal_VP;//Summer 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Reaper.RIP_VP;//Halloween 16

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Reinhardt_Click(object sender, EventArgs e)
        {
            Heroe = "Reinhardt";
            btnHeroeinvisible(Heroe, 15, 7, 5);
            gbAll.Text = Reinhardt.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnReinhardt()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Halloween + " 2016");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4); chB08.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB08, Lang.Uprising + " 2017");
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p1); chB16.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB16, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, "Legendary");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6); chB13.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB13, "Legendary");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7); chB14.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB14, "Legendary");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p8); chB15.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB15, Lang.Rooster + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p2 + chB08.Width, p4 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB16.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p6 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p7 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p8 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Reinhardt.Brass_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Reinhardt.Cobalt_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Reinhardt.Copper_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Reinhardt.Viridian_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Reinhardt.Bundeswehr_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Reinhardt.Paragon_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Reinhardt.Coldhardt_SK;//Halloween 16
                btn08.BackColor = Color.DarkViolet; btn08.Text = Reinhardt.Lieutenant_Wilhelm_SK;//Uprising 17
                btn16.BackColor = Color.Gold; btn16.Text = Reinhardt.Crusader_SK;//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = Reinhardt.Blackhardt_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Reinhardt.Bloodhardt_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Reinhardt.Lionhardt_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Reinhardt.Stonehardt_SK;
                btn13.BackColor = Color.Gold; btn13.Text = Reinhardt.Balderich_SK;
                btn14.BackColor = Color.Gold; btn14.Text = Reinhardt.Greifhardt_SK;
                btn15.BackColor = Color.Gold; btn15.Text = Reinhardt.Wujing_SK;//Rooster 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, Lang.Halloween + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Reinhardt.Flex_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Reinhardt.Knee_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Reinhardt.Taunt_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Reinhardt.Uproarious_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Reinhardt.Warriors_Salute_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Reinhardt.Punpkin_Smash_EM;//Halloween 16
                btn07.BackColor = Color.DarkViolet; btn07.Text = Reinhardt.Sweethardt_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p2, p1); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p2); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Halloween + " 2016");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p3); chB05.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB05, Lang.Winter + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p2 + chB03.Width, p1 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p2 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Reinhardt.Confident_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Reinhardt.Flex_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Reinhardt.Legendary_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Reinhardt.RIP_VP;//Halloween 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Reinhardt.Toast_VP;//Winter 16

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Roadhog_Click(object sender, EventArgs e)
        {
            Heroe = "Roadhog";
            btnHeroeinvisible(Heroe, 13, 6, 6);
            gbAll.Text = Roadhog.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnRoadhog()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = " (" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Winter + " 2016");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p1); chB15.Text = " (" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB15, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2); chB08.Text = " (" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3); chB09.Text = " (" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4); chB10.Text = " (" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p5); chB11.Text = " (" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p6); chB12.Text = " (" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, Lang.Halloween + " 2016");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7); chB14.Text = " (" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Winter + " 2017");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p8); chB13.Text = " (" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Rooster + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p1 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p2 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p3 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p4 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p5 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p6 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p7 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p8 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Roadhog.Kiwi_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Roadhog.Mud_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Roadhog.Sand_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Roadhog.Thistle_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Roadhog.Pigpen_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Roadhog.Stitched_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Roadhog.Rudolph_SK;//Winter 16
                btn15.BackColor = Color.Gold; btn15.Text = Roadhog.Butcher_SK;//Legendary
                btn08.BackColor = Color.Gold; btn08.Text = Roadhog.Islander_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Roadhog.Toa_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Roadhog.Mako_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Roadhog.Sharkbait_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Roadhog.Junkensteins_Monster_SK;//Halloween 16
                btn14.BackColor = Color.Gold; btn14.Text = Roadhog.Ice_Fisherman_SK;//Winter 17
                btn13.BackColor = Color.Gold; btn13.Text = Roadhog.Bajie_SK;//Rooster 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Dog + " 2018");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p4); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Roadhog.Belly_Laugh_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Roadhog.Boo_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Roadhog.Can_Crusher_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Roadhog.Headbanging_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Roadhog.Tuckered_Out_EM;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Roadhog.Secret_friend_EM;//Lunar 18
                btn06.BackColor = Color.DarkViolet; btn06.Text = Roadhog.Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2016");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Winter + " 2017");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p4); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Rooster + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Roadhog.Pointing_to_the_sky_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Roadhog.Thumbs_Up_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Roadhog.Tuckered_out_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Roadhog.Medal_VP;//Summer 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Roadhog.RIP_VP;//Halloween 16
                btn07.BackColor = Color.DeepSkyBlue; btn07.Text = Roadhog.Toast_VP;//Winter 17
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Roadhog.Whats_mine_is_mine_VP;//Rooster 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VP07"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Soldier_76_Click(object sender, EventArgs e)
        {
            Heroe = "Soldier 76";
            btnHeroeinvisible(Heroe, 15, 7, 6);
            gbAll.Text = Soldier_76.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnSoldier_76()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Halloween + " 2016");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5); chB12.Text = "(" + Lang.OriginGotY + ")"; HeroTT.SetToolTip(chB12, Lang.OriginGotY2);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Halloween + " 2017");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p7); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Winter + " 2017");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p8); chB15.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB15, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p6 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p7 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p8 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Soldier_76.Jet_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Soldier_76.Olive_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Soldier_76.Russet_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Soldier_76.Smoke_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Soldier_76.Bone_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Soldier_76.Golden_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Soldier_76.Immortal_SK;//Halloween 16
                btn08.BackColor = Color.Gold; btn08.Text = Soldier_76.Commando_76_SK;//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = Soldier_76.Night_Ops_76_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Soldier_76.Daredevil_76_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Soldier_76.Stunt_Rider_76_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Soldier_76.Strike_Commander_Morrison_SK;//Origin
                btn13.BackColor = Color.Gold; btn13.Text = Soldier_76.Grillmaster_76_SK;//Summer 17
                btn15.BackColor = Color.Gold; btn15.Text = Soldier_76.Alpine_76_SK;//Winter 17
                btn14.BackColor = Color.Gold; btn14.Text = Soldier_76.Cyborg_76_SK;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Uprising + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Soldier_76.Amused_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Soldier_76.Fist_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Soldier_76.I_see_you_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Soldier_76.Locked_and_Loaded_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Soldier_76.Take_a_knee_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Soldier_76.Push_Ups_EM;//Uprising 17
                btn07.BackColor = Color.DarkViolet; btn07.Text = Soldier_76.Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, Lang.Summer + " 2016");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, Lang.Winter + " 2016");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Soldier_76.Fist_Pump_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Soldier_76.Locked_and_Loaded_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Soldier_76.Soldier_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Soldier_76.Golf_Swing_VP;//Summer 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Soldier_76.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Soldier_76.Toast_VP;//Winter 16

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Sombra_Click(object sender, EventArgs e)
        {
            Heroe = "Sombra";
            btnHeroeinvisible(Heroe, 12, 6, 6);
            gbAll.Text = Sombra.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnSombra()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Winter + " 2016");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5); chB12.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB12, Lang.Summer + " 2017");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Winter + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p6 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Sombra.Cidro_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Sombra.Incendio_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Sombra.Mar_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Sombra.Noche_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Sombra.Glitch_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Sombra.Virus_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Sombra.Peppermint_SK;//Winter 16
                btn08.BackColor = Color.Gold; btn08.Text = Sombra.Azúcar_SK;//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = Sombra.Los_Muertos_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Sombra.Augmented_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Sombra.Cyberspace_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Sombra.Tulum_SK;//Summer 17
                btn13.BackColor = Color.Gold; btn13.Text = Sombra.Rime_SK;//Winter 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p1); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p2); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p3); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p4); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p1 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p2 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Sombra.Amused_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Sombra.Boop_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Sombra.Hold_on_EM;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Sombra.Marioneta_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Sombra.Masterpiece_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Sombra.Sit_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Sombra.Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB05, Lang.Summer + " 2017");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB05, Lang.Winter + " 2017");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p4); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB05, Lang.Rooster + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Sombra.Hacked_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Sombra.Kneeling_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Sombra.Rising_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Sombra.Medal_VP;//Summer 17
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Sombra.Pumpkinette_VP;//Halloween 17
                btn07.BackColor = Color.DeepSkyBlue; btn07.Text = Sombra.Toast_VP;//Winter 17
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Sombra.Sparklers_VP;//Rooster 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VP07"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }
        //

        private void Symmetra_Click(object sender, EventArgs e)
        {
            Heroe = "Symmetra";
            btnHeroeinvisible(Heroe, 14, 7, 6);
            gbAll.Text = Symmetra.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnSymmetra()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p2, p1); chB15.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB15, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p4); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Halloween + " 2016");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p5); chB08.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB08, Lang.Rooster + " 2017");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, "Legendary");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p5); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Halloween + " 2017");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p6); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p2 + chB15.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p4 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p2 + chB08.Width, p5 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p1 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p2 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p3 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p4 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p5 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p6 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Symmetra.Cardamom_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Symmetra.Hyacinth_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Symmetra.Saffron_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Symmetra.Technomancer_SK;
                btn15.BackColor = Color.DarkViolet; btn15.Text = Symmetra.Peacock_SK;//Epic
                btn05.BackColor = Color.DarkViolet; btn05.Text = Symmetra.Regal_SK;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Symmetra.Utopaea_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Symmetra.Vampire_SK;//Halloween 16
                btn08.BackColor = Color.DarkViolet; btn08.Text = Symmetra.Qipao_SK;//Rooster 17
                btn09.BackColor = Color.Gold; btn09.Text = Symmetra.Architech_SK;//Legendary
                btn10.BackColor = Color.Gold; btn10.Text = Symmetra.Vishkar_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Symmetra.Devi_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Symmetra.Goddess_SK;
                btn13.BackColor = Color.Gold; btn13.Text = Symmetra.Dragon_SK;//Halloween 17
                btn14.BackColor = Color.Gold; btn14.Text = Symmetra.Oasis_SK;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, Lang.Summer + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Symmetra.Clap_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Symmetra.Flow_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Symmetra.Have_a_seat_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Symmetra.Insignificant_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Symmetra.Snicker_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Symmetra.Ribbon_EM;//Summer 16
                btn07.BackColor = Color.DarkViolet; btn07.Text = Symmetra.Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2017");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Dog + " 2018");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p4); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Symmetra.Balance_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Symmetra.Creation_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Symmetra.Dance_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Symmetra.Medal_VP;//Summer 17
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Symmetra.RIP_VP;//Halloween 16
                btn07.BackColor = Color.DeepSkyBlue; btn07.Text = Symmetra.Fan_VP;//Lunar 18
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Symmetra.Light_Reading_VP;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VP07"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Torbjörn_Click(object sender, EventArgs e)
        {
            Heroe = "Torbjörn";
            btnHeroeinvisible(Heroe, 15, 7, 6);
            gbAll.Text = Torbjörn.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnTorbjörn()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Summer + " 2016");
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p1); chB16.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB16, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p5); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p6); chB12.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB12, Lang.Halloween + " 2017");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p7); chB13.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB13, Lang.Winter + " 2016");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p8); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Uprising + " 2017");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p9); chB15.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB15, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB16.Width, p1 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p2 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p3 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p4 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p5 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p6 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p7 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p8 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p9 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Torbjörn.Blå_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Torbjörn.Citron_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Torbjörn.Grön_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Torbjörn.Plommon_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Torbjörn.Cathode_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Torbjörn.Woodclad_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Torbjörn.Tre_Kronor_SK;//Summer 16
                btn16.BackColor = Color.Gold; btn16.Text = Torbjörn.Magni_SK;//Legendary
                btn08.BackColor = Color.Gold; btn08.Text = Torbjörn.Chopper_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Torbjörn.Deadlock_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Torbjörn.Barbarossa_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Torbjörn.Blackbeard_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Torbjörn.Viking_SK;//Halloween 17
                btn13.BackColor = Color.Gold; btn13.Text = Torbjörn.Santaclad_SK;//Winter 16
                btn14.BackColor = Color.Gold; btn14.Text = Torbjörn.Chief_Engineer_Lindholm_SK;//Uprising 17
                btn15.BackColor = Color.Gold; btn15.Text = Torbjörn.Ironclad_SK;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Halloween + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Torbjörn.Clicking_heels_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Torbjörn.Fisticuffs_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Torbjörn.Guffaw_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Torbjörn.Overload_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Torbjörn.Taking_a_break_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Torbjörn.Batter_Up_EM;//Halloween 17
                btn07.BackColor = Color.DarkViolet; btn07.Text = Torbjörn.Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2016");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB06, Lang.Winter + " 2016");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Torbjörn.Hammer_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Torbjörn.Sitting_pretty_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Torbjörn.Take_Five_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Torbjörn.Medal_VP;//Summer 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Torbjörn.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Torbjörn.Toast_VP;//Winter 16

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Tracer_Click(object sender, EventArgs e)
        {
            Heroe = "Tracer";
            btnHeroeinvisible(Heroe, 17, 6, 6);
            gbAll.Text = Tracer.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnTracer()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Rooster + " 2017");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5); chB12.Text = "(" + Lang.OriginGotY + ")"; HeroTT.SetToolTip(chB12, Lang.OriginGotY2);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6); chB13.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB13, Lang.Summer + " 2016");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7); chB14.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB14, Lang.Summer + " 2016");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p8); chB15.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB15, Lang.Winter + " 2016");
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p9); chB16.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB16, Lang.Uprising + " 2017");
                chB17.Visible = true; chB17.Location = new Point(gBAllWeited4p3, p10); chB17.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB17, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p6 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p7 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p8 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB16.Width, p9 - 5);
                btn17.Visible = true; btn17.Location = new Point(gBAllWeited4p3 + chB17.Width, p10 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Tracer.Electric_Purple_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Tracer.Hot_Pink_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Tracer.Neon_Green_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Tracer.Royal_Blue_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Tracer.Posh_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Tracer.Sporty_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Tracer.Rose_SK;//Rooster 17
                btn08.BackColor = Color.Gold; btn08.Text = Tracer.Punk_SK;//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = Tracer.Ultraviolet_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Tracer.Mach_T_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Tracer.T_Racer_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Tracer.Slipstream_SK;//Origin
                btn13.BackColor = Color.Gold; btn13.Text = Tracer.Sprinter_SK;//Summer 16
                btn14.BackColor = Color.Gold; btn14.Text = Tracer.Track_and_Field_SK;//Summer 16
                btn15.BackColor = Color.Gold; btn15.Text = Tracer.Jingle_SK;//Winter 16
                btn16.BackColor = Color.Gold; btn16.Text = Tracer.Cadet_Oxton_SK;//Uprising 17
                btn17.BackColor = Color.Gold; btn17.Text = Tracer.Graffiti_SK;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
                chB17.Checked = Convert.ToBoolean(inisHeroes.Read("SK17"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p1, p2); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, "Epic");
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p3); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p4); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p2, p1); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p1 + chB07.Width, p2 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p3 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p4 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p2 + chB03.Width, p1 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p2 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn07.BackColor = Color.DarkViolet; btn07.Text = Tracer.Bomb_Spin_EM;//Epic
                btn01.BackColor = Color.DarkViolet; btn01.Text = Tracer.Cheer_EM;
                btn02.BackColor = Color.DarkViolet; btn02.Text = Tracer.Finger_guns_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Tracer.Having_a_laugh_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Tracer.Sitting_arround_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Tracer.Spin_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Tracer.Charleston_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = " (" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2017");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = " (" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2017");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB06, Lang.Halloween + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = " (" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Halloween + " 2018");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Tracer.Over_the_shoulder_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Tracer.Salute_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Tracer.Sitting_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Tracer.Medal_VP;//Summer 17
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Tracer.Pumpkin_VP;//Halloween 17
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Tracer.RIP_VP;//Halloween 16
                btn07.BackColor = Color.DeepSkyBlue; btn07.Text = Tracer.Fireworks_VP;//Halloween 16

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VP07"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Widowmaker_Click(object sender, EventArgs e)
        {
            Heroe = "Widowmaker";
            btnHeroeinvisible(Heroe, 14, 6, 5);
            gbAll.Text = Widowmaker.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnWidowmaker()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, " 2016");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p1); chB15.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB15, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p5); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p6); chB12.Text = "(" + Lang.Prepurchase + ")"; HeroTT.SetToolTip(chB12, Lang.Prepurchase2);
                chB17.Visible = true; chB17.Location = new Point(gBAllWeited4p3, p7); chB17.Text = "(" + Lang.Prepurchase + ")"; HeroTT.SetToolTip(chB17, Lang.Prepurchase2);
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p8); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Summer + " 2017");
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p9); chB16.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB16, Lang.Dog + " 2018");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p10); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p1 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p2 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p3 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p4 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p5 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p6 - 5);
                btn17.Visible = true; btn17.Location = new Point(gBAllWeited4p3 + chB17.Width, p7 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p8 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB16.Width, p9 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p10 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Widowmaker.Ciel_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Widowmaker.Nuit_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Widowmaker.Rose_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Widowmaker.Vert_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Widowmaker.Patina_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Widowmaker.Winter_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Widowmaker.Tricolore_SK;//Summer 16
                btn15.BackColor = Color.Gold; btn15.Text = Widowmaker.Nova_SK;//Legendary
                btn08.BackColor = Color.Gold; btn08.Text = Widowmaker.Odette_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Widowmaker.Odile_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Widowmaker.Comtesse_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Widowmaker.Huntress_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Widowmaker.Noire_SK;//Prepurchase
                btn17.BackColor = Color.Gold; btn17.Text = Widowmaker.Kerrigan_SK;//Sarcraft 20th Annyver
                btn13.BackColor = Color.Gold; btn13.Text = Widowmaker.Côte_DAzur_SK;//Summer 17
                btn16.BackColor = Color.Gold; btn16.Text = Widowmaker.Black_Lily_SK;//Lunar 18
                btn14.BackColor = Color.Gold; btn14.Text = Widowmaker.Talon_SK;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
                chB17.Checked = Convert.ToBoolean(inisHeroes.Read("SK17"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Widowmaker.A_rest_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Widowmaker.Curtain_Call_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Widowmaker.Delighted_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Widowmaker.Shot_Dead_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Widowmaker.Widows_Kiss_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Widowmaker.Ballet_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, Lang.Summer + " 2016");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB01, Lang.Winter + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB01, Lang.Dog + " 2018");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Widowmaker.Activating_Visor_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Widowmaker.Gaze_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Widowmaker.Over_the_shoulder_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Widowmaker.Medal_VP;//Summer 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Widowmaker.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Widowmaker.Toast_VP;//Winter 17
                btn07.BackColor = Color.DeepSkyBlue; btn07.Text = Widowmaker.Fans_VP;//Winter 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VP07"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Winston_Click(object sender, EventArgs e)
        {
            Heroe = "Winston";
            btnHeroeinvisible(Heroe, 13, 7, 6);
            gbAll.Text = Winston.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnWinston()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                Lang.BlizzCon2 = "2017";
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Lang.BlizzCon + ")"; HeroTT.SetToolTip(chB07, Lang.BlizzCon2);
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, Lang.Winter + " 2016");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6); chB13.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB13, Lang.Rooster + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p6 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Winston.Atmosphere_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Winston.Banana_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Winston.Forest_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Winston.Red_Planet_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Winston.Desert_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Winston.Horizon_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Winston.Blizzcon_2017_SK;//BlizzCon 17
                btn08.BackColor = Color.Gold; btn08.Text = Winston.Frogston_SK;//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = Winston.Undersea_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Winston.Explorer_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Winston.Safari_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Winston.Yeti_SK;//Winter 16
                btn13.BackColor = Color.Gold; btn13.Text = Winston.Wukong_SK;//Rooster 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, Lang.Halloween + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Winston.Laugh_matter_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Winston.Monkey_Buisness_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Winston.Peanut_Butter_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Winston.Roar_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Winston.Sitting_around_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Winston.Shadow_Puppets_EM;//Halloween 16
                btn07.BackColor = Color.DarkViolet; btn07.Text = Winston.Twist_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2016");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Dog + " 2018");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p4); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Winston.Beast_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Winston.Glasses_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Winston.The_Thinker_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Winston.Medal_VP;//Summer 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Winston.RIP_VP;//Halloween 16
                btn07.BackColor = Color.DeepSkyBlue; btn07.Text = Winston.Sparklers_VP;//Lunar 18
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Winston.Peanut_Butter_VP;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VP07"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void WreckingBall_Click(object sender, EventArgs e)
        {
            Heroe = "WreckingBall";
            btnHeroeinvisible(Heroe, 10, 5, 4);
            gbAll.Text = WreckingBall.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnWreckingBall()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p3, p1); chB07.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB07, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p3 + chB07.Width, p1 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p2 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p3 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = WreckingBall.CHLORIDE_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = WreckingBall.LITHIUM_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = WreckingBall.POTASSIUM_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = WreckingBall.SMOKE_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = WreckingBall.BIOHAZZARD_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = WreckingBall.WOODEN_BALL_SK;
                btn07.BackColor = Color.Gold; btn07.Text = WreckingBall.HORIZON_SK;//Legendary
                btn08.BackColor = Color.Gold; btn08.Text = WreckingBall.LUNAR_SK;
                btn09.BackColor = Color.Gold; btn09.Text = WreckingBall.JUNKER_SK;
                btn10.BackColor = Color.Gold; btn10.Text = WreckingBall.MAYHEM_SK;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p2, p1); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p2); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p3); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p2 + chB03.Width, p1 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p2 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = WreckingBall.CHEER_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = WreckingBall.LAUGH_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = WreckingBall.LOUNGE_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = WreckingBall.REPAIRS_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = WreckingBall.SUMO_EM;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p2, p1); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p2); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p2 + chB03.Width, p1 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p2 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = WreckingBall.LOUNGING_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = WreckingBall.ON_TOP_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = WreckingBall.PEACE_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = WreckingBall.SWING_VP;

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Zarya_Click(object sender, EventArgs e)
        {
            Heroe = "Zarya";
            btnHeroeinvisible(Heroe, 15, 7, 5);
            gbAll.Text = Zarya.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnZarya()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Winter + " 2016");
                chB16.Visible = true; chB16.Location = new Point(gBAllWeited4p3, p1); chB16.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB16, "Legendary");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p2); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p3); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p4); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p5); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p6); chB12.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB12, Lang.Summer + " 2016");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p7); chB13.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB13, Lang.Summer + " 2016");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p8); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Halloween + " 2017");
                chB17.Visible = true; chB17.Location = new Point(gBAllWeited4p3, p9); chB17.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB17, Lang.Dog + " 2018");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p3, p10); chB15.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB15, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
                btn16.Visible = true; btn16.Location = new Point(gBAllWeited4p3 + chB16.Width, p1 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p2 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p3 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p4 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p5 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p6 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p7 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p8 - 5);
                btn17.Visible = true; btn17.Location = new Point(gBAllWeited4p3 + chB17.Width, p9 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p3 + chB15.Width, p10 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Zarya.Brick_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Zarya.Goldenrod_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Zarya.Taiga_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Zarya.Violet_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Zarya.Dawn_SK;//Epic
                btn06.BackColor = Color.DarkViolet; btn06.Text = Zarya.Midnight_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Zarya.Frosted_SK;//Winter 16
                btn16.BackColor = Color.Gold; btn16.Text = Zarya.Barbarian_SK;//Legendary
                btn08.BackColor = Color.Gold; btn08.Text = Zarya.Arctic_SK;
                btn09.BackColor = Color.Gold; btn09.Text = Zarya.Siberian_Front_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Zarya.Cybergoth_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Zarya.Industrial_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Zarya.Champion_SK;//Summer 16
                btn13.BackColor = Color.Gold; btn13.Text = Zarya.Weightlifter_SK;//Summer 16
                btn14.BackColor = Color.Gold; btn14.Text = Zarya.Totally_80s_SK;//Halloween 17
                btn17.BackColor = Color.Gold; btn17.Text = Zarya.Xuanwu_SK;//Lunar 18
                btn15.BackColor = Color.Gold; btn15.Text = Zarya.Cyberian_SK;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
                chB16.Checked = Convert.ToBoolean(inisHeroes.Read("SK16"));
                chB17.Checked = Convert.ToBoolean(inisHeroes.Read("SK17"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Annyver + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p4); chB07.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB07, "Legendary" + Lang.Winter + " 2016");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Zarya.Bring_it_on_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Zarya.Comedy_Gold_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Zarya.Chush_you_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Zarya.Pumping_Iron_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Zarya.Take_a_knee_EM;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Zarya.Dance_EM;//Annyver 17
                btn07.BackColor = Color.Gold; btn07.Text = Zarya.Mystery_Gift_EM;//Legendary //Winter 16

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Winter + " 2017");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Dog + " 2018");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p4); chB06.Text = "(" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB05, Lang.Uprising + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Zarya.Casual_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Zarya.Check_out_this_gun_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Zarya.Flexing_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Zarya.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Zarya.Toast_VP;//Winter 17
                btn07.BackColor = Color.DeepSkyBlue; btn07.Text = Zarya.Big_one_VP;//Uprising 17
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Zarya.This_is_strength_VP;//Uprising 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("VP07"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }

        private void Zenyatta_Click(object sender, EventArgs e)
        {
            Heroe = "Zenyatta";
            btnHeroeinvisible(Heroe, 14, 6, 5);
            gbAll.Text = Zenyatta.GetName();
            BackSave = gbAll.Text;
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");

            chBSave = 0;
            chB01.Text = Lang.GoldWeapon; chB01.Visible = true;
            chB01.Location = new Point(gBAllWeited4p1, p2);
            chB01.Checked = Convert.ToBoolean(inisHeroes.Read("GW01"));
            chBSave = 1;
        }

        private void btnZenyatta()
        {
            inisHeroes = new IniStream(MyDocuments + "\\" + Heroe + ".ini");
            chBSave = 0;

            //Anzeigen, Auslesen und anwenden der chB
            if (BackSave2 == Lang.Skins)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited4p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p2); chB01.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p3); chB02.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p4); chB03.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p5); chB04.Text = "(" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, "Rare");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB15.Visible = true; chB15.Location = new Point(gBAllWeited4p2, p2); chB15.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB15, "Epic");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p3); chB06.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB06, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p4); chB07.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB07, Lang.Halloween + " 2016");
                chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p3, p1); chB08.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB08, "Legendary");
                chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p2); chB09.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB09, "Legendary");
                chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p3); chB10.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB10, "Legendary");
                chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p4); chB11.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB11, "Legendary");
                chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p5); chB12.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB12, Lang.Halloween + " 2017");
                chB13.Visible = true; chB13.Location = new Point(gBAllWeited4p3, p6); chB13.Text = "(" + Cost.Legendary + ")"; HeroTT.SetToolTip(chB13, Lang.Winter + " 2016");
                chB14.Visible = true; chB14.Location = new Point(gBAllWeited4p3, p7); chB14.Text = "(" + Cost.LegendaryEvent + ")"; HeroTT.SetToolTip(chB14, Lang.Rooster + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited4p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p5 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
                btn15.Visible = true; btn15.Location = new Point(gBAllWeited4p2 + chB15.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p3 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p4 - 5);
                btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p3 + chB08.Width, p1 - 5);
                btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p2 - 5);
                btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p3 - 5);
                btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p4 - 5);
                btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p5 - 5);
                btn13.Visible = true; btn13.Location = new Point(gBAllWeited4p3 + chB13.Width, p6 - 5);
                btn14.Visible = true; btn14.Location = new Point(gBAllWeited4p3 + chB14.Width, p7 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Classic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Zenyatta.Air_SK;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Zenyatta.Earth_SK;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Zenyatta.Leaf_SK;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Zenyatta.Water_SK;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Zenyatta.Ascendant_SK;//Epic
                btn15.BackColor = Color.DarkViolet; btn15.Text = Zenyatta.Carbon_Fiber_SK;
                btn06.BackColor = Color.DarkViolet; btn06.Text = Zenyatta.Harmonious_SK;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Zenyatta.Skullyatta_SK;//Halloween 16
                btn08.BackColor = Color.Gold; btn08.Text = Zenyatta.Djinnyatta_SK;//Legendary
                btn09.BackColor = Color.Gold; btn09.Text = Zenyatta.Ifrit_SK;
                btn10.BackColor = Color.Gold; btn10.Text = Zenyatta.Ra_SK;
                btn11.BackColor = Color.Gold; btn11.Text = Zenyatta.Sunyatta_SK;
                btn12.BackColor = Color.Gold; btn12.Text = Zenyatta.Cultist_SK;//Halloween 17
                btn13.BackColor = Color.Gold; btn13.Text = Zenyatta.Nutcracker_SK;//Winter 16
                btn14.BackColor = Color.Gold; btn14.Text = Zenyatta.Sanzang_SK;//Rooser 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("SK01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("SK02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("SK03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("SK04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("SK05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("SK06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("SK07"));
                chB08.Checked = Convert.ToBoolean(inisHeroes.Read("SK08"));
                chB09.Checked = Convert.ToBoolean(inisHeroes.Read("SK09"));
                chB10.Checked = Convert.ToBoolean(inisHeroes.Read("SK10"));
                chB11.Checked = Convert.ToBoolean(inisHeroes.Read("SK11"));
                chB12.Checked = Convert.ToBoolean(inisHeroes.Read("SK12"));
                chB13.Checked = Convert.ToBoolean(inisHeroes.Read("SK13"));
                chB14.Checked = Convert.ToBoolean(inisHeroes.Read("SK14"));
                chB15.Checked = Convert.ToBoolean(inisHeroes.Read("SK15"));
            }
            if (BackSave2 == Lang.Emotes)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB01, "Epic");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB02, "Epic");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB03, "Epic");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB04, "Epic");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = "(" + Cost.Epic + ")"; HeroTT.SetToolTip(chB05, "Epic");
                chB07.Visible = true; chB07.Location = new Point(gBAllWeited3p2, p3); chB07.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB07, Lang.Winter + " 2017");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p4); chB06.Text = "(" + Cost.EpicEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Annyver + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn07.Visible = true; btn07.Location = new Point(gBAllWeited3p2 + chB07.Width, p3 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p4 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DarkViolet; btn01.Text = Zenyatta.Focusing_EM;//Epic
                btn02.BackColor = Color.DarkViolet; btn02.Text = Zenyatta.Meditate_EM;
                btn03.BackColor = Color.DarkViolet; btn03.Text = Zenyatta.Round_of_Applause_EM;
                btn04.BackColor = Color.DarkViolet; btn04.Text = Zenyatta.Taunt_EM;
                btn05.BackColor = Color.DarkViolet; btn05.Text = Zenyatta.Tickled_EM;
                btn07.BackColor = Color.DarkViolet; btn07.Text = Zenyatta.Snowflake_EM;//Winter 17
                btn06.BackColor = Color.DarkViolet; btn06.Text = Zenyatta.Dance_EM;//Annyver 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("EM01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("EM02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("EM03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("EM04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("EM05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("EM06"));
                chB07.Checked = Convert.ToBoolean(inisHeroes.Read("EM07"));
            }
            if (BackSave2 == Lang.VictoryPoses)
            {
                chB00.Visible = true; chB00.Location = new Point(gBAllWeited3p1, p1); chB00.Text = "(" + Cost.Classic + ")";
                chB01.Visible = true; chB01.Location = new Point(gBAllWeited3p1, p2); chB01.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB01, "Rare");
                chB02.Visible = true; chB02.Location = new Point(gBAllWeited3p1, p3); chB02.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB02, "Rare");
                chB03.Visible = true; chB03.Location = new Point(gBAllWeited3p1, p4); chB03.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB03, "Rare");
                chB04.Visible = true; chB04.Location = new Point(gBAllWeited3p2, p1); chB04.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB04, Lang.Summer + " 2016");
                chB05.Visible = true; chB05.Location = new Point(gBAllWeited3p2, p2); chB05.Text = " (" + Cost.Rare + ")"; HeroTT.SetToolTip(chB05, Lang.Halloween + " 2016");
                chB06.Visible = true; chB06.Location = new Point(gBAllWeited3p2, p3); chB06.Text = " (" + Cost.RareEvent + ")"; HeroTT.SetToolTip(chB06, Lang.Winter + " 2017");

                btn00.Visible = true; btn00.Location = new Point(gBAllWeited3p1 + chB00.Width, p1 - 5);
                btn01.Visible = true; btn01.Location = new Point(gBAllWeited3p1 + chB01.Width, p2 - 5);
                btn02.Visible = true; btn02.Location = new Point(gBAllWeited3p1 + chB02.Width, p3 - 5);
                btn03.Visible = true; btn03.Location = new Point(gBAllWeited3p1 + chB03.Width, p4 - 5);
                btn04.Visible = true; btn04.Location = new Point(gBAllWeited3p2 + chB04.Width, p1 - 5);
                btn05.Visible = true; btn05.Location = new Point(gBAllWeited3p2 + chB05.Width, p2 - 5);
                btn06.Visible = true; btn06.Location = new Point(gBAllWeited3p2 + chB06.Width, p3 - 5);

                btn00.BackColor = Color.Gainsboro; btn00.Text = Lang.Heroic;//Default
                btn01.BackColor = Color.DeepSkyBlue; btn01.Text = Zenyatta.Balance_VP;//Rare
                btn02.BackColor = Color.DeepSkyBlue; btn02.Text = Zenyatta.Harmony_VP;
                btn03.BackColor = Color.DeepSkyBlue; btn03.Text = Zenyatta.Peace_VP;
                btn04.BackColor = Color.DeepSkyBlue; btn04.Text = Zenyatta.Medals_VP;//Summer 16
                btn05.BackColor = Color.DeepSkyBlue; btn05.Text = Zenyatta.RIP_VP;//Halloween 16
                btn06.BackColor = Color.DeepSkyBlue; btn06.Text = Zenyatta.Toast_VP;//Winter 17

                chB00.Checked = true;
                chB01.Checked = Convert.ToBoolean(inisHeroes.Read("VP01"));
                chB02.Checked = Convert.ToBoolean(inisHeroes.Read("VP02"));
                chB03.Checked = Convert.ToBoolean(inisHeroes.Read("VP03"));
                chB04.Checked = Convert.ToBoolean(inisHeroes.Read("VP04"));
                chB05.Checked = Convert.ToBoolean(inisHeroes.Read("VP05"));
                chB06.Checked = Convert.ToBoolean(inisHeroes.Read("VP06"));
            }
            if (BackSave2 == Lang.OWLeague)
            {
                OWLButtons();
            }
            chBSave = 1;
        }
        //
        #endregion

        private void OWLButtons()
        {
            chB01.Visible = true; chB01.Location = new Point(gBAllWeited4p1, p1); chB01.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB01, "Overwatch League Token");
            chB02.Visible = true; chB02.Location = new Point(gBAllWeited4p1, p2); chB02.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB02, "Overwatch League Token");
            chB03.Visible = true; chB03.Location = new Point(gBAllWeited4p1, p3); chB03.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB03, "Overwatch League Token");
            chB04.Visible = true; chB04.Location = new Point(gBAllWeited4p1, p4); chB04.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB04, "Overwatch League Token");
            chB05.Visible = true; chB05.Location = new Point(gBAllWeited4p2, p1); chB05.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB05, "Overwatch League Token");
            chB06.Visible = true; chB06.Location = new Point(gBAllWeited4p2, p2); chB06.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB06, "Overwatch League Token");
            chB07.Visible = true; chB07.Location = new Point(gBAllWeited4p2, p3); chB07.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB07, "Overwatch League Token");
            chB08.Visible = true; chB08.Location = new Point(gBAllWeited4p2, p4); chB08.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB08, "Overwatch League Token");
            chB09.Visible = true; chB09.Location = new Point(gBAllWeited4p3, p1); chB09.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB09, "Overwatch League Token");
            chB10.Visible = true; chB10.Location = new Point(gBAllWeited4p3, p2); chB10.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB10, "Overwatch League Token");
            chB11.Visible = true; chB11.Location = new Point(gBAllWeited4p3, p3); chB11.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB11, "Overwatch League Token");
            chB12.Visible = true; chB12.Location = new Point(gBAllWeited4p3, p4); chB12.Text = "(" + Cost.CostsOWLSkin + ")"; HeroTT.SetToolTip(chB12, "Overwatch League Token");

            btn01.Visible = true; btn01.Location = new Point(gBAllWeited4p1 + chB01.Width, p1 - 5);
            btn02.Visible = true; btn02.Location = new Point(gBAllWeited4p1 + chB02.Width, p2 - 5);
            btn03.Visible = true; btn03.Location = new Point(gBAllWeited4p1 + chB03.Width, p3 - 5);
            btn04.Visible = true; btn04.Location = new Point(gBAllWeited4p1 + chB04.Width, p4 - 5);
            btn05.Visible = true; btn05.Location = new Point(gBAllWeited4p2 + chB05.Width, p1 - 5);
            btn06.Visible = true; btn06.Location = new Point(gBAllWeited4p2 + chB06.Width, p2 - 5);
            btn07.Visible = true; btn07.Location = new Point(gBAllWeited4p2 + chB07.Width, p3 - 5);
            btn08.Visible = true; btn08.Location = new Point(gBAllWeited4p2 + chB08.Width, p4 - 5);
            btn09.Visible = true; btn09.Location = new Point(gBAllWeited4p3 + chB09.Width, p1 - 5);
            btn10.Visible = true; btn10.Location = new Point(gBAllWeited4p3 + chB10.Width, p2 - 5);
            btn11.Visible = true; btn11.Location = new Point(gBAllWeited4p3 + chB11.Width, p3 - 5);
            btn12.Visible = true; btn12.Location = new Point(gBAllWeited4p3 + chB12.Width, p4 - 5);

            btn01.BackColor = Color.DarkViolet; btn01.Text = Lang.OWL_Boston_Uprising;
            btn02.BackColor = Color.DarkViolet; btn02.Text = Lang.OWL_Dallas_Fuel;
            btn03.BackColor = Color.DarkViolet; btn03.Text = Lang.OWL_Florida_Mayhem;
            btn04.BackColor = Color.DarkViolet; btn04.Text = Lang.OWL_Houston_Outlaws;
            btn05.BackColor = Color.DarkViolet; btn05.Text = Lang.OWL_London_Spitfire;
            btn06.BackColor = Color.DarkViolet; btn06.Text = Lang.OWL_Los_Angeles_Gladiators;
            btn07.BackColor = Color.DarkViolet; btn07.Text = Lang.OWL_Los_Angeles_Valiant;
            btn08.BackColor = Color.DarkViolet; btn08.Text = Lang.OWL_New_York_Excelsior;
            btn09.BackColor = Color.DarkViolet; btn09.Text = Lang.OWL_Philadelphia_Fusion;
            btn10.BackColor = Color.DarkViolet; btn10.Text = Lang.OWL_San_Francisco_Shock;
            btn11.BackColor = Color.DarkViolet; btn11.Text = Lang.OWL_Seoul_Dynasty;
            btn12.BackColor = Color.DarkViolet; btn12.Text = Lang.OWL_Shanghai_Dragons;

            chB01.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_Boston_Uprising));
            chB02.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_Dallas_Fuel));
            chB03.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_Florida_Mayhem));
            chB04.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_Houston_Outlaws));
            chB05.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_London_Spitfire));
            chB06.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_Los_Angeles_Gladiators));
            chB07.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_Los_Angeles_Valiant));
            chB08.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_New_York_Excelsior));
            chB09.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_Philadelphia_Fusion));
            chB10.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_San_Francisco_Shock));
            chB11.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_Seoul_Dynasty));
            chB12.Checked = Convert.ToBoolean(inisHeroes.Read(Lang.OWL_Shanghai_Dragons));
        }

        #region Checkboxen
        private void chB00_CheckedChanged(object sender, EventArgs e)
        {
            if (chBSave == 1 && BackSave2 != Lang.OWLeague)
                MessageBox.Show("Something went wrong.\nPlease create an Issue on Github with the Title 'Error 0' and\n describe, what you have done.", "Error 0", MessageBoxButtons.OK, MessageBoxIcon.Error);/*
            */
            if (chBSave == 1 && BackSave2 == Lang.OWLeague)
                chBChange(btn00.Text, chB00.Checked);/*
            */
            else
                MessageBox.Show("Something went wrong.\nPlease create an Issue on Github with the Title 'Error 0B' and\n describe, what you have done.", "Error 0B", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void chB01_CheckedChanged(object sender, EventArgs e)
        {
            if (chB01.Text == Lang.GoldWeapon)
                chBChange(chB01.Text, chB01.Checked);
            else
                chBChange(btn01.Text, chB01.Checked);
        }

        private void chB02_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn02.Text, chB02.Checked);
        }

        private void chB03_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn03.Text, chB03.Checked);
        }

        private void chB04_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn04.Text, chB04.Checked);
        }

        private void chB05_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn05.Text, chB05.Checked);
        }

        private void chB06_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn06.Text, chB06.Checked);
        }

        private void chB07_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn07.Text, chB07.Checked);
        }

        private void chB08_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn08.Text, chB08.Checked);
        }

        private void chB09_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn09.Text, chB09.Checked);
        }

        private void chB10_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn10.Text, chB10.Checked);
        }

        private void chB11_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn11.Text, chB11.Checked);
        }

        private void chB12_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn12.Text, chB12.Checked);
        }

        private void chB13_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn13.Text, chB13.Checked);
        }

        private void chB14_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn14.Text, chB14.Checked);
        }

        private void chB15_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn15.Text, chB15.Checked);
        }

        private void chB16_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn16.Text, chB16.Checked);
        }

        private void chB17_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn17.Text, chB17.Checked);
        }

        private void chB18_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn18.Text, chB18.Checked);
        }

        private void chB19_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn19.Text, chB19.Checked);
        }

        private void chB20_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn20.Text, chB20.Checked);
        }

        private void chB21_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn21.Text, chB21.Checked);
        }

        private void chB22_CheckedChanged(object sender, EventArgs e)
        {
            chBChange(btn22.Text, chB22.Checked);
        }

        private void chB23_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn23.Text, chB23.Checked);
        }

        private void chB24_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn24.Text, chB24.Checked);
        }

        private void chB25_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn25.Text, chB25.Checked);
        }

        private void chB26_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn26.Text, chB26.Checked);
        }

        private void chB27_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn27.Text, chB27.Checked);
        }

        private void chB28_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn28.Text, chB28.Checked);
        }

        private void chB29_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn29.Text, chB29.Checked);
        }

        private void chB30_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn30.Text, chB30.Checked);
        }

        private void chB31_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn31.Text, chB31.Checked);
        }

        private void chB32_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn32.Text, chB32.Checked);
        }

        private void chB33_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn33.Text, chB33.Checked);
        }

        private void chB34_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn34.Text, chB34.Checked);
        }

        private void chB35_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn35.Text, chB35.Checked);
        }

        private void chB36_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn36.Text, chB36.Checked);
        }

        private void chB37_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn37.Text, chB37.Checked);
        }

        private void chB38_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn38.Text, chB38.Checked);
        }

        private void chB39_CheckedChanged(object sender, EventArgs e)
        {
            //chBChange(btn39.Text, chB39.Checked);
        }

        #endregion

        #region Buttons
        private void btn00_Click(object sender, EventArgs e)
        {
            ImageChange(0);
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            ImageChange(1);
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            ImageChange(2);
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            ImageChange(3);
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            ImageChange(4);
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            ImageChange(5);
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            ImageChange(6);
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            ImageChange(7);
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            ImageChange(8);
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            ImageChange(9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            ImageChange(10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            ImageChange(11);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            ImageChange(12);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            ImageChange(13);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            ImageChange(14);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            ImageChange(15);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            ImageChange(16);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            ImageChange(17);
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            ImageChange(18);
        }
        private void btn19_Click(object sender, EventArgs e)
        {
            ImageChange(19);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            ImageChange(20);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            ImageChange(21);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            ImageChange(22);
        }


        #endregion

        private void ImageChange(int buttonnumber)
        {
            if (BackSave2 == Lang.Skins || BackSave2 == Lang.Emotes || BackSave2 == Lang.VictoryPoses || BackSave2 == Lang.Sprays || BackSave2 == Lang.HighlightIntros || BackSave2 == Lang.OWLeague)
            {
                bool rtrn = ItemImage.ChangeImage(Heroe, BackSave2, buttonnumber);

                if (rtrn == true)
                {//If Image was set
                    ItemImage.Location = new Point((this.Width / 2) - (ItemImage.Width / 2) - 8, (this.Height / 2) - (ItemImage.Height / 2) - 19);
                    ItemImage.Visible = true;
                    lblCloseImage.Visible = true;
                    lblCloseImage.Location = ItemImage.Location;
                    lblCloseImage.Text = "Close Image by clicking on it";
                    ItemImage.BringToFront();
                    lblCloseImage.BringToFront();
                    ImageChangeHintergrundButtons(false);
                }
            }
            if (BackSave2 == Lang.VoiceLines)
            {
                try
                {
                    MediaPlayer.Dispose();
                }
                catch { }
                MediaPlayer = new CMediaPlayer("Sounds\\Voice Lines\\" + BackSave + "\\" + /*Language*/"EN" + "\\" + buttonnumber + ".mp3");
                MediaPlayer.Play();
                if (MediaPlayer == null)
                    MessageBox.Show("An Error has appeared!\nPlease Post this Issue on GitHub with the Error Code\nError Code: 3", "Error 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chBChange(string ItemName, bool Checkbox)
        {
            //Speichern
            if (chBSave == 1)
            {
                if (BackSave2 == Lang.Skins && chB01.Text != Lang.GoldWeapon)
                {
                    inisHeroes.Write(ItemName, Checkbox.ToString());
                }
                if (BackSave2 == Lang.Emotes && chB01.Text != Lang.GoldWeapon)
                {
                    inisHeroes.Write(ItemName, Checkbox.ToString());
                }
                if (BackSave2 == Lang.VictoryPoses && chB01.Text != Lang.GoldWeapon)
                {
                    inisHeroes.Write(ItemName, Checkbox.ToString());
                }/*
                if (BackSave2 == Lang.VoiceLines && chB01.Text != Lang.GoldWeapon)
                {
                    inisHeroes.Write(Nummer, Checkbox.ToString());
                }
                if (BackSave2 == Lang.Sprays && chB01.Text != Lang.GoldWeapon)
                {
                    inisHeroes.Write(Nummer, Checkbox.ToString());
                }
                if (BackSave2 == Lang.HighlightIntros && chB01.Text != Lang.GoldWeapon)
                {
                    inisHeroes.Write(Nummer, Checkbox.ToString() && chB01.Text != Lang.GoldWeapon);
                }
                if (BackSave2 == Lang.PlayerIcons && Heroe != "PI" && chB01.Text != Lang.GoldWeapon)
                {
                    inisHeroes.Write(Nummer, Checkbox.ToString());
                }
                if (BackSave2 == Lang.PlayerIcons && Heroe == "PI" && chB01.Text != Lang.GoldWeapon)
                {
                    inisPI.Write(Nummer, Checkbox.ToString());
                }*/
                if (BackSave2 == Lang.OWLeague && chB01.Text != Lang.GoldWeapon)
                {
                    inisHeroes.Write(ItemName, Checkbox.ToString());
                }
                if (chB01.Text == Lang.GoldWeapon)
                {
                    inisHeroes.Write(ItemName, Checkbox.ToString());
                }

                TextRemaining(Heroe);
            }
        }

        private void ImageChangeHintergrundButtons(bool b)
        {
            btnBackHero.Visible = b;
            btnSettings.Visible = b;
            gbAll.Visible = b;
            lblKosten.Visible = b;
        }
    }
}
