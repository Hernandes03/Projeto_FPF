using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetos
{
    public partial class Form1 : Form
    {
        List<Projetos> projeto;

        public Form1()
        {
            InitializeComponent();

            projeto = new List<Projetos>();

            cbRisco.Items.Add("0 - baixo");
            cbRisco.Items.Add("1 - médio");
            cbRisco.Items.Add("2 - alto");

            cbRisco.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (Projetos pj in projeto)
            {
                if (pj.nome_projeto == tbNomeProjeto.Text)
                {
                    index = projeto.IndexOf(pj);
                }
            }

            if (tbNomeProjeto.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome do projeto");
                tbNomeProjeto.Focus();
                return;
            }

            if (mtbDI.Text == "  /  /")
            {
                MessageBox.Show("Preencha o campo Data de início do projeto");
                mtbDI.Focus();
                return;
            }

            if (mtbDT.Text == "  /  /")
            {
                MessageBox.Show("Preencha o campo Data de término do projeto");
                mtbDT.Focus();
                return;
            }

            if (tbVP.Text == "")
            {
                MessageBox.Show("Preencha o campo Valor do Projeto");
                tbVP.Focus();
                return;
            }

            if (cbRisco.Text == "")
            {
                MessageBox.Show("Preencha o campo Risco");
                cbRisco.Focus();
                return;
            }

            Projetos p = new Projetos();

            p.nome_projeto = tbNomeProjeto.Text;
            p.data_inicio = mtbDI.Text;
            p.data_termino = mtbDT.Text;
            p.valor = tbVP.Text;
            p.risco = cbRisco.SelectedItem.ToString();
            p.participantes = tbParticipantes.Text;

            if (index < 0)
            {
                projeto.Add(p);
            }
            else
            {
                projeto[index] = p;
            }

            btEditar.Enabled = true;
            btSimular.Enabled = true;
            btExcluir.Enabled = true;
            btLimpar.Enabled = true;

            btLimpar_Click(btLimpar, EventArgs.Empty);
            Listar();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int listado = lbLista.SelectedIndex;
            projeto.RemoveAt(listado);

            MessageBox.Show("Projeto excluído com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
        }

        private void btSimular_Click(object sender, EventArgs e)
        {
            int indice = lbLista.SelectedIndex;
            Projetos pj = projeto[indice];

            tbVP.Text = pj.valor;
            cbRisco.SelectedItem = pj.risco;

            double retorno = 0;
            double valor = 0;

            valor = Convert.ToDouble(pj.valor);

            if (cbRisco.SelectedIndex == 0)
            {
                retorno = (valor * 5) / 100;
                MessageBox.Show("R$" + retorno, "O retorno de investimento é:");
                btLimpar_Click(btLimpar, EventArgs.Empty);
            }

            else if (cbRisco.SelectedIndex == 1)
            {
                retorno = (valor * 10) / 100;
                MessageBox.Show("R$" + retorno, "O retorno de investimento é:");
                btLimpar_Click(btLimpar, EventArgs.Empty);
            }

            else if (cbRisco.SelectedIndex == 2)
            {
                retorno = (valor * 20) / 100;
                MessageBox.Show("R$" + retorno, "O retorno de investimento é:");
                btLimpar_Click(btLimpar, EventArgs.Empty);
            }

            btCadastrar.Enabled = true;
            btEditar.Enabled = false;
            btSimular.Enabled = false;
            btExcluir.Enabled = true;
            btLimpar.Enabled = true;

        }

        private void Listar()
        {
            lbLista.Items.Clear();

            foreach (Projetos p in projeto)
            {
                lbLista.Items.Add(p.nome_projeto);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNomeProjeto.Text = "";
            mtbDI.Text = "";
            mtbDT.Text = "";
            tbVP.Text = "";
            cbRisco.SelectedIndex = 0;
            tbParticipantes.Text = "";
            tbNomeProjeto.Focus();

            btEditar.Enabled = false;
            btSimular.Enabled = false;
            btExcluir.Enabled = true;
            btLimpar.Enabled = false;
        }

        private void lbLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = lbLista.SelectedIndex;
            Projetos pj = projeto[indice];

            tbNomeProjeto.Text = pj.nome_projeto;
            mtbDI.Text = pj.data_inicio;
            mtbDT.Text = pj.data_termino;
            tbVP.Text = pj.valor;
            cbRisco.SelectedItem = pj.risco;
            tbParticipantes.Text = pj.participantes;

            btCadastrar.Enabled = false;
            btEditar.Enabled = true;
            btSimular.Enabled = true;
            btExcluir.Enabled = true;
            btLimpar.Enabled = true;


        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (Projetos pj in projeto)
            {
                if (pj.nome_projeto == tbNomeProjeto.Text)
                {
                    index = projeto.IndexOf(pj);
                }
            }

            Projetos p = new Projetos();

            p.nome_projeto = tbNomeProjeto.Text;
            p.data_inicio = mtbDI.Text;
            p.data_termino = mtbDT.Text;
            p.valor = tbVP.Text;
            p.risco = cbRisco.SelectedItem.ToString();
            p.participantes = tbParticipantes.Text;

            if (index < 0)
            {
                projeto.Add(p);
            }
            else
            {
                projeto[index] = p;
            }

            btLimpar_Click(btLimpar, EventArgs.Empty);
            Listar();

            btCadastrar.Enabled = true;
            btEditar.Enabled = false;
            btSimular.Enabled = false;
            btExcluir.Enabled = true;
            btLimpar.Enabled = true;

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Visible = false;
            pbLogo1.Visible = false;
            gbCadastro.Visible = true;
        }
    }
}
