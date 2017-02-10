using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Pole_Cykly
{
    public partial class Form1 : Form
    {
        string[] pole_hraci = new string[25]; // musim defonovat velikost pole
        List<string> list_hraci = new List<string>(); // nemusim definovat velikost pole !!!

        public Form1()
        {
            InitializeComponent();

            // klasicke pole kde musim defonovat velikost
            pole_hraci[0] = "David";
            pole_hraci[1] = "Lukas";
            pole_hraci[2] = "Honza";

            int i = 0;
            while (i < 5)
            {
                txt_hraci.Text = txt_hraci.Text + i.ToString() + " " + pole_hraci[i] + Environment.NewLine;
                i++;
            }
            txt_hraci.Text = txt_hraci.Text + Environment.NewLine + Environment.NewLine;

            // novy typ pole kde nemusim definovat velikost a tedy obrovska vyhoda - list, vlozeni obsahu
            list_hraci.Add("Fiko");
            list_hraci.Add("Niko");
            list_hraci.Add("Nic");
            list_hraci.Add("HHHHHHHic");
            list_hraci.Add("Kolic");

            int x = 0;
            while (x < list_hraci.Count)
            {
                txt_hraci.Text = txt_hraci.Text + x.ToString() + " " +list_hraci[x] + Environment.NewLine;
                x++;
            }
            txt_hraci.Text = txt_hraci.Text + Environment.NewLine + Environment.NewLine;



            // for cyklus
            for (int y = 0; y < 100; y++)
            {
                txt_hraci.Text = txt_hraci.Text + y.ToString();
            }


        }

        private void txt_hraci_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
