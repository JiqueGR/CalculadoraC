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
        string tela = " ";
        string valor1 = " ";
        string valor2 = " ";
        char operacao = ' ';
        float valor;
        char[] caracteres = { '+', '-', '*', '/' };

        public Form1()
        {
            InitializeComponent();
            txtTela.ReadOnly = true;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tela = txtTela.Text;
            tela = tela + "0";
            txtTela.Text = tela;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tela = txtTela.Text;
            tela = tela + "1";
            txtTela.Text = tela;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tela = txtTela.Text;
            tela = tela + "2";
            txtTela.Text = tela;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            tela = txtTela.Text;
            tela = tela + "3";
            txtTela.Text = tela;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tela = txtTela.Text;
            tela = tela + "4";
            txtTela.Text = tela;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tela = txtTela.Text;
            tela = tela + "5";
            txtTela.Text = tela;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tela = txtTela.Text;
            tela = tela + "6";
            txtTela.Text = tela;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tela = txtTela.Text;
            tela = tela + "7";
            txtTela.Text = tela;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tela = txtTela.Text;
            tela = tela + "8";
            txtTela.Text = tela;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tela = txtTela.Text;
            tela = tela + "9";
            txtTela.Text = tela;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            verificaOperacao('+');
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            verificaOperacao('-');
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            verificaOperacao('*');
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            verificaOperacao('/');
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                tela = txtTela.Text;
                string[] texto = tela.Split(operacao);
                valor1 = texto[0];
                valor2 = texto[1];
                switch (operacao)
                {
                    case '+':
                        valor = float.Parse(valor1) + float.Parse(valor2);
                        txtTela.Text = valor.ToString();
                        valor2 = " ";
                        operacao = ' ';
                        break;

                    case '-':
                        valor = float.Parse(valor1) - float.Parse(valor2);
                        txtTela.Text = valor.ToString();
                        valor2 = " ";
                        operacao = ' ';
                        break;

                    case '*':
                        valor = float.Parse(valor1) * float.Parse(valor2);
                        txtTela.Text = valor.ToString();
                        valor2 = " ";
                        operacao = ' ';
                        break;

                    case '/':
                        valor = float.Parse(valor1) / float.Parse(valor2);
                        txtTela.Text = valor.ToString();
                        valor2 = " ";
                        operacao = ' ';
                        break;
                }
            }
            catch
            {

            }    
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            tela = " ";
            valor1 = " ";
            valor2 = " ";
            operacao = ' ';
            txtTela.Text = tela;
        }

        

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            string[] texto = tela.Split(operacao);
            if (texto.Length == 2)
            {
                if (texto[1].Length == 0)
                {
                    txtTela.Text = txtTela.Text + "0";
                    tela = txtTela.Text;
                    tela = tela + ",";
                    txtTela.Text = tela;
                }
                else if (!texto[1].Contains(","))
                {
                    tela = txtTela.Text;
                    tela = tela + ",";
                    txtTela.Text = tela;
                }
            }
        }
        private void verificaOperacao(char operacao)
        {
            string[] texto = tela.Split(this.operacao);
            if(texto.Length == 2 && texto[1] != "")
            {
                btnIgual_Click(this, EventArgs.Empty);
                tela = txtTela.Text;
                tela = tela + operacao;
                txtTela.Text = tela;
                this.operacao = operacao;
            }
            else if(tela != " ")
            {
                if (this.operacao == ' ')
                {
                    tela = txtTela.Text;
                    tela = tela + operacao;
                    txtTela.Text = tela;
                    this.operacao = operacao;
                }
                else if (this.operacao != ' ' && valor2 == " ")
                {
                    tela = txtTela.Text;
                    tela = tela.Substring(0, tela.Length - 1);
                    tela = tela + operacao;
                    txtTela.Text = tela;
                    this.operacao = operacao;
                }
            }
        }
    }
}
