using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_editor_simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Receber o texto digitado pelo o usuario e atribui-lo a um valor
        }
      

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pegar o texto do usuario e criar um arquivo de texto com o conteudo
        }

        private void salvarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Salvar no diretorio do arquivo relacionado o texto digitado
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir um pop-up contendo informacoes do projeto
        }
    }
}
