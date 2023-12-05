using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_uygulama_815
{
    public partial class Form1 : Form
    {
        List<string> kisiler = new List<string>();
        int indexSira = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kisiler.Add(txtKisi.Text);

            lbKisiler.DataSource = kisiler.ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            kisiler.Add("Yezda");
            kisiler.Add("Ravza");
            kisiler.Add("Hilal");
            kisiler.Add("Nursevim");
            kisiler.Add("Melisa");
            kisiler.Add("Melek");

            lbKisiler.DataSource = kisiler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtKisi.Text);
            if (durum)
            {
                MessageBox.Show("Aradığınız kişi mevcut.");
            }
            else
            {
                MessageBox.Show("Aradığınız kişi mevcut değildir.");
            }
        }

        private void btnSirs_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtKisi.Text);
            if (sira > -1)
            {
                MessageBox.Show(txtKisi.Text + " " + sira + ". sırasındadır.");
            }
            else
            {
                MessageBox.Show(txtKisi.Text + " sıralamada yok");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtKisi.Text);
            if (sira > -1)
            {
                kisiler.RemoveAt(sira);
            }

            lbKisiler.DataSource = kisiler.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtKisi.Text);
            if (durum)
            {
                kisiler.Remove(txtKisi.Text);
            }
            lbKisiler.DataSource = kisiler.ToList();
        }

        private void lbKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisi.Text = lbKisiler.SelectedValue.ToString();
            indexSira = lbKisiler.SelectedIndex;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kisiler[indexSira] = txtKisi.Text;
            lbKisiler.DataSource = kisiler.ToList();
        }

        private void btnArtran_Click(object sender, EventArgs e)
        {
            kisiler.Sort();

            lbKisiler.DataSource = kisiler.ToList();
        }

        private void btnAzalan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            kisiler.Reverse();

            lbKisiler.DataSource = kisiler.ToList();
        }

        private void btnKarakter_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Length == 5)
                {
                    sayac++;
                }
            }
            MessageBox.Show("5 Karakterli :" + sayac + " tane öğrenci mevcut.");
        }

        private void btnMharfi_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i][0] == 'M')
                {
                    sayac++;
                }
            }
            MessageBox.Show("M harfli :" + sayac + " tane öğrenci mevcut.");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
           kisiler.Clear();
            lbKisiler.DataSource = kisiler.ToList();

        }

        private void btnAharfi_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                string kisi = kisiler[i];
                if (kisi[kisi.Length-1] == 'a')
                {
                    sayac++;
                }
            }
            MessageBox.Show("A harfli :" + sayac + " tane öğrenci mevcut.");
        }
    }
}