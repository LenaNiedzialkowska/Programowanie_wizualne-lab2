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
    public partial class Form3 : Form
    {
        int cena = 0;
        int cenaMonitora = 0;
        public int getCena()
        {
            return cena;
        }

        public void setCena(int nowaCena)
        {
            cena = nowaCena;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listView1.Items[0].Selected)
            { 
                cena = cena - cenaMonitora;
                cenaMonitora = 100;
                cena += cenaMonitora;
            }
            if (listView1.Items[1].Selected)
            {
                cena = cena - cenaMonitora;
                cenaMonitora = 200;
                cena += cenaMonitora;
            }
            if (listView1.Items[2].Selected)
            {
                cena = cena - cenaMonitora;
                cenaMonitora = 300;
                cena += cenaMonitora;
            }
            if (listView1.Items[3].Selected)
            {
                cena = cena - cenaMonitora;
                cenaMonitora = 400;
                cena += cenaMonitora;
            }
            labelCena.Text = cena.ToString();
        }

        private void labelCena_Click(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
