using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Vendas_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Clientes = new Form2();
            Clientes.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Form NovaVenda = new Form4();
            NovaVenda.Show();
        }

        private void EntregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Entrega = new Form5();
            Entrega.Show();
        }

        private void VendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Vendedores = new Form7();
            Vendedores.Show();
        }

        private void PedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Pedidos = new Form9();
            Pedidos.Show();
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Vendas = new Form11();
            Vendas.Show();
        }
    }
}
