using System.Windows.Forms;
using Models;
using Controllers;
using System;

namespace Views
{
    public partial class frmCadastroCarro : Form
    {
        public int? CarroID { get; set; }
        public Carro _Carro { get; set; }

        public frmCadastroCarro(int? idCarro)
        {
            InitializeComponent();

            if (idCarro.HasValue)
            {
                CarroID = idCarro;
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void LimparCampos()
        {
            CarroID = null;
            _Carro = null;
            txtAno.Clear();
            txtModelo.Clear();
            btnSalvar.Text = "Salvar";
        }

        private void CarregarFormulario()
        {
            if (CarroID.HasValue)
            {
                CarrosController carController = new CarrosController();
                _Carro = carController.Detalhes(CarroID.Value);

                if(_Carro != null)
                {
                    txtModelo.Text = _Carro.Modelo;
                    txtAno.Text = Convert.ToString(_Carro.Ano);
                    btnSalvar.Text = "Atualizar";
                }
            }
            else
            {
                LimparCampos();
            }
        }

        private void frmCadastroCarro_Load(object sender, EventArgs e)
        {
            CarregarFormulario();

        }

        private bool Validar()
        {
            return !(String.IsNullOrEmpty(txtModelo.Text)) || !(String.IsNullOrEmpty(txtAno.Text));
        }

        private void Salvar()
        {
            try
            {
                if (Validar())
                {
                    if (CarroID.HasValue)
                    {
                        CarrosController carController = new CarrosController();
                        carController.Editar(CarroID.Value, txtModelo.Text, txtAno.Text);

                        MessageBox.Show("Carro alterado com sucesso");
                        LimparCampos();
                        this.Close();
                    }
                    else
                    {
                        CarrosController carController = new CarrosController();
                        carController.Adicionar(txtModelo.Text, txtAno.Text);

                        MessageBox.Show("Carro cadastrado com sucesso");
                        LimparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Todos campos são obrigatórios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
