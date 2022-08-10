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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiplosLinks.Links.Add(0, 6,"www.google.com");//começa na posição 0 e tem tamanho de 6 caracteres
            ll_multiplosLinks.Links.Add(9, 5, "www.youtube.com/canal");//'' 9 '' 5 ''
            ll_multiplosLinks.Links.Add(17, 7, "www.youtube.com");//'' 17 '' 7 ''

            ll_multiplosLinks.Links[1].Enabled = false;//desabilitar algum link especificado pela posição no vetor

        }

        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtube.com");//comando para abrir uma nova janela através de um link

            LinkLabel ll = (LinkLabel)sender;   //criando um objeto do tipo LinkLabel para deixar tudo mais genérico
            ll.LinkVisited = true;//deixar o label roxo após clicar nele (apenas efeito visual)
            /*
            ll_canal.LinkVisited = true;//outra forma de realizar os comandos acima
            */
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");//chamando um outro programa já instalado no windows
        }

        private void ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());//programando os multiplos links normalmente
            e.Link.Visited = true;//colorindo de roxo aqueles que forem clicados (apenas efeito visual)
        }
    }
}
