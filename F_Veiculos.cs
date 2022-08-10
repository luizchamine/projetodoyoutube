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
    public partial class F_Veiculos : Form//a nova classe F_Veiculos extende a classe Form
    {
        F_Principal fp;//criacão de um objeto de outra classe tipo F_Principal.
        public F_Veiculos(string v, F_Principal f)//todo o objeto formulário de F_Principal será passado como parâmetro por aqui.
        {
            InitializeComponent();//"inicialização dos componentes?".
            tb_listaveiculos.Text = v;//a text box listaveiculos recebe os dados do formulário principal através do parâmetro string v.
            
            f.num += 1;

            fp = f;// a variável local f do tipo F_Principal com escopo local foi atribuída á variável fp do tipo F_principal porém com escopo global .
            //todos os dados do formulário f foram copiados para o formulário fp.
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)//formclosed acontece quando a janela é fechada.
        {
            fp.tb_listaveiculos.Text = tb_listaveiculos.Text; //os componentes podem ter os mesmos nomes desde que estejam em classes diferentes.
        }
    }
}
