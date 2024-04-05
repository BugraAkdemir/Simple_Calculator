using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinası
{
    public partial class Form1 : Form
    {

        private char _işlem;
        private bool _ekrantmz;
        int _ilksayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int _ikincisayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            
            switch (_işlem)
            {
                case '+':
                    sonuc = _ilksayi + _ikincisayi;
                    break;
                
                case '-':
                    sonuc = _ilksayi - _ikincisayi;
                    break;

                case '*':
                    sonuc = _ilksayi * _ikincisayi;
                    break;

                case '/':
                    sonuc = _ilksayi / _ikincisayi;
                    break;

                default:
                    sonuc=0;
                    break;
            }

            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _işlem = '/';
            _ekrantmz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void sayı1Button_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;  
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void sayı2Button_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void sayı4Button_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void sayı0Button_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artıButton_Click(object sender, EventArgs e)
        {
            _işlem = '+';
            _ekrantmz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _işlem = '-';
            _ekrantmz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void çarpıButton_Click(object sender, EventArgs e)
        {
            _işlem = '*';
            _ekrantmz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
