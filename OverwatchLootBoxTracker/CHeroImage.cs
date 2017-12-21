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

        public CHeroImage(string Hero)
        {
            SizeMode = PictureBoxSizeMode.AutoSize;

            Image = Image.FromFile("Images\\" + Hero + "_link.png");
        }
    }
}
