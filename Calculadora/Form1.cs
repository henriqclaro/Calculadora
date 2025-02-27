using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CriarDicas();
        }

        void CriarDicas()
        {
            ToolTip dica = new ToolTip();
            dica.AutoPopDelay = 4000;
            dica.InitialDelay = 900;
            dica.ReshowDelay = 500;
            dica.ShowAlways = true;

            dica.SetToolTip(btnSoma, "Adição");
            dica.SetToolTip(btnSub, "Subtração");
            dica.SetToolTip(btnMult, "Multiplicação");
            dica.SetToolTip(btnDiv, "Divisão");
            dica.SetToolTip(btnIgual, "Calcular");
            dica.SetToolTip(btnSegue, "Seguir");
            dica.SetToolTip(btnNegar, "Negar");
            dica.SetToolTip(btnInvert, "Inverter");
            dica.SetToolTip(btnLimpa, "Limpar");
        }

        void AtribuirOperador(string operador)
        {
            lblOper.Text = operador;
            btnIgual.Enabled = true;
            MostrarResultado();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btnSoma.Text);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btnSub.Text);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btnMult.Text);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btnDiv.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void btnSegue_Click(object sender, EventArgs e)
        {
            if (!(long.TryParse(lblResultado.Text, out _)))
            {
                lblResultado.Text = "Valor de 'Seguir' estourado";
                btnIgual.Enabled = false;
                btnSegue.Enabled = false;
                btnNegar.Enabled = false;
            }
            else
                numOper1.Value = Decimal.Parse(lblResultado.Text);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            numOper1.Value = 0;
            numOper2.Value = 0;
            lblOper.Text = "...";
            TravarResultado();
            lblResultado.Text = "Selecione uma operação";
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            numOper1.Value += numOper2.Value;
            numOper2.Value = numOper1.Value - numOper2.Value;
            numOper1.Value -= numOper2.Value;
        }

        private void btnNegar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = ((Double.Parse(lblResultado.Text)) * (-1)).ToString();
            if (lblNeg.Text != "(Negado)")
                lblNeg.Text = "(Negado)";
            else
                lblNeg.Text = "";
        }

        void MostrarResultado()
        {
            if (lblOper.Text != "...")
            {
                double num1, num2, resultado;
                num1 = (double)numOper1.Value;
                num2 = (double)numOper2.Value;

                if (lblOper.Text == btnSoma.Text)
                    resultado = num1 + num2;
                else if (lblOper.Text == btnSub.Text)
                    resultado = num1 - num2;
                else if (lblOper.Text == btnMult.Text)
                    resultado = num1 * num2;
                else resultado = num1 / num2;

                lblResultado.Text = resultado.ToString();
                btnSegue.Enabled = true;
                btnNegar.Enabled = true;
                lblNeg.Text = "";
                TravarResultado();
            }
        }

        void TravarResultado()
        {
            if ((lblOper.Text == btnDiv.Text && numOper2.Value == 0) || lblOper.Text == "...")
            {
                lblResultado.Text = "Operação não realizável";
                btnIgual.Enabled = false;
                btnSegue.Enabled = false;
                btnNegar.Enabled = false;
            }
        }

        private void numOper2_ValueChanged(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void numOper1_ValueChanged(object sender, EventArgs e)
        {
            MostrarResultado();
        }
    }
}