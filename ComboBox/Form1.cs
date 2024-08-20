using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void texto_Click(object sender, EventArgs e)
        {

        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            //Adiciona Itens manualmente no ComboBox
            cboLista.Items.Add(txtTexto.Text);

            //Exibe a quantidade de itens do ComboBox
            lblQuantidade.Text = cboLista.Items.Count.ToString();

            //Limpa a caixa de texto
            txtTexto.Clear();

            //Move o foco para a caixa de texto
            txtTexto.Select();
        }

        private void Ordenar_Click(object sender, EventArgs e)
        {
            //Ativa a propriedade para
            //Ordenar a lista no combo
            cboLista.Sorted = true;
        }

        private void btncombo_Click(object sender, EventArgs e)
        {
            //Verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                //Remove o item selecionado do combo
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);
                //Exibe a quantidade de itens do ComboBox
                lblQuantidade.Text = cboLista.Items.Count.ToString();
                //Limpa o texto do combo
                cboLista.ResetText();
            }
        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void txtIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //Verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                //Exibe o conteúdo (texto do combo)
                txtConteudo.Text = cboLista.SelectedItem.ToString();
                //Exibe o índice (posição) do item no combo
                txtIndice.Text = cboLista.SelectedIndex.ToString();
            }
        }

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
