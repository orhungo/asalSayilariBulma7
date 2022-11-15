using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asalSayilariBulma7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            long sayac = 0;
            listBox1.Items.Clear();
            long sayi = (long)numericUpDown1.Value;

            {
                for (long i = 2; i <= sayi; i++)
                {
                    long kontrol = 0;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            kontrol++;
                            break;
                        }
                    }
                    if (kontrol == 0)
                    {
                        listBox1.Items.Add(i);
                        sayac++;
                        {
                            label2.Text = "Asal sayılar bulundu.";
                        }
                    }
                }
            }
            MessageBox.Show("1 - " + sayi + " arası " + sayac + " adet asal sayı vardır.");
        }
    }
}
