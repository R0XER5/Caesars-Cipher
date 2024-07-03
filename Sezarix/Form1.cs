using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezarix
{
    public partial class Form1 : Form
    {
        char[] turkishCharacters = new char[]
        {   
            'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h',
            'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p',
            'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z'
        };

        List<TextBox> desifreTextboxes = new List<TextBox>();



        public Form1()
        {
            InitializeComponent();
            desifreTextboxes.Add(desifre1);
            desifreTextboxes.Add(desifre2);
            desifreTextboxes.Add(desifre3);
            desifreTextboxes.Add(desifre4);
            desifreTextboxes.Add(desifre5);
            desifreTextboxes.Add(desifre6);
            desifreTextboxes.Add(desifre7);
            desifreTextboxes.Add(desifre8);
            desifreTextboxes.Add(desifre9);
            desifreTextboxes.Add(desifre10);
            desifreTextboxes.Add(desifre11);
            desifreTextboxes.Add(desifre12);
            desifreTextboxes.Add(desifre13);
            desifreTextboxes.Add(desifre14);
            desifreTextboxes.Add(desifre15);
            desifreTextboxes.Add(desifre16);
            desifreTextboxes.Add(desifre17);
            desifreTextboxes.Add(desifre18);
            desifreTextboxes.Add(desifre19);
            desifreTextboxes.Add(desifre20);
            desifreTextboxes.Add(desifre21);
            desifreTextboxes.Add(desifre22);
            desifreTextboxes.Add(desifre23);
            desifreTextboxes.Add(desifre24);
            desifreTextboxes.Add(desifre25);
            desifreTextboxes.Add(desifre26);
            desifreTextboxes.Add(desifre27);
            desifreTextboxes.Add(desifre28);
            desifreTextboxes.Add(desifre29);
        }

        private void password(object sender, EventArgs e)
        {
            string kelime = word.Text;
            kelime2.Text = kelime;
            if (oteleme1.Text.Equals("")) { return; }
            int otelemeSayisi = int.Parse(oteleme1.Text) ;
            
            string sifre = "";

            if (otelemeSayisi >= turkishCharacters.Length) {
                otelemeSayisi = otelemeSayisi % turkishCharacters.Length;
            }
            oteleme2.Text = otelemeSayisi + "";
            for (int i = 0; i < kelime.Length; i++)
            {
                string harfler = new string(turkishCharacters);
                int index = harfler.IndexOf(kelime.ElementAt(i));
                int newIndex = index + otelemeSayisi;
                if (newIndex >= turkishCharacters.Length)
                {
                    newIndex = newIndex % turkishCharacters.Length;
                }
                sifre = sifre + harfler.ElementAt(newIndex);
            }

            textBox2.Text = sifre;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string bosluk = "";
            textBox2.Text = bosluk;
            word.Text = bosluk;
            kelime2.Text = bosluk;
            oteleme1.Text = bosluk;
            oteleme2.Text = bosluk;
            textBox23.Text = bosluk;
            foreach (var item in desifreTextboxes)
            {
                item.Text = "";
            }
        }

        private void oteleme1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(oteleme1.Text) && !oteleme1.Text.All(char.IsDigit))
            {
                oteleme1.Text = oteleme1.Text.Remove(oteleme1.Text.Length - 1);
                oteleme1.SelectionStart = oteleme1.Text.Length;
            }
        }

        private void desifre(object sender, EventArgs e)
        {
            string sifre = textBox23.Text;
            for (int i = 0; i < desifreTextboxes.Count; i++)
            {
                string otelenmis = "";
                for (int j = 0; j < sifre.Length; j++)
                {
                    string harfler = new string(turkishCharacters);
                    int index = harfler.IndexOf(sifre.ElementAt(j));
                    int newIndex = index + i;
                    if (newIndex >= turkishCharacters.Length)
                    {
                        newIndex = newIndex % turkishCharacters.Length;
                    }
                    otelenmis = otelenmis + harfler.ElementAt(newIndex);
                }
                desifreTextboxes[i].Text = otelenmis;
            }
        }

        private char otele(char otelenecekKarakter, int otelemeSayisi)
        {
            
            string harfler = new string(turkishCharacters);
            int index = harfler.IndexOf(otelenecekKarakter);
            int newIndex = index + otelemeSayisi;
           return harfler.ElementAt(newIndex);

        }

        private void wordTextChanged(object sender, EventArgs e)
        {
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void desifre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre2_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre3_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre4_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre5_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre10_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre9_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre8_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre7_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre6_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre11_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre12_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre13_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre14_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre15_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre20_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre19_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre18_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre17_TextChanged(object sender, EventArgs e)
        {

        }

        private void desifre16_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
