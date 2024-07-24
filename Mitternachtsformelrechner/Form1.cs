using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitternachtsformelrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, x1, x2;
            a = Convert.ToDouble(textBox1.Text);
            if (a == 0)
            {
                label5.Text = "a kann nicht 0 sein, da durch 0 nicht geteilt werden darf";
            }
            else
            {
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    label5.Text = "Die Lösungen für diese quadratische Gleichung sind\r\nx₁ = " + Convert.ToString(x1) + "      und\r\nx₂ = " + Convert.ToString(x2);
                }
                else
                {
                    if (d == 0)
                    {
                        x1 = -b / (2 * a);
                        label5.Text = "Die Lösung für diese quadratische Gleichung ist x = " + Convert.ToString(x1);
                    }
                    else
                    {
                        label5.Text = "Es konnte keine reelle Lösung berechnet werden";
                    }
                }
            }
        }
    }
}
