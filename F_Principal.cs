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
    public partial class F_Principal : Form//a classe f_Principal extende a classe Form
    {
        public int num;//contador apenas para fins didáticos
        public F_Principal()
        {
            InitializeComponent();//"inicialização dos componentes"?
            num = 0;//após a inicialização, o valor 0 será atribuído a variável num
        }

        private void bnt_adicionar_Click(object sender, EventArgs e)//criação de um evento adicionar após clique no botão adicionar
        {
            if(tb_veiculo.Text == "")//verificação para saber se o campo de preenchimento está vazio
            {
                MessageBox.Show("Isso aqui é uma messagebox.show('string')\no campo está vazio!");//message.show serve para mostrar menssagens na tela
                tb_veiculo.Focus(); // foco de entrada de dados pelo teclado
                return;//o comando return faz a continuação do método ser cancelada
            }
            else
            {
                tb_listaveiculos.Text+=tb_veiculo.Text+ ", ";//caso tenha algum dado, então esse dado irá ser copiado para a text box
                tb_veiculo.Clear();//limpar text box
                tb_veiculo.Focus();//focar text box
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)//método para limpar todos os campos
        {
            tb_listaveiculos.Clear();//limpar text box
            tb_veiculo.Clear();//limpar text box
            tb_veiculo.Focus();//focar text box
        }

        private void btn_mostrar_Click(object sender, EventArgs e)//botão para mostrar os registros em outro formulário
        {
            //para que seja utilizado outro formulário, é necessário que o mesmo deva ser instanciado através da criação de um novo objeto
            //do tipo da classe do formulário de destino.
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaveiculos.Text,this);//a classe F_Veiculos precisa de 2 argumentos para ser instanciada:
                                                            //o primeiro é do tipo String e o segundo é do tipo F_Principal
                                                            //this está se referindo a este próprio formulário!

            f_Veiculos.ShowDialog(); // com showdialog, somente uma janela pode ser aberta!     
            //f_Veiculos.Show(); // utilizando show, eu consigo abrir inúmeras janelas! 
        }

        private void btn_valNum_Click(object sender, EventArgs e)//apenas para mostrar o valor da variável num
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkedLstBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();

        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void dateTimerPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void labelLinkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }
    }
}
