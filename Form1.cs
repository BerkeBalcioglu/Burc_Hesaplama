using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = tarih.Value.Day;
            int ay = tarih.Value.Month; string[] burclar = { "kova", "balık", "koc", "boga", "ikizler", "aslan", "basak", "terazi", "akrep", "yay", "oglak" };
            //if ((ay==1 & gun>=21)|(ay==2 & gun<=19)) MessageBox.Show("Kova");
            //if ((ay==2 & gun>=20)|(ay==3 & gun<=20)) MessageBox.Show("Balık");
            for (int i = 1; i<= 11; i++)
            {
                if ((ay==i & gun>=21)|(ay==i+1 & gun<=19)) MessageBox.Show(burclar[i-1]);
            }
            if ((ay==12 & gun>=21)|(ay==1 & gun<=19)) MessageBox.Show("Oğlak");
        }  


    }
}
