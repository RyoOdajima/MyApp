using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyApp
{
    public class MenuForm : Form
    {
        public MenuForm()
        {
            this.Text = "メニュー";
            this.Size = new Size(400, 400);
            this.BackColor = Color.White;

            string[] labels = {
                "お客様情報", "商品情報", "受注登録", "請求管理",
                "発送登録", "売上分析", "マスタ管理", "ログアウト"
            };

            for (int i = 0; i < 8; i++)
            {
                Button btn = new Button();
                btn.Text = labels[i];
                btn.Size = new Size(80, 80);
                double angle = i * Math.PI / 4;
                int centerX = 150, centerY = 150, radius = 100;
                btn.Location = new Point(
                    centerX + (int)(radius * Math.Cos(angle)),
                    centerY + (int)(radius * Math.Sin(angle))
                );
                btn.Click += (s, e) => MessageBox.Show($"{btn.Text} を選択しました");
                Controls.Add(btn);
            }
        }
    }
}
