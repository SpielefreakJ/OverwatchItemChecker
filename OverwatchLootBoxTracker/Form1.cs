using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverwatchLootBoxTracker
{
    public partial class Form1 : Form
    {
        CSkin Skin; //CEmote Emote; CVictoryPose VictoryPose; CVoiceLine VoiceLine; CSpray Spray; CHighlightIntro HighlightIntro;
        CGoldweapon GoldWeapon;
        //CPlayerIcon PlayerIcon;

        public Form1()
        {
            InitializeComponent();
            KlassenInst();

            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void KlassenInst()
        {
            Skin = new CSkin(); //Emote = new CEmote(); VictoryPose = new CVictoryPose(); VoiceLine = new CVoiceLine(); Spray = new CSpray(); HighlightIntro = new CHighlightIntro();
            GoldWeapon = new CGoldweapon();
            //PlayerIcon = new CPlayerIcon();

            //Erste mal ausrechnen, wieviel alles zusammen Kostet
            lblKosten.Text = "Kosten für Rest: " + Skin.KostenNormal + Skin.KostenFest + " Credits und " + GoldWeapon.KostenGes + " SR";
        }

        //Ab hier beginnt der richtige Code


    }
}
