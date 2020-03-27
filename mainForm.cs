using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeEstoque
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeDate.Start();
        }

        private void timeDate_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            lblHour.Text = agora.ToLongTimeString();
            lblDate.Text = agora.ToLongDateString();
            lblHour.Visible = true;
            lblDate.Visible = true;

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConsultarProdutos frmConsult = new ConsultarProdutos();
            //frmConsult.TopLevel = false;
            //frmConsult.Visible = true;
            //ControlPanel.Controls.Add(frmConsult);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto frmCadastrar = new frmCadastrarProduto();
            frmCadastrar.TopLevel = false;
            frmCadastrar.Visible = true;
            ControlPanel.Controls.Add(frmCadastrar);
            
        }
    }
}
