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
        string myHero = "D.Va", myCategory = "Skins", myItemname = "Carbon Fiber";

        public CHeroImage()
        {
            SizeMode = PictureBoxSizeMode.AutoSize;

            Image = Image.FromFile("Images\\Items\\" + myHero +"\\" + myCategory + "\\" + myItemname + ".png");
        }

        public void ChangeImage(string Hero, string Category, string Itemname)
        {
            myHero = Hero; myCategory = Category; myItemname = Itemname;
            Image = Image.FromFile("Images\\Items\\" + myHero + "\\" + myCategory + "\\" + myItemname + ".png");
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
    }
}
