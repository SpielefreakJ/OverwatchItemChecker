using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker
{
    class CHeroImage : PictureBox
    {
        string myHero = "D.Va", myCategory = "Overwatch League"; int myItemname = 4;
        Translate.L_Translate Translate;

        public CHeroImage(string Lang)
        {
            SizeMode = PictureBoxSizeMode.AutoSize;

            Image = Image.FromFile("Images\\Items\\" + myHero + "\\" + myCategory + "\\" + myItemname + ".png");

            Translate = new Translate.L_Translate(Lang);
        }

        public bool ChangeImage(string Hero, string Category, int Itemname)
        {
            try
            {
                myHero = Hero; myItemname = Itemname;
                //myCategory = Category; 

                #region LangÜberprüfung

                if (Category == Translate.Skins)
                {
                    myCategory = "Skins";
                }
                if (Category == Translate.Emotes)
                {
                    myCategory = "Emotes";
                }
                if (Category == Translate.VictoryPoses)
                {
                    myCategory = "Victory Poses";
                }
                if (Category == Translate.Sprays)
                {
                    myCategory = "Sprays";
                }
                if (Category == Translate.HighlightIntros)
                {
                    myCategory = "Highlight Intros";
                }
                if (Category == Translate.OWLeague)
                {
                    myCategory = "Overwatch League";
                }

                #endregion

                Image = Image.FromFile("Images\\Items\\" + myHero + "\\" + myCategory + "\\" + myItemname + ".png");

                return true;
            }
            catch
            {
                //MessageBox.Show("An Error has appeared!\nPlease Post this Issue on GitHub with the Error Code\nError Code: 2", "Error 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("An Error has appeared!\nThere's probably no Image right now. Sorry for that.\nError Code: 2", "Error 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Image SetImage
        {
            get
            {
                return Image;
            }
            set
            {
                Image = value;
            }
        }

        public string ChangeLang
        {
            get
            {
                return Translate.ChangeLang;
            }
            set
            {
                Translate.ChangeLang = value;
            }
        }
    }
}
