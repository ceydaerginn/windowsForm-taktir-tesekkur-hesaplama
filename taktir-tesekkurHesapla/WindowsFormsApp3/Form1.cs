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
            try
            {
                double ortalama = double.Parse(textBox1.Text);
                int devamsizlik = int.Parse(textBox2.Text);
                bool disiplin = radioButton1.Checked;

                if(devamsizlik > 10 || disiplin)
                {
                    label4.Text = "belge alamaz";
                }
                else if (ortalama >= 85 && devamsizlik < 10)
                {
                    label4.Text = "Takdir";
                }
                else if (ortalama >= 70 && devamsizlik < 10)
                {
                    label4.Text = "teşekkür";

                }
                else
                {
                    label4.Text = "belge alamaz";
                }

            }
            catch
            {
                MessageBox.Show("GEçerli değer gir");
            }
        }
    }
}
