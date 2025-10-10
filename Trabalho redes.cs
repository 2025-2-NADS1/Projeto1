using System.Net.Sockets;

namespace ClientForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            #region LÊ COMANDO (MENSAGEM)
            Console.Write(">>");
            String msg = txtComando.Text;
            #endregion

            #region CONECTA COM SERVIDOR
            String IPServer = "127.0.0.1";
            TcpClient client = new TcpClient();
            client.Connect(IPServer, 30000);
            #endregion

            #region ENVIA MENSAGEM

            Byte[] dados = System.Text.Encoding.UTF8.GetBytes(msg);
            NetworkStream stream = client.GetStream();
            stream.Write(dados, 0, dados.Length);
            #endregion

            #region RECEBE MENSAGEM
            Byte[] dadosLidos = new Byte[client.ReceiveBufferSize];
            int numBytes = stream.Read(dadosLidos, 0, dadosLidos.Length);
            String resposta = "";
            resposta = resposta + System.Text.Encoding.UTF8.GetString(dadosLidos, 0, numBytes);
            TxtResposta.Text += resposta+"\r\n";
            #endregion
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
