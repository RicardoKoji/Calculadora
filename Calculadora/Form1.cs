using System.Reflection;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal numero1, numero2;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            operacao = "";
            numero1 = 0; 
            numero2 = 0;
            lblHistorico.Text = " ";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            GerarStringTxResultado("1");
        }
        public void GerarStringTxResultado(string textoAcrescentar)
        {
            if (txtResultado.Text == "0" && textoAcrescentar != ",")
            {
                txtResultado.Text = textoAcrescentar;
            }
            else
            {
                txtResultado.Text += textoAcrescentar;
            }
            lblHistorico.Text += textoAcrescentar;

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            GerarStringTxResultado("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            GerarStringTxResultado("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            GerarStringTxResultado("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            GerarStringTxResultado("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            GerarStringTxResultado("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            GerarStringTxResultado("7");

        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            GerarStringTxResultado("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            GerarStringTxResultado("9");
        }

        private void btntPonto_Click(object sender, EventArgs e)
        {
            //contains (!) vai verificar se existe esse(s)m caracteres dentro da string
            //vou verificar se não existe um ponto(.)
            //contains (!) se o ponto for digitado ele nao irar mas digitar o mesmo
            if (!txtResultado.Text.Contains(","))
            {
                GerarStringTxResultado(",");
            }
        }
        public void CalcularOperacao()
        {
            decimal resultado = 0;
            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    break;
            }
            txtResultado.Text = resultado.ToString();

            lblHistorico.Text += " = " + resultado;

            operacao = "";
        }
        public void CriaOperacao(string operacaoParamentro)
        {
            if (operacao != "")
            {
                numero2 = Convert.ToDecimal(txtResultado.Text);
                CalcularOperacao();
            }
            operacao = operacaoParamentro;
            numero1 = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "0";

            lblHistorico.Text += " " + operacao + " ";
        }

        private void btnSubritacao_Click(object sender, EventArgs e)
        {
            CriaOperacao("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            CriaOperacao("*");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            CriaOperacao("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDecimal(txtResultado.Text);
            CalcularOperacao();
        }

        private void btnSoma_Click_1(object sender, EventArgs e)
        {
            CriaOperacao("+");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntZero_Click(object sender, EventArgs e)
        {
            GerarStringTxResultado("0");
        }

        private void btnAlteraSinal_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Contains("-"))
            {
                //Remove é método capaz de remover um ou mais caracteres de uma string 
                // ex: foi colocado o 0 e 1 dentro de um parentes por que um acrecenta e o 
                // outro substitui o primeiro numero ou sinais.
                //informe o indice que ele inicia a remoção e a quantidade de caracteres 

                txtResultado.Text = txtResultado.Text.Remove(0, 1);
                lblHistorico .Text = "(" + lblHistorico .Text + ") * -1 ";
            }
            else
            {
                if (Convert.ToDecimal(txtResultado.Text) != 0)
                {
                    txtResultado.Text = "-" + txtResultado.Text;
                    lblHistorico.Text = "(" + lblHistorico.Text + ") * -1 ";
                }
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}