using System.Media;

namespace Scary_Maze_Game_MOO_ICT
{

    // coded by MOOICT.COM
    // made for educational purpose only


    public partial class Form1 : Form
    {

        SoundPlayer player  = new SoundPlayer();
        SoundPlayer scare = new SoundPlayer();


        public Form1()
        {
            InitializeComponent();
        }

        private void StartButtonEvent(object sender, EventArgs e)
        {
            StartGame();
        }

        private void FormMouseEvent(object sender, EventArgs e)
        {
            EndGame();
        }

        private void ShowScreamWindow(object sender, EventArgs e)
        {
            ScareWindow scaryWindow = new ScareWindow();
            scaryWindow.Show();
            player.Stop();
            scare.Play();
        }

        private void StartGame()
        {

            StartButton.Enabled = false;
            player.Stream = Properties.Resources.bg_music;
            scare.Stream = Properties.Resources.scare;
            player.PlayLooping();

            foreach (Control x  in this.Controls)
            {

                if (x is PictureBox)
                {
                    x.Enabled = true;
                    x.MouseDown += X_MouseDown;

                    if (x.Tag == null)
                    {
                        x.BackColor = Color.LightBlue;
                    }
                }
            }
        }

        private void X_MouseDown(object? sender, MouseEventArgs e)
        {
            EndGame();
        }

        private void EndGame()
        {

            StartButton.Enabled = true;

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    x.Enabled = false;

                    if (x.Tag == null)
                    {
                        x.BackColor = Color.Black;
                    }
                }
            }
        }
    }
}