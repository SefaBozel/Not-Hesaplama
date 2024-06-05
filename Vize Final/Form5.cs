using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim, ogrencino;
            int vize1, vize2, final;
            double ortalama;
            isim = textBox1.Text;
            ogrencino = textBox2.Text;
            vize1 = Convert.ToInt16(textBox3.Text);
            vize2 = Convert.ToInt16(textBox4.Text);
            final = Convert.ToInt16(textBox5.Text);
            ortalama = (vize1 + vize2 + final) / 3.0;
            listBox1.Items.Add(isim+" "+ogrencino+" "+ortalama);
        }
    }
}
