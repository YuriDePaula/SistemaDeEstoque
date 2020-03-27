using SistemaDeEstoque.Context;
using SistemaDeEstoque.Dominio;
using SistemaDeEstoque.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeEstoque
{
    public partial class frmCadastrarProduto : Form
    {
        IRepositorio<Produtos, long> repositorioProduto = new RepositorioProduto(new GerenciamentoDeEstoqueDbContext());
        IRepositorio<MarcaProdutos, int> repositorioMarca = new RepositorioMarcas(new GerenciamentoDeEstoqueDbContext());

        int _idCodigoBarras = 0;

        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void CarregarMarcas()
        {
            cbxListaMarcas.Items.Clear();
            Task.Run(() =>
               {
                   List<MarcaProdutos> marcasProd = repositorioMarca.Selecionar();

                   foreach (var marcas in marcasProd)
                   {
                       cbxListaMarcas.Invoke((MethodInvoker)delegate
                       {
                           cbxListaMarcas.Items.Add(marcas.NomeMarca);
                       });
                   }
               });

        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {
            CarregarMarcas();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCodigoBarras.Text = "";
            txtNomeProduto.Text = "";
            mkbDataValidade.Text = "";
            txtIdentificacaoCorredorEstoque.Text = "";
            txtIdentificacaoPrateleiraEstoque.Text = "";
            txtQuantidadeEstoque.Text = "";
            txtIdentificacaoMercado.Text = "";
            txtIdentificacaoPrateleiraMercado.Text = "";
            txtQuantidadeMercado.Text = "";

            CarregarMarcas();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _idCodigoBarras = Convert.ToInt32(txtCodigoBarras.Text);

            repositorioProduto.ExcluirPorId(_idCodigoBarras);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            foreach (var name in repositorioMarca.Selecionar())
            {
                if (name.NomeMarca == Convert.ToString(cbxListaMarcas.SelectedItem))
                {
                    _idCodigoBarras = name.IdentificacaoDeMarca;
                }
            }

            MarcaProdutos alteracaoMarca = repositorioMarca.SelecionarPorId(_idCodigoBarras);

            Produtos alteracaoProdutos = new Produtos
            {
                CodBarras = Convert.ToInt32(txtCodigoBarras.Text),
                NomeProduto = txtNomeProduto.Text,
                DataValidade = Convert.ToDateTime(mkbDataValidade.Text),
                IdentificacaoDeMarca = alteracaoMarca.IdentificacaoDeMarca,
                IdentificacaoPrateleiraEstoque = Convert.ToInt16(txtIdentificacaoPrateleiraEstoque.Text),
                IdentificacaoPrateleiraMercado = Convert.ToInt16(txtIdentificacaoPrateleiraMercado.Text),
                QuantidadePrateleiraEstoque = Convert.ToInt16(txtQuantidadeEstoque.Text),
                QuantidadePrateleiraMercado = Convert.ToInt16(txtQuantidadeMercado.Text),
                ResponsavelSetor = txtResponsavelSetor.Text
            };

            repositorioProduto.Alterar(alteracaoProdutos);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                foreach (var name in repositorioMarca.Selecionar())
                {
                    if (name.NomeMarca == Convert.ToString(cbxListaMarcas.SelectedItem))
                    {
                        _idCodigoBarras = name.IdentificacaoDeMarca;
                    }
                }

                MarcaProdutos alteracaoMarca = repositorioMarca.SelecionarPorId(_idCodigoBarras);

                Produtos inclusaoProdutos = new Produtos
                {
                    CodBarras = Convert.ToInt32(txtCodigoBarras.Text),
                    NomeProduto = txtNomeProduto.Text,
                    DataValidade = Convert.ToDateTime(mkbDataValidade.Text),
                    IdentificacaoDeMarca = alteracaoMarca.IdentificacaoDeMarca,
                    IdentificacaoPrateleiraEstoque = Convert.ToInt16(txtIdentificacaoPrateleiraEstoque.Text),
                    IdentificacaoPrateleiraMercado = Convert.ToInt16(txtIdentificacaoPrateleiraMercado.Text),
                    QuantidadePrateleiraEstoque = Convert.ToInt16(txtQuantidadeEstoque.Text),
                    QuantidadePrateleiraMercado = Convert.ToInt16(txtQuantidadeMercado.Text),
                    ResponsavelSetor = txtResponsavelSetor.Text
                };

                repositorioProduto.Inserir(inclusaoProdutos);
            }
        }


        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoBarras.Text.Length == 5)
            {
                try
                {
                    foreach (var CodBarras in repositorioProduto.Selecionar())
                    {
                        if (CodBarras.CodBarras == Convert.ToInt16(txtCodigoBarras.Text))
                        {
                            _idCodigoBarras = Convert.ToInt32(CodBarras.CodBarras);
                        }
                    }

                    Produtos alteracaoProdutos = repositorioProduto.SelecionarPorId(_idCodigoBarras);

                    txtCodigoBarras.Text = Convert.ToString(alteracaoProdutos.CodBarras);
                    txtNomeProduto.Text = alteracaoProdutos.NomeProduto;
                    mkbDataValidade.Text = alteracaoProdutos.DataValidade.ToString("dd/MM/yyyy");



                    //    IdentificacaoDeMarca = alteracaoMarca.IdentificacaoDeMarca,
                    //    IdentificacaoPrateleiraEstoque = Convert.ToInt16(txtIdentificacaoPrateleiraEstoque.Text),
                    //    IdentificacaoPrateleiraMercado = Convert.ToInt16(txtIdentificacaoPrateleiraMercado.Text),
                    //    QuantidadePrateleiraEstoque = Convert.ToInt16(txtQuantidadeEstoque.Text),
                    //    QuantidadePrateleiraMercado = Convert.ToInt16(txtQuantidadeMercado.Text),
                    //    ResponsavelSetor = txtResponsavelSetor.Text
                    //};
                }
                catch 
                {

                    return;
                }
            }
        }

        #region ManipularCampos

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtCodigoBarras.Text))
            {
                if (MessageBox.Show("Código de barras deve ser preenchido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtCodigoBarras.Focus();
                }
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                if (MessageBox.Show("Nome do produto deve ser preenchido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtNomeProduto.Focus();
                }
                return false;
            }
            else if (mkbDataValidade.Text.Length < 10)
            {
                if (MessageBox.Show("Data de validade deve ser preenchida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    mkbDataValidade.Focus();
                }
                return false;
            }
            else if (String.IsNullOrWhiteSpace(cbxListaMarcas.Text))
            {
                if (MessageBox.Show("Uma marca deve ser selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    cbxListaMarcas.Focus();
                }
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txtIdentificacaoCorredorEstoque.Text))
            {
                if (MessageBox.Show("Identificador de corredor está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtIdentificacaoCorredorEstoque.Focus();
                }
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txtIdentificacaoPrateleiraEstoque.Text))
            {
                if (MessageBox.Show("Identificador de prateleira está vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtIdentificacaoPrateleiraEstoque.Focus();
                }
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txtQuantidadeEstoque.Text))
            {
                if (MessageBox.Show("A quantidade de produtos está vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtQuantidadeEstoque.Focus();
                }
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txtIdentificacaoMercado.Text))
            {
                if (MessageBox.Show("Identificador de corredor está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtIdentificacaoMercado.Focus();
                }
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txtIdentificacaoPrateleiraMercado.Text))
            {
                if (MessageBox.Show("Identificador de prateleira está vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtIdentificacaoPrateleiraMercado.Focus();
                }
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txtQuantidadeMercado.Text))
            {
                if (MessageBox.Show("A quantidade de produtos está vazia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtQuantidadeMercado.Focus();
                }
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txtResponsavelSetor.Text))
            {
                if (MessageBox.Show("Digite o nome do responsável pelo setor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtResponsavelSetor.Focus();
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mkbDataValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdentificacaoCorredorEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdentificacaoPrateleiraEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantidadeEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdentificacaoMercado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdentificacaoPrateleiraMercado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantidadeMercado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
