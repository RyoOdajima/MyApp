using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyApp
{
    public class LoginForm : Form
    {
        private TextBox txtId;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnCancel;

        public LoginForm()
        {
            this.Text = "ログイン";
            Label title = new Label
{
    Text = "HITOS BASIC",
    Font = new Font("Arial", 14, FontStyle.Bold),
    AutoSize = true,
    Top = 0,
    Left = 90
};
Controls.Add(title);

            this.Size = new System.Drawing.Size(300, 200);

            txtId = new TextBox { PlaceholderText = "ID", Top = 20, Left = 50, Width = 200 };
            txtPass = new TextBox { PlaceholderText = "Password", Top = 60, Left = 50, Width = 200, UseSystemPasswordChar = true };

            btnLogin = new Button { Text = "ログイン", Top = 100, Left = 100 };
            btnCancel = new Button { Text = "キャンセル", Top = 100, Left = 180 };

            btnLogin.Click += (s, e) => {
                this.Hide();
                new MenuForm().ShowDialog();
                this.Close();
            };

            btnCancel.Click += (s, e) => Application.Exit();

            Controls.AddRange(new Control[] { txtId, txtPass, btnLogin, btnCancel });
        }
    }
}
