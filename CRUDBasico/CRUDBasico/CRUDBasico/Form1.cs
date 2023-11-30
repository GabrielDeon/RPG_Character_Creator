using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace CRUDBasico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimparForm()
        {
            txCodigo.Clear();
            txNome.Clear();
            dtNascimento.Value = DateTime.Now;
            mtxCPF.Clear();
            txIdade.Clear();
            txAltura.Clear();
            txPeso.Clear();
            txCodigo.Focus();
        }



        private void btIncluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;
            bool bOK = true;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.Database1ConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "INSERT INTO Clientes (Nome, DataNascimento, Idade, CPF, Altura, Peso, ID_Cidade) " +
                "VALUES (@Nome, @DataNascimento, @Idade, @CPF, @Altura, @Peso, @ID_Cidade)", conn);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@DataNascimento", System.Data.SqlDbType.Date);
            comm.Parameters["@DataNascimento"].Value = dtNascimento.Value.ToShortDateString();

            comm.Parameters.Add("@Idade", System.Data.SqlDbType.Int);
            comm.Parameters["@Idade"].Value = Convert.ToInt32(txIdade.Text);

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@Altura", System.Data.SqlDbType.Float);
            comm.Parameters["@Altura"].Value = Convert.ToSingle(txAltura.Text);

            comm.Parameters.Add("@Peso", System.Data.SqlDbType.Float);
            comm.Parameters["@Peso"].Value = Convert.ToSingle(txPeso.Text);

            comm.Parameters.Add("@ID_Cidade", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cidade"].Value = Convert.ToInt32(txIDCidade.Text);

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message, 
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }

            if (bOK == true)
            {
                MessageBox.Show("Cliente Cadastrado!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                // Atualiza GridView
                this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);

                // Limpar o Form
                LimparForm();
            }            

        } // Fim botão Incluir

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.database1DataSet.Cidades);
            // TODO: This line of code loads data into the 'database1DataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;
            SqlDataReader reader = null;

            bool bOK = true;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.Database1ConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "SELECT Clientes.ID_Cliente, Clientes.Nome, Clientes.DataNascimento, Clientes.Idade, " +
                "Clientes.CPF, Clientes.Altura, Clientes.Peso, Clientes.ID_Cidade, " +
                "Cidades.ID_Cidade, Cidades.Nome AS NomeCid, Cidades.UF " +
                "FROM Clientes " +
                "INNER JOIN Cidades " +
                "ON Clientes.ID_Cliente = @CodigoCli AND Cidades.ID_Cidade = Clientes.ID_Cidade", conn);

            comm.Parameters.Add("@CodigoCli", System.Data.SqlDbType.Int);
            comm.Parameters["@CodigoCli"].Value = Convert.ToInt32(txCodigo.Text);

           
            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    reader = comm.ExecuteReader();  

                    if (reader.Read()) 
                    {
                        txNome.Text = reader["Nome"].ToString();
                        dtNascimento.Value = Convert.ToDateTime(reader["DataNascimento"].ToString());
                        txIdade.Text = reader["Idade"].ToString();
                        mtxCPF.Text = reader["CPF"].ToString();
                        txAltura.Text = reader["Altura"].ToString();
                        txPeso.Text = reader["Peso"].ToString();
                        cbCidade.Text = reader["NomeCid"].ToString();
                        txIDCidade.Text = reader["ID_Cidade"].ToString();
                        txUF.Text = reader["UF"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }           
        } // Fim Botão Consultar

        private void btExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;           

            bool bOK = true;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.Database1ConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "DELETE FROM Clientes WHERE ID_Cliente = @CodigoCli", conn);

            comm.Parameters.Add("@CodigoCli", System.Data.SqlDbType.Int);
            comm.Parameters["@CodigoCli"].Value = Convert.ToInt32(txCodigo.Text);


            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();                    
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD

                if (bOK == true)
                {
                    MessageBox.Show("Cliente Excluído!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Atualiza GridView
                    this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);

                    // Limpar o Form
                    LimparForm();
                }
            }
        } // Fim do Botão Excluir

        private void btAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;
            bool bOK = true;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.Database1ConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "UPDATE Clientes SET Nome=@Nome, DataNascimento=@DataNascimento, " +
                "Idade=@Idade, CPF=@CPF, Altura=@Altura, Peso=@Peso, " +
                "ID_Cidade=@ID_Cidade " +
                "WHERE ID_Cliente = @ID_Cliente", conn);

            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(txCodigo.Text);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@DataNascimento", System.Data.SqlDbType.Date);
            comm.Parameters["@DataNascimento"].Value = dtNascimento.Value.ToShortDateString();

            comm.Parameters.Add("@Idade", System.Data.SqlDbType.Int);
            comm.Parameters["@Idade"].Value = Convert.ToInt32(txIdade.Text);

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@Altura", System.Data.SqlDbType.Float);
            comm.Parameters["@Altura"].Value = Convert.ToSingle(txAltura.Text);

            comm.Parameters.Add("@Peso", System.Data.SqlDbType.Float);
            comm.Parameters["@Peso"].Value = Convert.ToSingle(txPeso.Text);

            comm.Parameters.Add("@ID_Cidade", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cidade"].Value = Convert.ToInt32(txIDCidade.Text);

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }

            if (bOK == true)
            {
                MessageBox.Show("Cliente Alterado com sucesso!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                // Atualiza GridView
                this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);

                // Limpar o Form
                LimparForm();
            }
        }
    }
}
