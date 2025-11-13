using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MasterScore
{
    public partial class FormPergunta : Form
    {
        //VARIAVEL DO CAMINHO PARA O BANCO DE DADOS!!!!
        string caminhoDB = @"Data Source=D:\Downloads\MasterScore\MasterScore.db; Version=3;";

        public static Random random = new Random();
        private string resV;

        private void reset() 
        {
            btnResA.Enabled = false;
            btnResB.Enabled = false;
            btnResC.Enabled = false;
            btnResD.Enabled = false;
            txtPergunta.Enabled = true;
            txtPergunta.Clear();
            lblResA.Text = "Resposta A";
            lblResB.Text = "Resposta B";
            lblResC.Text = "Resposta C";
            lblResD.Text = "Resposta D";

        }

        private void FormPergunta_Load(object sender, EventArgs e)
        {
            reset();
        }


        public FormPergunta()
        {
            InitializeComponent();
        }

        private void txtPergunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPerguntar_Click(object sender, EventArgs e)
        {
            int q = random.Next(1, 10);
            string comandoQuestao = $"SELECT Pergunta, Resposta FROM Perguntas WHERE ID = {q}";
            string comandoResF = $"SELECT Resposta FROM Respostas WHERE ID_Pergunta = {q}";

            SQLiteConnection conexao = new SQLiteConnection(caminhoDB);

            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com banco: " + ex.Message, "Erro de DB");
            }

            SQLiteCommand questaoSQL = new SQLiteCommand(comandoQuestao, conexao);
            SQLiteDataReader leQuestao = questaoSQL.ExecuteReader();

            leQuestao.Read();
            txtPergunta.Text = leQuestao["Pergunta"].ToString();
            resV = leQuestao["Resposta"].ToString();
            leQuestao.Close();


            SQLiteCommand resSQL = new SQLiteCommand(comandoResF, conexao);
            SQLiteDataReader leResF = resSQL.ExecuteReader();

            List<string> respostasF = new List<string>();

            while (leResF.Read())
            {
                respostasF.Add(leResF["Resposta"].ToString());
            }
            leResF.Close();
            respostasF.Add(resV);
            string[] respostas = respostasF.ToArray();

            string[] res = respostas.OrderBy(x => random.Next()).ToArray();
            lblResA.Text = res[0];
            lblResB.Text = res[1];
            lblResC.Text = res[2];
            lblResD.Text = res[3];

            btnResA.Enabled = true;
            btnResB.Enabled = true;
            btnResC.Enabled = true;
            btnResD.Enabled = true;

            conexao.Close();
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            new FormShop().Show();
            this.Hide();          
        }

        private void btnResA_Click(object sender, EventArgs e)
        {
            if (lblResA.Text == resV)
            {
                MessageBox.Show("Resposta Correta!");
            }
            else 
            {
                MessageBox.Show("Resposta Errada!!!!");
            }
            reset();
        }
        private void btnResB_Click(object sender, EventArgs e)
        {
            if (lblResB.Text == resV)
            {
                MessageBox.Show("Resposta Correta!");
            }
            else
            {
                MessageBox.Show("Resposta Errada!!!!");
            }
            reset();
        }
        private void btnResC_Click(object sender, EventArgs e)
        {
            if (lblResC.Text == resV)
            {
                MessageBox.Show("Resposta Correta!");
            }
            else
            {
                MessageBox.Show("Resposta Errada!!!!");
            }
            reset();
        }
        private void btnResD_Click(object sender, EventArgs e)
        {
            if (lblResD.Text == resV)
            {
                MessageBox.Show("Resposta Correta!");
            }
            else
            {
                MessageBox.Show("Resposta Errada!!!!");
            }
            reset();
        }

      
    }
}
