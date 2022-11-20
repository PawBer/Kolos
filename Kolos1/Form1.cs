using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolos1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int waty;
            float cenaKwh;
            try
            {
                waty = int.Parse(textBox1.Text);
                cenaKwh = float.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Złe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Nie wybrano okresu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float naDobe = (waty / 1000F) * trackBar1.Value * cenaKwh;
            float cena = 0.0F;
            if (radioButton1.Checked)
            {
                cena = naDobe;
            }
            else if (radioButton2.Checked)
            {
                cena = naDobe * 30;
            }
            else if (radioButton3.Checked)
            {
                cena = naDobe * 365;
            }
            label5.Text = "Koszt użytkowania wynosi: " + Math.Round(cena, 2) + " zł";
        }
    }
}
