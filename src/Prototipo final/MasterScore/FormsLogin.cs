using MySql.Data.MySqlClient;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;


namespace MasterScore
{


    public partial class FormsLogin : Form
    {
        //VARIAVEL DO CAMINHO PARA O BANCO DE DADOS!!!!
        private string caminhoDB = @"Data Source=D:\Downloads\MasterScore\MasterScore.db; Version=3;";

        public FormsLogin()
        {
            InitializeComponent();
        }
        
        private void FormsLogin_Load(object sender, EventArgs e)
        {

        }
        public void btnEnviar_Click(object sender, EventArgs e)
        {   

            string comandoUsuario = $"SELECT ID FROM Usuarios WHERE Usuario = '{txtUsuario.Text}'";
            string comandoSenha = $"SELECT ID FROM Usuarios WHERE Senha = '{txtSenha.Text}'";

            SQLiteConnection conexao = new SQLiteConnection(caminhoDB);

            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com banco: " + ex.Message, "Erro de DB");
            }

            try 
            {
                SQLiteCommand usuarioSQL = new SQLiteCommand(comandoUsuario, conexao);
                SQLiteDataReader leUsuario = usuarioSQL.ExecuteReader();

                leUsuario.Read();
                string usuario = leUsuario["ID"].ToString();
                leUsuario.Close();


                SQLiteCommand senhaSQL = new SQLiteCommand(comandoSenha, conexao);
                SQLiteDataReader leSenha = senhaSQL.ExecuteReader();

                leSenha.Read();
                string senha = leSenha["ID"].ToString();
                leSenha.Close();

                if (senha == usuario || usuario == null || senha == null)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso");
                    new FormPergunta().Show();
                    this.Hide();
                    conexao.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro de Login");
            }
        }
    }
}
