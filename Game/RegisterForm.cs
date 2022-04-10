using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Game
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            if (TextBoxPlayerName.Text != "")
            {
                string path = Environment.CurrentDirectory.Replace(@"bin\Debug", "") + "Players.txt";
                Program.ThisPlayer = new Player(TextBoxPlayerName.Text, 0, 0);
                Hide();
                new GameForm().ShowDialog();
                Show();
                using (StreamWriter text = new StreamWriter(path,true))
                {
                    text.WriteLine(Program.ThisPlayer.ToString());
                }
                Hide();
                new ResultsForm().ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Вы не ввели имя игрока");
            }
            

        }

        private void ShowResults_Click(object sender, EventArgs e)
        {
            Hide();
            new ResultsForm().ShowDialog();
            Show();
        }
    }
}
