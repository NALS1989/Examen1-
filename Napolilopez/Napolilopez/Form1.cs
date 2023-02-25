using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napolilopez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  
        private void button3_Click(object sender, EventArgs e)
        {
            string fecha_mia = "31/01/2023";
            DateTime fechaNow = new DateTime();
            fechaNow = DateTime.Parse(fecha_mia.ToString());

            for (int i = 0; i < 12; i++)
            {
                listBox2.Items.Add(fechaNow.AddMonths(i) + "=" + (200000 * 0.015) * (i + 1));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form2=new Form2();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }
    }
}
