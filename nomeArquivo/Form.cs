using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nomeArquivo
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            tbxEn.Text = string.Empty;

            try
            {
                if(folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    tbxEn.Text = folderBrowserDialog1.SelectedPath;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Alerta de Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbxEn.Text.Trim() == string.Empty)
                {
                    throw new Exception("Selecione a pasta para efetivar a troca de arquivo");
                }

                if (tbxDe.Text.Trim() == string.Empty) 
                {
                    throw new Exception("Informe o valor para a troca.");
                }

                System.IO.FileInfo[] arquivos = new System.IO.DirectoryInfo(tbxEn.Text).GetFiles();

                foreach (var arquivo in arquivos)
                {
                    string novoNome = tbxEn.Text + "\\" + arquivo.Name.Replace(tbxDe.Text, tbxPa.Text);

                    if (!System.IO.File.Exists(novoNome))
                    {
                        arquivo.CopyTo(novoNome);
                        arquivo.Delete();
                    }
                }
                MessageBox.Show("Troca de nome de arquivo efetuada com sucesso...", "aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
