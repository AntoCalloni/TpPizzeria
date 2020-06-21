using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPizzas_Click(object sender, EventArgs e)
        {
            using (MenuPizzas ventanaPizzas = new MenuPizzas()) ventanaPizzas.ShowDialog();
        }

        private void RevisarStock_Click(object sender, EventArgs e)
        {
            using (StockMP ventanaStock = new StockMP()) ventanaStock.ShowDialog();
        }

        private void MenuEmpanadas_Click(object sender, EventArgs e)
        {
            using (MenuEmpanadas ventanaEmpanadas = new MenuEmpanadas()) ventanaEmpanadas.ShowDialog();
        }

        private void VerPedidos_Click(object sender, EventArgs e)
        {
            using (Pedidos ventanaPedidos = new Pedidos()) ventanaPedidos.ShowDialog();
        }
    }
}
