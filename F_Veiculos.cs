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
    public partial class F_Veiculos : Form
    {
        F_Principal fp;
        public F_Veiculos(string v, F_Principal f)
        {
            InitializeComponent();
            tb_listaveiculos.Text = v;
            
            fp = f;
            f.num += 1;
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaveiculos.Text = tb_listaveiculos.Text; 
        }
    }
}
