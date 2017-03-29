using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace Views
{
    public partial class frmListagemCarros : Form
    {
        public frmListagemCarros()
        {
            InitializeComponent();
        }

        private void CarregarGridViewCarros()
        {
            dgvCarros.DataSource = null;
            CarrosController carController = new CarrosController();
            dgvCarros.DataSource = carController.Listar();
        }

        private void frmListagemCarros_Load(object sender, EventArgs e)
        {
            CarregarGridViewCarros();
        }

        private void dgvCarros_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].Value);

                frmCadastroCarro cadCarro = new frmCadastroCarro(idSelecionado);
                cadCarro.ShowDialog();

                CarregarGridViewCarros();
            }
        }
    }
}
