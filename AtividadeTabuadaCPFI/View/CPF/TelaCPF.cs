using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeTabuadaCPFI.View.CPF
{
    public partial class TelaCPF : Form
    {
        public TelaCPF()
        {
            InitializeComponent();
        }

        private void validarCPF()
        {
            if (string.IsNullOrWhiteSpace(tbxCPF.Text))
            {
                MessageBox.Show("CPF é Obrigatório","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                tbxCPF.Focus();
                tbxCPF.SelectAll();
                return;
            }

            string cpfInformado = tbxCPF.Text.Replace("", "").Replace("-", "-");

            lblResultado.Text = cpfInformado;

            if (cpfInformado.Length != 11)
            {
                lblResultado.Text = "Informa um CPF com 11 digitos";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            string cpf = cpfInformado.Substring(0, 9);


            int soma = 0;
            int valorRef = 10;


        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            validarCPF();

        }
    }
}

