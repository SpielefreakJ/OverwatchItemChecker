using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Moira : PictureBox
    {
        Languages.English.Heroes.Moira EN;
        Languages.German.Heroes.Moira DE;
        string myLang;

        public L_Moira(string Lang)
        {
            if (Lang != "")
            {
                myLang = Lang;
            }

            EN = new Languages.English.Heroes.Moira();
            DE = new Languages.German.Heroes.Moira();

            SizeMode = PictureBoxSizeMode.AutoSize;
            Image = Image.FromFile("Images\\Moira_link.png");
        }
        public string ChangeLang
        {
            get
            {
                return myLang;
            }
            set
            {
                myLang = value;
            }
        }

        public string GetName()
        {
            if (myLang == "DE")
            {
                return DE.Name;
            }
            else
            {
                return EN.Name;
            }
        }


        //Skin
        //Rare
        public string Fiery_SK//1
        {
            get
            {
                if (myLang=="DE")
                {
                    return DE.Fiery_SK;
                }
                else
                {
                    return EN.Fiery_SK;
                }
            }
        }

        public string Royal_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Royal_SK;
                }
                else
                {
                    return EN.Royal_SK;
                }
            }
        }

        public string Selkie_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Selkie_SK;
                }
                else
                {
                    return EN.Selkie_SK;
                }
            }
        }

        public string Whiskey_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Whiskey_SK;
                }
                else
                {
                    return EN.Whiskey_SK;
                }
            }
        }
        //Epic
        public string Ornate_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ornate_SK;
                }
                else
                {
                    return EN.Ornate_SK;
                }
            }
        }

        public string Pale_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Pale_SK;
                }
                else
                {
                    return EN.Pale_SK;
                }
            }
        }
        //Legendary
        public string Minister_SK//7
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Minister_SK;
                }
                else
                {
                    return EN.Minister_SK;
                }
            }
        }

        public string Oasis_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Oasis_SK;
                }
                else
                {
                    return EN.Oasis_SK;
                }
            }
        }

        public string Glam_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Glam_SK;
                }
                else
                {
                    return EN.Glam_SK;
                }
            }
        }

        public string Moon_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Moon_SK;
                }
                else
                {
                    return EN.Moon_SK;
                }
            }
        }


        //Emotes
        //Epic
        public string A_your_service_EM//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.A_your_service_EM;
                }
                else
                {
                    return EN.A_your_service_EM;
                }
            }
        }

        public string Come_here_EM//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Come_here_EM;
                }
                else
                {
                    return EN.Come_here_EM;
                }
            }
        }

        public string Give_and_take_EM//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Give_and_take_EM;
                }
                else
                {
                    return EN.Give_and_take_EM;
                }
            }
        }

        public string How_amusing_EM//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.How_amusing_EM;
                }
                else
                {
                    return EN.How_amusing_EM;
                }
            }
        }

        public string Waiting_EM//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Waiting_EM;
                }
                else
                {
                    return EN.Waiting_EM;
                }
            }
        }

        public string Facepalm_EM//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Facepalm_EM;
                }
                else
                {
                    return EN.Facepalm_EM;
                }
            }
        }


        //Victory Poses
        //Rare
        public string Orbs_VP//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Orbs_VP;
                }
                else
                {
                    return EN.Orbs_VP;
                }
            }
        }

        public string Prim_VP//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Prim_VP;
                }
                else
                {
                    return EN.Prim_VP;
                }
            }
        }

        public string Steepling_VP//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Steepling_VP;
                }
                else
                {
                    return EN.Steepling_VP;
                }
            }
        }
    }
}
