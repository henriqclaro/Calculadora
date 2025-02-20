using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        void AtribuirOperador(string operador)
        {
            lblOper.Text = operador;
            btnIgual.Enabled = true;
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
            TravarResultado();
        }

        private void btnIgual_Click(object sender, EventArgs e)
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
        }

        void TravarResultado()
        {
            btnIgual.Enabled = !((lblOper.Text == btnDiv.Text && numOper2.Value == 0) || lblOper.Text == "...");
        }

        private void numOper2_ValueChanged(object sender, EventArgs e)
        {
            TravarResultado();
        }
    }
}
