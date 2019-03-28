using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞansOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int puan = 30;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            int random1, random2, random3;
            Random rnd = new Random();
            random1 = rnd.Next(0,10);
            random2 = rnd.Next(0, 10);
            random3 = rnd.Next(0, 10);        
            lbl1.Text = random1.ToString();
            lbl2.Text = random2.ToString();
            lbl3.Text = random3.ToString();



            if (random1 == 7 && random2 == 7 && random3 == 7)
            {
                puan += 100;
                label2.Text = puan.ToString();
            }
            else if (random1 == 7 && random2 == 7)
            {
                puan += 50;
                label2.Text = puan.ToString();
            }
            else if (random1 == 7 && random3 == 7)
            {
                puan += 40;
                label2.Text = puan.ToString();
            }
            else if (random2 == 7 && random3 == 7)
            {
                puan += 30;
                label2.Text = puan.ToString(); ;
            }
            else if (random1 == 7 && random3 == 7)
            {
                puan += 20;
                label2.Text = puan.ToString();
            }
            else if(random1 == 7)
            {
                puan += 10;
                label2.Text = puan.ToString();
            }
            else
            {
                puan -= 5;
                label2.Text = puan.ToString();
            }
            if(puan <= 0)
            {
                MessageBox.Show("Oyun bitti");
                label2.Text = "30";
                puan = 30;
                lbl1.Text = "0";
                lbl2.Text = "0";
                lbl3.Text = "0";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
