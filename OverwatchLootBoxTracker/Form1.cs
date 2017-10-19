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
        CGoldweapon GoldWeapon;
        CLang Lang;
        string Language;

        public Form1()
        {
            InitializeComponent();
            KlassenInst();

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
            try
            {
                //Speichern der änderrung unter "Color" in der Settings.ini
                inisSettings.Write("Lang", Language);
            }
            catch
            {
                Language = "DE";
                //Speichern der änderrung unter "Color" in der Settings.ini
                inisSettings.Write("Lang", Language);
            }
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
            GoldWeapon = new CGoldweapon();
            Lang = new CLang(Language);
        }

        private void Texte()
        {
            //Erste mal ausrechnen, wieviel alles zusammen Kostet
            lblKosten.Text = Lang.remaining1 + Cost.KostenNormal + Lang.remaining2 + Cost.KostenNormal + Cost.KostenFest + Lang.remaining3 + GoldWeapon.KostenGes + " SR";

            btnSettings.Text = Lang.Settingsbutton;
            gBLang.Text = Lang.LangChangeBox;
        }


        //Ab hier beginnt der richtige Code


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
        }
    }
}
