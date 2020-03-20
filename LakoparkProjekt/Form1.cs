using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakoparkProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private HappyLiving happyLiving = new HappyLiving("lakoparkok.txt");
        private List<Image> houseLvl = new List<Image>();
        private int park = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            houseLvl.Add(Image.FromFile(@"src\kereszt.jpg"));
            houseLvl.Add(Image.FromFile(@"src\Haz1.jpg"));
            houseLvl.Add(Image.FromFile(@"src\Haz2.jpg"));
            houseLvl.Add(Image.FromFile(@"src\Haz3.jpg"));
            pUpdate();
        }


        private void pUpdate() {
            this.Text = happyLiving.Lakoparkok[park].Nev;
            switch (park)
            {
                case 1:
                    back.Enabled = false;
                    back.Hide();
                        break;
                case 2:
                    back.Enabled = true;
                    back.Show();
                    next.Enabled = true;
                    next.Show();
                        break;
                case 3:
                    next.Enabled = false;
                    next.Hide();
                        break;
                default:
                    break;
            }
            string name = happyLiving.Lakoparkok[park].Nev;
            
            if (name.ToLower().Contains("puskas"))
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"src\Puskás Ferenc.jpg");
            }
            if (name.ToLower().Contains("van"))
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"src\Van Gogh.jpg");
            }
            if (name.ToLower().Contains("vivaldi"))
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"src\Vivaldi.jpg");
            }

            panel1.Controls.Clear();
            int buttonSize = 50;

            for (int i = 0; i < happyLiving.Lakoparkok[park].Hazak.GetLength(1); i++)
            {
                for (int j = 0; j < happyLiving.Lakoparkok[park].Hazak.GetLength(0); j++)
                {
                    Button g = new Button();
                    g.BackgroundImage = houseLvl[happyLiving.Lakoparkok[park].Hazak[j, i]];
                    g.BackgroundImageLayout = ImageLayout.Stretch;
                    g.SetBounds(i * buttonSize, j * buttonSize, buttonSize, buttonSize);
                    panel1.Controls.Add(g);
                }
            }



        }

        private void Back_Click(object sender, EventArgs e)
        {
            park--;
            pUpdate();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            park++;
            pUpdate();
        }
    }
}
