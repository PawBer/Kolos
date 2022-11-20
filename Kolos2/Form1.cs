using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = dateTimePicker1.Value;
            int rok = data.Year;
            int miesiac = data.Month;
            int dzien = data.Day;

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Nie wybrano płci", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random rand = new Random();
            StringBuilder sb = new StringBuilder();

            string rokString = rok.ToString();
            sb.Append(rokString.Substring(rokString.Length - 2, 2));

            string miesiacString = string.Empty;
            if(data.Year >= 1900 && data.Year <= 1999)
            {
                miesiacString = miesiac.ToString().PadLeft(2, '0');
            } else if (data.Year >= 1800 && data.Year <= 1899)
            {
                miesiac = data.Month + 80;
                miesiacString = miesiac.ToString().PadLeft(2, '0');
            } else if (data.Year >= 2000 && data.Year <= 2099)
            {
                miesiac = data.Month + 20;
                miesiacString = miesiac.ToString().PadLeft(2, '0');
            }
            else if (data.Year >= 2100 && data.Year <= 2199)
            {
                miesiac = data.Month + 40;
                miesiacString = miesiac.ToString().PadLeft(2, '0');
            }
            else if (data.Year >= 2200 && data.Year <= 2299)
            {
                miesiac = data.Month + 60;
                miesiacString = miesiac.ToString().PadLeft(2, '0');
            } else
            {
                MessageBox.Show("Nieobsługiwana data", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sb.Append(miesiacString);
            string dzienString = dzien.ToString();
            sb.Append(dzienString.PadLeft(2, '0'));
            sb.Append(rand.Next(9).ToString());
            sb.Append(rand.Next(9).ToString());
            sb.Append(rand.Next(9).ToString());
            int liczba = rand.Next(9);
            if (radioButton1.Checked)
            {
                while (liczba % 2 != 0)
                {
                    liczba = rand.Next(9);
                }
            } else if (radioButton2.Checked)
            {
                while (liczba % 2 == 0)
                {
                    liczba = rand.Next(9);
                }
            }
            sb.Append(liczba.ToString());
            sb.Append(rand.Next(9).ToString());
            label2.Text = sb.ToString();
        }
    }
}
