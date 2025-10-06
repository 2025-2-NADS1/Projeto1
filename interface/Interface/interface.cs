using System;
using System.Windows.Forms;

namespace MasterScoreApp.Interface
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login realizado com sucesso!");
        }
    }
    
}