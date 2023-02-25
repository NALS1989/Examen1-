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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aleatoriosNumeros();
        }


        public void aleatoriosNumeros()
        {
            for (int i = 1; i < 100; i++)
               
            {
                if (i%3==0)
                {
                    listBox1.Items.Add("Napoli");
                }
                if(i%5==0)
                {
                    listBox1.Items.Add("Lopez");
                }
                if (i%3==0 && i%5==0)
                {
                    listBox1.Items.Add("Napoli Lopez");
                }
               
            }

        }


    }
     
}
