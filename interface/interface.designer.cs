using System;
using System.Windows.Forms;

void InitializeComponent()
{
    this.txtNome = new TextBox();
    this.txtSenha = new TextBox();
    this.btnLogin = new Button();
    this.SuspendLayout();

    // txtNome
    this.txtNome.PlaceholderText = "Nome";
    this.txtNome.Location = new Point(100, 80);

    // txtSenha
    this.txtSenha.PlaceholderText = "Senha";
    this.txtSenha.Location = new Point(100, 120);
    this.txtSenha.PasswordChar = '*';

    // btnLogin
    this.btnLogin.Text = "Login";
    this.btnLogin.Location = new Point(100, 160);
    this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

    // Interface
    this.ClientSize = new Size(300, 300);
    this.Controls.Add(this.txtNome);
    this.Controls.Add(this.txtSenha);
    this.Controls.Add(this.btnLogin);
    this.Text = "MasterScore - Login";
    this.ResumeLayout(false);
    this.PerformLayout();
}
