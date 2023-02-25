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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            double precio=Convert.ToDouble(PreciotTextBox.Text); 
            double canti=Convert.ToDouble(CantidadTextBox.Text);
            double Totalpagar;

            double resultado = await DescAsync(precio, canti);

            MessageBox.Show($"Descuento es:{resultado}");

            Totalpagar = (precio * canti)-resultado;

            MessageBox.Show($"El Total a pagar es:{Totalpagar}");


        }


        private async Task<double> DescAsync(double precio, double canti)
        {
            var descuentoFinal = await Task.Run(() =>

            {

                return (precio * canti)*0.15;
            });
            return descuentoFinal;
            }

        }

    }


