using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            lblDataAtual.Text = DateTime.Now.ToString();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadCliente = new frmCadastroCliente(null);
            cadCliente.MdiParent = this;
            cadCliente.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagemClientes listagem = new frmListagemClientes();
            listagem.MdiParent = this;
            listagem.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroCarro cadCarro = new frmCadastroCarro(null);
            cadCarro.MdiParent = this;
            cadCarro.Show();
        }

        private void listagemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListagemCarros listagem = new frmListagemCarros();
            listagem.MdiParent = this;
            listagem.Show();
        }
    }
}
