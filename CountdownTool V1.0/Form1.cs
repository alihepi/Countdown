using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int minute = 0;
        int second = 60;

        private void dakika_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            minute = Convert.ToInt32(dakika.Text);
            timer1.Start();

            if (baslat.Text == "Devam")
            {
                baslat.Text = Convert.ToString("Başlat");
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            baslat.Text = Convert.ToString("Devam");

            turCd.Text = Convert.ToString("Tur: " + (minute - 1) + ":" + (second));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = 1000;

            second = second - 1;
            dakikaCd.Text = Convert.ToString(minute - 1);
            saniyeCd.Text = Convert.ToString(second);
            this.BackColor = Color.Green;

            if (second == 0)
            {
                minute = minute - 1;
                second = 60;
            }

            if(minute <= 1 && minute >= 0)
            {
                this.BackColor = Color.OrangeRed;
            }

            if(minute == 0)
            {
                dakikaCd.Text = Convert.ToString("00");
                saniyeCd.Text = Convert.ToString("00");
                this.BackColor = Color.Red;

                if(baslat.Text == "Devam")
                {
                    baslat.Text = Convert.ToString("Başlat");
                }

                timer1.Stop();
            }

        }

        
    }
}
