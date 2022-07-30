using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetodoyoutube
{
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void bnt_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Isso aqui é uma messagebox.show('string')\no campo está vazio!");
                tb_veiculo.Focus(); // foco de entrada de dados pelo teclado
                return;
            }
            else
            {
                tb_listaveiculos.Text+=tb_veiculo.Text+ ", ";
                tb_veiculo.Clear();
                tb_veiculo.Focus();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaveiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaveiculos.Text,this);//a classe F_Veiculos precisa de 2 argumentos para ser instanciada:
                                                            //o primeiro é do tipo String e o segundo é do tipo F_Principal
                                                            //this está se referindo a este próprio formulário!
            //f_Veiculos.Show(); // utilizando show, eu consigo abrir inúmeras janelas! 
            f_Veiculos.ShowDialog(); // com showdialog, somente uma janela pode ser aberta!     
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }
    }
}
