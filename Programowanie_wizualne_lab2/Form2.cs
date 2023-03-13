using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programowanie_wizualne_lab2
{
    public partial class Form2 : Form
    {
        double cena = 0.00;
        double cenaDysku = 0.00;
        double cenaKarty = 0.00;
        public Form2()
        {
            InitializeComponent();
        }

        private void checkMysz_CheckedChanged(object sender, EventArgs e)
        {
            if(checkMysz.Checked == true) 
            {
                cena += 500;
            }
            if (checkMysz.Checked == false)
            {
                cena = cena - 500;
            }
            labelCena.Text = cena.ToString();
        }
        
        private void checkKamera_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKamera.Checked == true)
            {
                cena += 200;
            }
            if (checkKamera.Checked == false)
            {
                cena = cena - 200;
            }
            labelCena.Text = cena.ToString();
        }

        private void checkPort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPort.Checked == true)
            {
                cena += 312;
            }
            if (checkPort.Checked == false)
            {
                cena = cena - 312;
            }
            labelCena.Text = cena.ToString();
        }

        private void checkGrafika_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGrafika.Checked == true)
            {
                cena += 580;
            }
            if (checkGrafika.Checked == false)
            {
                cena = cena - 580;
            }
            labelCena.Text = cena.ToString();
        }

        private void radio3TB_CheckedChanged(object sender, EventArgs e)
        {
            cena = cena - cenaDysku;
            cenaDysku = 800;
            cena += cenaDysku;
            labelCena.Text = cena.ToString();
        }

        private void radio1TB_CheckedChanged(object sender, EventArgs e)
        {
            cena = cena - cenaDysku;
            cenaDysku = 250;
            cena += cenaDysku;
            labelCena.Text = cena.ToString();
        }

        private void radio2TB_CheckedChanged(object sender, EventArgs e)
        {
            cena = cena - cenaDysku;
            cenaDysku = 400;
            cena += cenaDysku;
            labelCena.Text = cena.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("RTX 3660"))
            {
                cena = cena - cenaKarty;
                cenaKarty = 1800;
                cena += cenaKarty;
            }
            else if (comboBox1.SelectedItem.Equals("GTX 1600Ti"))
            {
                cena = cena - cenaKarty;
                cenaKarty = 1300;
                cena += cenaKarty;
            }
            else if (comboBox1.SelectedItem.Equals("RTX 4090"))
            {
                cena = cena - cenaKarty;
                cenaKarty = 10000;
                cena += cenaKarty;  
            }
            labelCena.Text = cena.ToString();
        }

        private void labelCena_Click(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {

        }
        
    }
}
