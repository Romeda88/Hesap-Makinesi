using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char _islem;
        bool _ekranTemizlecekmi;
        int _ilkSayı;

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "2";

        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "0";
        }

        private void artıButton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlecekmi)
            {
                ekranLabel.Text = "";
            }
            _islem = '+';
            _ekranTemizlecekmi = true;
            _ilkSayı = int.Parse(ekranLabel.Text);
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "";
            _ekranTemizlecekmi = true;
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc = 0;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayı + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayı - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayı * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayı / ikinciSayi;
                    break;
                default:
                    {
                        sonuc = 0;
                    }
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlecekmi = true;
            _ilkSayı = int.Parse(ekranLabel.Text);
        }

        private void carpmaButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlecekmi = true;
            _ilkSayı = int.Parse(ekranLabel.Text);
        }

        private void bolmeButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlecekmi = true;
            _ilkSayı = int.Parse(ekranLabel.Text);
        }
    }
}
