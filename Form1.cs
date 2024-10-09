using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Data;

namespace Registros
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=registro;Uid=root;Password='';";
        private const string Password = "1234"; // Defina a senha aqui
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Coleta os dados do formulário
            string nome = textBox2.Text.Trim();
            string cpf = mskCPF.Text.Trim();
            string rg = mskRG.Text.Trim();
            string celular = maskedTextBox2.Text.Trim();
            string dataNascimento = maskedTextBox1.Text.Trim();
            string ufNascimento = cmbUF.SelectedItem?.ToString(); // Coleta a UF

            string sexo = GetSexo();
            if (sexo == null)
            {
                MessageBox.Show("Selecione um sexo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação dos campos obrigatórios
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(rg) ||
                string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(dataNascimento) || string.IsNullOrEmpty(ufNascimento))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação da data de nascimento
            if (!DateTime.TryParse(dataNascimento, out DateTime parsedDate))
            {
                MessageBox.Show("Data de nascimento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conexão com o banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO clientes (nome, cpf, rg, celular, dataNascimento, sexo, uf_nascimento) " +
                                   "VALUES (@Nome, @CPF, @RG, @Celular, @DataNascimento, @Sexo, @UFnascimento)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        cmd.Parameters.AddWithValue("@RG", rg);
                        cmd.Parameters.AddWithValue("@Celular", celular);
                        cmd.Parameters.AddWithValue("@DataNascimento", parsedDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Sexo", sexo);
                        cmd.Parameters.AddWithValue("@UFnascimento", ufNascimento); // Adiciona a UF

                        // Executa o comando
                        int result = cmd.ExecuteNonQuery();

                        // Verifica se o registro foi inserido com sucesso
                        if (result > 0)
                        {
                            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao cadastrar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LimparCampos();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }


        private string GetSexo()
        {
            if (rdbMasculino1.Checked)
                return "M";
            if (rdbFeminino1.Checked)
                return "F";
            return null; // Nenhuma opção selecionada
        }

        private void LimparCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            mskCPF.Clear();
            mskRG.Clear();
        }


        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            // Coleta o código do cliente a ser excluído
            string codigoCliente = textBox1.Text.Trim();

            // Validação do código do cliente
            if (string.IsNullOrEmpty(codigoCliente))
            {
                MessageBox.Show("Por favor, informe o código do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conexão com o banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM clientes WHERE Cliente = @Cliente";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cliente", codigoCliente);

                        // Executa o comando
                        int result = cmd.ExecuteNonQuery();

                        // Verifica se o registro foi excluído com sucesso
                        if (result > 0)
                        {
                            MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum cliente encontrado com esse código.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            lblcdcliente.Visible = true;
            btnExcluirCliente.Visible = true;
            textBox1.Visible = true;
        }
        private void btnExcluirTodos_Click(object sender, EventArgs e)
        {
            // Conexão com o banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM clientes";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Executa o comando
                        int result = cmd.ExecuteNonQuery();

                        MessageBox.Show($"{result} cliente(s) excluído(s) com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            lblcdcliente.Visible = true;
            btnExcluirCliente.Visible = true;
            textBox1.Visible = true;
            if (RequestPassword())
            {
                string codigoCliente = textBox1.Text.Trim();
                string cpf = mskCPF.Text.Trim();

                if (string.IsNullOrEmpty(codigoCliente) && string.IsNullOrEmpty(cpf))
                {
                    MessageBox.Show("Por favor, informe o código do cliente ou CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT nome, cpf, rg, celular, dataNascimento, sexo, uf_nascimento FROM clientes " +
                                       "WHERE Cliente = @Cliente OR cpf = @CPF";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Cliente", string.IsNullOrEmpty(codigoCliente) ? (object)DBNull.Value : codigoCliente);
                            cmd.Parameters.AddWithValue("@CPF", string.IsNullOrEmpty(cpf) ? (object)DBNull.Value : cpf);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    textBox2.Text = reader["nome"].ToString();
                                    mskCPF.Text = reader["cpf"].ToString();
                                    mskRG.Text = reader["rg"].ToString();
                                    maskedTextBox2.Text = reader["celular"].ToString();
                                    maskedTextBox1.Text = DateTime.Parse(reader["dataNascimento"].ToString()).ToString("dd/MM/yyyy");
                                    string sexo = reader["sexo"].ToString();
                                    if (sexo == "M") rdbMasculino1.Checked = true;
                                    else if (sexo == "F") rdbFeminino1.Checked = true;
                                    cmbUF.SelectedItem = reader["uf_nascimento"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum cliente encontrado com os dados informados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool RequestPassword()
        {
            using (Form passwordForm = new Form())
            {
                TextBox txtPassword = new TextBox() { PasswordChar = '*', Top = 20, Left = 20, Width = 200 };
                Button btnOk = new Button() { Text = "OK", Top = 50, Left = 20, DialogResult = DialogResult.OK };
                passwordForm.Controls.Add(txtPassword);
                passwordForm.Controls.Add(btnOk);
                passwordForm.AcceptButton = btnOk;

                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    return txtPassword.Text == Password;
                }
            }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM clientes";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
