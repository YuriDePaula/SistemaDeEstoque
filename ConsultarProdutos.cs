using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaDeEstoque.ConfiguracaoAbstrada;
using SistemaDeEstoque.Context;
using SistemaDeEstoque.Dominio;
using SistemaDeEstoque.Repositorio;

namespace SistemaDeEstoque
{
    public partial class ConsultarProdutos : Form
    {
        long _id = 0;

        IRepositorio<Produtos, long> repositorio = new RepositorioProduto(new GerenciamentoDeEstoqueDbContext());

        public ConsultarProdutos()
        {
            InitializeComponent();
            txtcodigo.Focus();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Clear();
            if (txtcodigo.Text == "" || txtcodigo.Text == null)
            {
                CarregarGrid();
            }
            else
            {

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             _id = (long)dgvProdutos.CurrentRow.Cells[0].Value;
        }

        private async void CarregarGrid()
        {
            List<Produtos> produtos = repositorio.Selecionar();
            await Task.Run(() =>
             {
                 foreach (var prod in produtos)
                 {
                     dgvProdutos.Rows.Add(prod.CodBarras, prod.CodBarras, prod.CodBarras);
                 }
             });
        }

        private void ConsultarProdutos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
