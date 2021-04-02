using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace renomeador
{
    public partial class frmrenomeador : Form
    {
        public frmrenomeador()
        {
            InitializeComponent();

            Load += Frmrenomeador_Load;


            // teste de versao


        }



        configuracao configuracao;

        string configtxt = "config.txt";


        private void Frmrenomeador_Load(object sender, EventArgs e)
        {

            if (File.Exists(configtxt))
            {
                try
                {
                    configuracao = serializador.lerarquivo<configuracao>(configtxt, false);
                }
                catch (Exception)
                {
                    configuracao = new configuracao();
                }
            }
            else
            {
                configuracao = new configuracao()
                {
                    alteracoes = new List<alteracao>()
                    {
                        new alteracao("(u)",""),
                        new alteracao("[!]",""),
                        new alteracao("_",""),
                        new alteracao("&",""),
                        new alteracao("'",""),
                        new alteracao("(eng) # snes",""),
                        new alteracao("(e)",""),
                        new alteracao(" (v1.1)",""),
                        new alteracao(" (v1.0)",""),
                        new alteracao("(usa)",""),
                        new alteracao("(j)",""),
                        new alteracao("[t1]",""),
                        new alteracao(" # GBA".ToLower(),""),
                        new alteracao("(m3)",""),
                        new alteracao(" (usa, australia)",""),
                        new alteracao(" .","."),
                        new alteracao(" (U) [C][!]".ToLower(),""),
                        new alteracao("[c]".ToLower(),""),
                    }
                };

                serializador.salvararquivo(configuracao, configtxt, Formatting: Newtonsoft.Json.Formatting.Indented);
            }


            grdalteracoes.DataSource = configuracao.alteracoes;
            chkmaisculo.Checked = configuracao.maisculo;
            chkminusculo.Checked = configuracao.minusculo;
            chkremoverseigual.Checked = configuracao.removerseigual;
            tbdireitorio.Text = configuracao.diretorio;
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            (grdalteracoes.DataSource as List<alteracao>).Add(new alteracao());
            grdalteracoes.RefreshDataSource();
            grvalteracoes.BestFitColumns();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            try
            {
                var alteracao = grvalteracoes.GetFocusedRow() as alteracao;
                (grdalteracoes.DataSource as List<alteracao>).Remove(alteracao);
                grdalteracoes.RefreshDataSource();
                grvalteracoes.BestFitColumns();
            }
            catch
            { }
        }

        private void btnrenomear_Click(object sender, EventArgs e)
        {
            var mensagem = $"realizar alteracoes no diretorio {tbdireitorio.Text}?";

            if (MessageBox.Show(mensagem, "confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    tbdireitorio.Enabled = grdalteracoes.Enabled =
                    btnadicionar.Enabled = btndiretorio.Enabled = btnremover.Enabled = btnrenomear.Enabled =
                        chkmaisculo.Enabled = chkminusculo.Enabled = chkremoverseigual.Enabled = false;

                    configuracao.removerseigual = chkremoverseigual.Checked;
                    configuracao.maisculo = chkmaisculo.Checked;
                    configuracao.minusculo = chkminusculo.Checked;
                    configuracao.diretorio = tbdireitorio.Text;
                    configuracao.alteracoes = (grdalteracoes.DataSource as List<alteracao>);

                    serializador.salvararquivo(configuracao, configtxt, Formatting: Newtonsoft.Json.Formatting.Indented);


                    int i = 0;
                    var arquivos = Directory.GetFiles(tbdireitorio.Text);

                    foreach (var arquivo in arquivos)
                    {
                        var _arquivo = arquivo;
                        try
                        {
                            if (chkminusculo.Checked)
                                _arquivo = arquivo.ToLower();

                            if (chkmaisculo.Checked)
                                _arquivo = arquivo.ToUpper();

                            foreach (var alteracao in (grdalteracoes.DataSource as List<alteracao>))
                            {
                                _arquivo.Replace(alteracao.antigo, alteracao.novo);

                            }


                            tbalteracoes.Text += "antigo: " + arquivo + Environment.NewLine;
                            tbalteracoes.Text += "novo: " + _arquivo + Environment.NewLine;
                            tbalteracoes.SelectionStart = tbalteracoes.TextLength;
                            tbalteracoes.ScrollToCaret();

                            File.Move(arquivo, _arquivo);

                            i++;

                            Application.DoEvents();
                        }
                        catch (Exception)
                        {
                            if (configuracao.removerseigual)
                                File.Delete(arquivo);
                        }
                    }

                    MessageBox.Show(string.Format("processo finalizado!{0}total de arquivo: {1}{0}alterados: {2}",
                        Environment.NewLine, arquivos.Length, i), "informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    tbdireitorio.Enabled = grdalteracoes.Enabled =
                    btnadicionar.Enabled = btndiretorio.Enabled = btnremover.Enabled = btnrenomear.Enabled =
                      chkmaisculo.Enabled = chkminusculo.Enabled = chkremoverseigual.Enabled = true; ;
                }
            }
        }

        private void chkminusculo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkminusculo.Checked)
            {
                if (chkmaisculo.Checked)
                    chkmaisculo.Checked = false;
            }
        }

        private void chkmaisculo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmaisculo.Checked)
            {
                if (chkminusculo.Checked)
                    chkminusculo.Checked = false;
            }
        }

        private void btndiretorio_Click(object sender, EventArgs e)
        {
            try
            {
                var browser = dialog.browser();
                if (browser != null)
                    tbdireitorio.Text = browser.SelectedPath;
            }
            catch
            { }
        }
    }
}
