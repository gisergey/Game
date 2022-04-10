using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameForm : Form
    {
        int highofPictures = 9;

        List<PictureBox> picters = new List<PictureBox>();
        PictureBox FirstSelected = null;
        int speed = 10;
        bool ISbackFirstImage = true;
        bool IsFirstImageChanged = false;

        PictureBox SeconSelected = null;
        bool ISbackSecondImage = true;
        bool IsSecondImageChanged = false;

        List<string> randompaths = new List<string>();
        int Seconds = 150;
        int Points = 0;
        public GameForm()
        {
            InitializeComponent();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            PointLabel.Text = Points.ToString();
            TimerLabel.Text = (Seconds / 60).ToString() + ":" + ((Seconds % 60) > 9 ? (Seconds % 60).ToString() : 0.ToString() + (Seconds % 60).ToString());
            MainTimer.Start();
            int j;
            string path = Environment.CurrentDirectory.Replace(@"bin\Debug", "") + @"Resources\";
            List<string> paths = new List<string>();
            for (int i = 1; i < 19; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    paths.Add(path + (i).ToString() + ".jpg");
                }
            }
            
            Random rnd = new Random();
           
            for(int i = 36; i >= 1; i--)
            {
                j = rnd.Next(0, i);
                randompaths.Add(paths[j]);
                paths.RemoveAt(j);
            }
            
            for (int i = 0; i < 6; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    picters.Add(new PictureBox());
                    FirstSelected = picters.Last();
                    FirstSelected.Size = new Size(20*highofPictures, 15 * highofPictures);
                    FirstSelected.Location = new Point(i * 20 * highofPictures, j * 15 * highofPictures);
                    //  FirstSelected.BackgroundImage = Image.FromFile(randompaths[i + j * 6]);
                    FirstSelected.BackgroundImage = Properties.Resources.backcart;
                    FirstSelected.BackgroundImageLayout = ImageLayout.Stretch;
                    FirstSelected.Click += new EventHandler(Picture_Click);
                    Controls.Add(FirstSelected);
                }
            }
            FirstSelected = null;
        }
        private void Picture_Click(object sender, EventArgs e)
        {
            if (FirstSelected == null)
            {
                FirstSelected = sender as PictureBox;
                FirstSelected.Click -= new EventHandler(Picture_Click);
                FirstSelectedpictureAnimationTiimer.Start();
               
            }
            else if (SeconSelected == null)
            {
                SeconSelected = sender as PictureBox;
                SecondSelectedPictureAnimationTimer.Start();


            }
        }
        private void IsWin()
        {
            if (randompaths[picters.IndexOf(SeconSelected)].Equals(randompaths[picters.IndexOf(FirstSelected)]))
            {
                SeconSelected.Click -= new EventHandler(Picture_Click);

                Points++;
                Program.ThisPlayer.Points++;
                PointLabel.Text = Points.ToString();
                FirstSelected = null;
                SeconSelected = null;
                if (Points == 18)
                {
                    MainTimer.Stop();
                    Close();
                }
            }
            else
            {
                FirstSelected.Click += new EventHandler(Picture_Click);
                TimerForAnimation.Interval = 1000;
                TimerForAnimation.Start();

            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (Seconds == 0)
            {
                Close();
            }
            Program.ThisPlayer.Time++;
            Seconds--;
            TimerLabel.Text = (Seconds / 60).ToString() +":"+((Seconds%60)>9? (Seconds % 60).ToString():0.ToString()+ (Seconds % 60).ToString());
        }

        private void TimerLabel_Click(object sender, EventArgs e)
        {
  
        }

        private void TimerForAnimation_Tick(object sender, EventArgs e)
        {
            if (FirstSelected.Width > 0 && ISbackFirstImage)
            {
                TimerForAnimation.Interval = 10;
                FirstSelected.Location = new Point(FirstSelected.Location.X + 1 * speed, FirstSelected.Location.Y);
                FirstSelected.Size = new Size(FirstSelected.Width - 2 * speed, FirstSelected.Height);
                SeconSelected.Location = new Point(SeconSelected.Location.X + 1 * speed, SeconSelected.Location.Y);
                SeconSelected.Size = new Size(SeconSelected.Width - 2 * speed, SeconSelected.Height);
            }
            else if (!IsFirstImageChanged)
            {
                FirstSelected.BackgroundImage = Properties.Resources.backcart;
                SeconSelected.BackgroundImage = Properties.Resources.backcart;
                IsFirstImageChanged = true;
            }
            else if (FirstSelected.Width < highofPictures * 20)
            {
                ISbackFirstImage = false;
                FirstSelected.Location = new Point(FirstSelected.Location.X - 1 * speed, FirstSelected.Location.Y);
                FirstSelected.Size = new Size(FirstSelected.Width + 2 * speed, FirstSelected.Height);
                SeconSelected.Location = new Point(SeconSelected.Location.X - 1 * speed, SeconSelected.Location.Y);
                SeconSelected.Size = new Size(SeconSelected.Width + 2 * speed, SeconSelected.Height);
                
            }
            else
            {
                TimerForAnimation.Stop();
                IsFirstImageChanged = false;
                ISbackFirstImage = true;
                SeconSelected = null;
                FirstSelected = null;
            }
         
            
        }

        private void FirstSelectedpictureAnimationTiimer_Tick(object sender, EventArgs e)
        {
            if (FirstSelected.Width > 0 && ISbackFirstImage)
            {
                FirstSelected.Location = new Point(FirstSelected.Location.X + 1*speed, FirstSelected.Location.Y);
                FirstSelected.Size = new Size(FirstSelected.Width - 2 * speed, FirstSelected.Height);

            }
            else if (!IsFirstImageChanged)
            {
                FirstSelected.BackgroundImage = Image.FromFile(randompaths[picters.IndexOf(FirstSelected)]);
                IsFirstImageChanged = true;
            }
            else if (FirstSelected.Width < highofPictures * 20)
            {
                ISbackFirstImage = false;
                FirstSelected.Location = new Point(FirstSelected.Location.X - 1 * speed, FirstSelected.Location.Y);
                FirstSelected.Size = new Size(FirstSelected.Width + 2 * speed, FirstSelected.Height);
            }
            else
            {
                FirstSelectedpictureAnimationTiimer.Stop();
                IsFirstImageChanged = false;
                ISbackFirstImage = true; 
            }
        }

        private void SecondSelectedPictureAnimationTimer_Tick(object sender, EventArgs e)
        {
            if (SeconSelected.Width > 0 && ISbackSecondImage)
            {
                SeconSelected.Location = new Point(SeconSelected.Location.X + 1 * speed, SeconSelected.Location.Y);
                SeconSelected.Size = new Size(SeconSelected.Width - 2 * speed, SeconSelected.Height);
            }
            else if (!IsSecondImageChanged)
            {
                SeconSelected.BackgroundImage = Image.FromFile(randompaths[picters.IndexOf(SeconSelected)]);
                IsSecondImageChanged = true;
            }
            else if (SeconSelected.Width < highofPictures * 20)
            {
                ISbackSecondImage = false;
                SeconSelected.Location = new Point(SeconSelected.Location.X - 1 * speed, SeconSelected.Location.Y);
                SeconSelected.Size = new Size(SeconSelected.Width + 2 * speed, SeconSelected.Height);
            }
            else
            {
                SecondSelectedPictureAnimationTimer.Stop();
                IsSecondImageChanged = false;
                ISbackSecondImage = true;
                IsWin();
            }
        }
    }
}
