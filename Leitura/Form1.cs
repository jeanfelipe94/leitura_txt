using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.IO;

namespace Leitura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void bntAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbrirComo = new OpenFileDialog();
            DialogResult Caminho;
            StreamReader fluxotexto;
            string arquivo;
            int registro = 0;

            AbrirComo.Title = "Abrir Como";
            AbrirComo.FileName = "Nome Arquivo";
            AbrirComo.Filter = "Arquivos Textos (*.txt)|*.txt";
            Caminho = AbrirComo.ShowDialog();
            arquivo = AbrirComo.FileName;


            if (arquivo == " ")

            {
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK);
            }

            else

            {
                fluxotexto = new StreamReader(arquivo);
                string linhatexto = fluxotexto.ReadLine();

                while (linhatexto != null)

                {
                    linhatexto = fluxotexto.ReadLine();
                    registro = registro + 1;
                }

                txtArquivo.Text = AbrirComo.FileName;
                fluxotexto.Close();
                txtRegistro.Text = registro.ToString();
                lblMensagem.Text = "Arquivo lido!";
            } 
        }

        private void bntGravar_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtArquivo.Text))

            {
                using (StreamReader fluxotexto = new StreamReader(txtArquivo.Text))

                while (true)

                    {
                        string linhatexto = fluxotexto.ReadLine(); 


                        if (linhatexto == null)
                        {
                            break;
                        }

                        if (linhatexto.StartsWith("Serie"))
                        {
                            string[] quebraSerie = linhatexto.Split(new Char[] { ':' });
                            Cabecalhos.QuebraSerieLista = quebraSerie[1];
                        }

                        if (linhatexto.StartsWith("Endereço"))
                        {
                            string[] quebraEndereco = linhatexto.Split(new Char[] { ':' });
                            Cabecalhos.QuebraEnderecoLista = quebraEndereco[1];
                        }

                        if (linhatexto.StartsWith("Descrição"))
                        {
                            string[] quebraDescricao = linhatexto.Split(new Char[] { ':' });
                            Cabecalhos.QuebraDescricaoLista = quebraDescricao[1];
                        }

                        if (linhatexto.StartsWith("IA"))
                        {
                            string[] quebraIA = linhatexto.Split(new Char[] { ':' });
                            Cabecalhos.QuebraIALista = quebraIA[1];
                        }

                        if (linhatexto.StartsWith("MA"))
                        {
                            string[] quebraMA = linhatexto.Split(new Char[] { ':' });
                            Cabecalhos.QuebraMALista = quebraMA[1];
                        }

                        if (linhatexto.StartsWith("FP"))
                        {
                            string[] quebraFP = linhatexto.Split(new Char[] { ':' });
                            Cabecalhos.QuebraFPLista = quebraFP[1];
                        }

                        if (linhatexto.StartsWith("DA"))
                        {
                            string[] quebraDA = linhatexto.Split(new Char[] { ':' });
                            Cabecalhos.QuebraDALista = quebraDA[1];
                        }

                        if (linhatexto.StartsWith("EA+"))
                        {
                            string[] quebraEA = linhatexto.Split(new Char[] { ':' });
                            Cabecalhos.QuebraEALista = quebraEA[1];
                        }

                        if (!linhatexto.Contains("Bloco") && !linhatexto.Contains("Serie") && !linhatexto.Contains("Endereço") && !linhatexto.Contains("Descrição") && !linhatexto.Contains("IA") && !linhatexto.Contains("MA") && !linhatexto.Contains("FP") && !linhatexto.Contains("DA") && !linhatexto.Contains("EA+"))
                        {
                            string[] quebra = linhatexto.Split(new Char[] { ';' });
                            cadastraItens(quebra[0], quebra[1], quebra[2], quebra[3], quebra[4], quebra[5], quebra[6], Cabecalhos.QuebraSerieLista);
                        }
                    }

                        cadastraCabecalho(Cabecalhos.QuebraSerieLista, Cabecalhos.QuebraEnderecoLista, Cabecalhos.QuebraDescricaoLista, Cabecalhos.QuebraIALista, Cabecalhos.QuebraMALista, Cabecalhos.QuebraFPLista, Cabecalhos.QuebraDALista, Cabecalhos.QuebraEALista);
            }

            else
            {
                MessageBox.Show("Arquivo não existe");
            }
        }

        private void cadastraItens(string bloco, string data, string hora, string fp, string da, string ea, string cs, string serie)

        {
            string strConn = "Server=localhost;Database=DBTxt;User ID=sa;Password=@nfs32xpt#; Min Pool Size=5;Max Pool Size=10000; Connect Timeout=100";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strSql = "Insert into FaneItens (bloco, data, hora, fp, da, ea, cs, serie) Values (@bloco ,@data, @hora, @fp, @da, @ea, @cs, @serie)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@bloco", bloco);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@fp", fp);
            cmd.Parameters.AddWithValue("@da", da);
            cmd.Parameters.AddWithValue("@ea", ea);
            cmd.Parameters.AddWithValue("@cs", cs);
            cmd.Parameters.AddWithValue("@serie", serie);
            cmd.Connection = conn;
            cmd.CommandText = strSql;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            lblMensagem.Text = "Arquivo gravado com sucesso!";
        }

        private void cadastraCabecalho(string serie, string endereco, string descricao, string IA, string MA, string FP, string DA, string EA)

        {
            string strConn = "Server=localhost;Database=DBTxt;User ID=sa;Password=@nfs32xpt#; Min Pool Size=5;Max Pool Size=10000; Connect Timeout=100";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strSql = "Insert into FaneCabecalho (Serie, Endereco, Descricao, IA, MA, FP, DA, EA) Values (@serie, @endereco, @descricao, @IA, @MA, @FP, @DA, @EA)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@serie", serie);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@IA", IA);
            cmd.Parameters.AddWithValue("@MA", MA);
            cmd.Parameters.AddWithValue("@FP", FP);
            cmd.Parameters.AddWithValue("@DA", DA);
            cmd.Parameters.AddWithValue("@EA", EA);
            cmd.Connection = conn;
            cmd.CommandText = strSql;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            lblMensagem.Text = "Arquivo gravado com sucesso!";
        }
    }
}
