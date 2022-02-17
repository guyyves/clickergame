using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicking_game
{
    public partial class Form1 : Form
    {
       //stats
        int spelerPunten = 0;
        int UpgradeTw = 0;
        int UpgradeTm1 = 0;
        int UpgradeTm2 = 0;
        int UpgradeTw2 = 0;
        int UpgradeTf = 0;


        //upgrades
        int Upgrade50 = 0;
        int Upgrade100 = 0;
        int Upgrade500 = 0;
        int Upgrade1000 = 0;
        int Upgrade2500 = 0;

        //Timer
        int TimerNummer = 0;
        int clickPerMinuut = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            spelerPunten += 1;
            clickPerMinuut += 1;
            lblSpelerpunten.Text = spelerPunten.ToString()+" TACO'S";
        }







        private void button2_Click(object sender, EventArgs e)
        {
            if (spelerPunten >= 50)
            {
                Upgrade50 += 1;
                spelerPunten -= 50;
                UpgradeTw += 1;
                lblSpelerpunten.Text = spelerPunten.ToString() + " TACO'S";
                lblTw.Text = UpgradeTw.ToString() + "X  Taco Werknemer";
            }
            else
            {
                MessageBox.Show("Je hebt niet genoeg Taco's om deze upgrade tekopen");
            }
        }

        private void btnUpgrade100_Click(object sender, EventArgs e)
        {
            if (spelerPunten >= 100) 
            {
                Upgrade100 += 1;
                spelerPunten -= 100;
                UpgradeTm1 += 1;
                lblSpelerpunten.Text = spelerPunten.ToString() + " TACO'S";
                lblTm1.Text = UpgradeTm1.ToString() + "X  Taco Machine 1.0";
            }
            else
            {
                MessageBox.Show("Je hebt niet genoeg Taco's om deze upgrade tekopen");
            }
        }

        private void btnUpgrade500_Click(object sender, EventArgs e)
        {
            if (spelerPunten >= 500) 
            {
                Upgrade500 += 1;
                spelerPunten -= 500;
                UpgradeTm2 += 1;
                lblSpelerpunten.Text = spelerPunten.ToString() + " TACO'S";
                lblTm2.Text = UpgradeTm2.ToString() + "X  Taco Machine 2.0";
            }
            else
            {
                MessageBox.Show("Je hebt niet genoeg Taco's om deze upgrade tekopen");
            }
        }

        private void btnUpgrade1000_Click(object sender, EventArgs e)
        {
            if (spelerPunten >= 1000) 
            {
                Upgrade1000 += 1;
                spelerPunten -= 1000;
                UpgradeTw2 += 1;
                lblSpelerpunten.Text = spelerPunten.ToString() + " TACO'S";
                lblTw2.Text = UpgradeTw2.ToString() + "X  Taco Winkel";
            }
            else
            {
                MessageBox.Show("Je hebt niet genoeg Taco's om deze upgrade tekopen");
            }
        }

        private void btnUpgrade2500_Click(object sender, EventArgs e)
        {
            if (spelerPunten >= 2500) 
            {
                Upgrade2500 += 1;
                spelerPunten -= 2500;
                UpgradeTf += 1;
                lblSpelerpunten.Text = spelerPunten.ToString() + " TACO'S";
                lblTf.Text = UpgradeTf.ToString() + "X  Taco Fabriek";
            }
            else
            {
                MessageBox.Show("Je hebt niet genoeg Taco's om deze upgrade tekopen");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerNummer += 1;

            spelerPunten += Upgrade2500;

            if (TimerNummer% 4 == 0)
            {
                spelerPunten += Upgrade1000;
            }
            if (TimerNummer % 10 == 0)
            {
                spelerPunten += Upgrade500;
            }
            if (TimerNummer % 20 == 0)
            {
                spelerPunten += Upgrade100;
            }
            if (TimerNummer % 30 == 0)
            {
                spelerPunten += Upgrade50;
            }
            lblSpelerpunten.Text = spelerPunten.ToString() + " TACO'S";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            clickPerMinuut = clickPerMinuut * 12;
            lblCPM.Text = "TPM " + clickPerMinuut.ToString();
            clickPerMinuut = 0;
        }

        private void lblCPM_Click(object sender, EventArgs e)
        {

        }
    }
}
