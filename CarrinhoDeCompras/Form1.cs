using System.Collections.Generic;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static CarrinhoDeCompras.Form1;
namespace CarrinhoDeCompras
{
    public partial class Form1 : Form
    {
        internal class Produtos
        {
            public string nome;
            public double preco;
        }
        List<Produtos> ListaCompras = new List<Produtos>();
        public Form1()
        {
            InitializeComponent();
            SomarCompras();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Produtos> ListaProdutos = new List<Produtos>();

            ListaProdutos = new List<Produtos>
            {
                new Produtos() {nome = "Celular", preco = 2500.90 },
                new Produtos() {nome = "Notebook", preco = 2900.80 },
                new Produtos() {nome = "Mouse", preco = 250.50},
                new Produtos() {nome = "Monitor", preco = 750.00},
                new Produtos() {nome = "Computador", preco = 4750.99},
                new Produtos() {nome = "Headset", preco = 220.50}
            };
            foreach (Produtos p in ListaProdutos)
            {
                lstProdutos.Items.Add(Organizador(p));
            }
            lstProdutos.Tag = ListaProdutos;
        }
        private String Organizador(Produtos p)
        {
            return string.Format("{0,-10} {1,20:C2}", p.nome, p.preco);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(
                    "Deseja adicionar esse produto ? ",
                    "Valida��o",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var produtos = (List<Produtos>)lstProdutos.Tag;
                    int index = lstProdutos.SelectedIndex;
                    Produtos produtoSelecionado = produtos[index];

                    lstCompras.Items.Add(Organizador(produtoSelecionado));
                    ListaCompras.Add(produtoSelecionado);
                    SomarCompras();
                }

            }
            else
            {
                MessageBox.Show(
                    "Selecione um Produto para adicionar!",
                    "Informa��o",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCompras.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(
                    "Deseja remover esse produto ?",
                    "Valida��o",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = lstCompras.SelectedIndex;

                    lstCompras.Items.RemoveAt(index);
                    ListaCompras.RemoveAt(index);
                    SomarCompras();
                }
                else
                {
                    MessageBox.Show(
                        "O produto n�o foi removido",
                        "Informa��o",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecione um produto para remover!",
                    "Informa��o",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        public void SomarCompras()
        {
            double total = 0;
            foreach (var item in lstCompras.Items)
            {                
                var produtos = (List<Produtos>)lstProdutos.Tag;

                foreach (var produto in produtos)
                {
                    if (Organizador(produto) == item.ToString())
                    {
                        total += produto.preco;
                    }
                } 
            }
            lbltotal.Text = "Total:" + total.ToString("R$ " + "0.00");
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            if (lstCompras.Items.Count > 0) 
            {
                if (MessageBox.Show("Deseja finalizar a compra no valor " + lbltotal.Text + " ?" ,
                    "Valida��o",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question ) == DialogResult.Yes)
                {
                    lstCompras.Items.Clear();
                    SomarCompras();
                    MessageBox.Show("Compra finalizada com sucesso!",
                        "Informa��o",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Adicione pelo menos um item",
                    "Informa��o",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information );
            }
        }
    }
}
