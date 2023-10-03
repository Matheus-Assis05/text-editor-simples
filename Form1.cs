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

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MENU ARQUIVO: NOVO

            conteudoTxt.Clear(); //limpa todo o conteudo da txtbox
            
            OpenFileDialog abrirArquivo = new OpenFileDialog(); //método para abrir arquivos
            abrirArquivo.Title = "Selecione um arquivo...";
            abrirArquivo.Filter = "Text Document (*.txt) | *.txt|All Files(*.*)| *.*"; //filtra para o usuario procurar por .txt's

            if(abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                conteudoTxt.LoadFile(abrirArquivo.FileName, RichTextBoxStreamType.PlainText); //Carrega o arquivo de texto para a txtbox
                this.Text = abrirArquivo.FileName;
            }
            else
            {
                MessageBox.Show("ERRO AO CARREGAR O ARQUIVO");
            }

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MENU ARQUIVO: SALVAR

            SaveFileDialog salvarArquivo = new SaveFileDialog(); //método que salva arquivos da mesma forma do que abre
            salvarArquivo.Title = "Salvar Arquivo";
            salvarArquivo.Filter = "Text Document (*.txt) | *.txt|All Files(*.*)| *.*";

            if(salvarArquivo.ShowDialog() == DialogResult.OK)
            {
                conteudoTxt.SaveFile(salvarArquivo.FileName, RichTextBoxStreamType.PlainText);
                this.Text = salvarArquivo.FileName;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conteudoTxt.Undo();
        }

        private void refazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conteudoTxt.Redo();
        }

        private void conteudoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bem auto-explicativo

            FontDialog fonte = new FontDialog();
            if (fonte.ShowDialog() == DialogResult.OK)
            {
                conteudoTxt.Font = fonte.Font;
            }
        }

        private void coresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cores = new ColorDialog();
            if(cores.ShowDialog() == DialogResult.OK)
            {
                conteudoTxt.ForeColor = cores.Color;
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conteudoTxt.Copy();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conteudoTxt.Paste();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conteudoTxt.Cut();
        }

        private void selecionarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conteudoTxt.SelectAll();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clone do notepad do windows feito por github.com/Matheus-Assis05 - 👍");
        }
    }
}
