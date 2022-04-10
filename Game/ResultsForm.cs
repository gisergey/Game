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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {

            string path = Environment.CurrentDirectory.Replace(@"bin\Debug", "") + "Players.txt";
            List<Player> players = new List<Player>();
            using (StreamReader text = new StreamReader(path))
            {
                string Name;
                int Time;
                int Points;
                while ((Name = text.ReadLine()) != null)
                {
                    try
                    {
                        Time = int.Parse(text.ReadLine());
                        Points = int.Parse(text.ReadLine());
                    }
                    catch
                    {
                        Time = 150;
                        Points = 0;
                    }
                    players.Add(new Player(Name, Time, Points));
                }
            }
            Player sort;
            for (int j = 0; j < players.Count - 1; j++)
            {
                for(int i = players.Count-2 ; i >=j; i--)
                {
                    if (players[i].Points < players[i + 1].Points)
                    {
                        sort = players[i];
                        players[i] = players[i + 1];
                        players[i + 1] = sort;
                    }else if(players[i].Points == players[i + 1].Points&& players[i].Time > players[i + 1].Time)
                    {
                        sort = players[i];
                        players[i] = players[i + 1];
                        players[i + 1] = sort;
                    }
                }
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Имя игрока", typeof(string));
            dt.Columns.Add("Время", typeof(int));
            dt.Columns.Add("Очки", typeof(int));
            foreach(Player player in players)
            {
                dt.Rows.Add(player.Name, player.Time, player.Points);
            }
            ResultsofGame.DataSource = dt;
        }

        private void ResultsofGame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
