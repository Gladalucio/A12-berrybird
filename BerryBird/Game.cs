using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace BerryBird
{
    enum GameState
    {
        Started,
        Reset,
        Intro,
        Death
    }

    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        int iScore = 0;

        readonly int delta = 2;
        readonly int speed = 2;

        int picbox = 0;

        // Main menu variables
        // 0 = Freeplay, 1 = Level 1, 2 = Level 2, etc
        public int LevelSelect;
        public string PlayerName;
        bool reloadLevel = true;

        // Lists for importing coordinates
        readonly List<int> yCo = new List<int>();
        readonly List<int> xCo = new List<int>();
        int iLoadedIn = 0;

        GameState gameState = GameState.Started;

        int X = 132;
        int Y = 150;

        // Stores the locations and sizes of the spawned obstacles
        readonly int[] places = new int[12];
        readonly int[] sizes = new int[12];

        readonly PictureBox[] obstacles = new PictureBox[6];

        bool movingDown = false;
        bool playable = false;

        SoundPlayer themesong = new SoundPlayer(Properties.Resources.themesong);

        private void Form1_Load(object sender, EventArgs e)
        {
            var frm1 = new Menu();
            frm1.Show(this);

            timer1.Enabled = false;

            obstacles[0] = pb0;
            obstacles[1] = pb1;
            obstacles[2] = pb2;
            obstacles[3] = pb3;
            obstacles[4] = pb4;
            obstacles[5] = pb5;

            for (var i = 0; i < 6; i++)
            {
                // First 6 places are the X-locations, the last 6 are Y.
                places[i] = obstacles[i].Location.X;
                places[i + 6] = obstacles[i].Location.Y;

                // See above comment, but this time with Width and Height instead of X and Y
                sizes[i] = obstacles[i].Size.Width;
                sizes[i + 6] = obstacles[i].Size.Height;
            }

            var introSong = new SoundPlayer(Properties.Resources.intro_loud);
            introSong.Play();

            lblWelcome.Visible = false;

            var _x = pbPlane.Location.X + (pbPlane.Size.Width / 2);
            var _y = player.Location.Y;
            player.Location = new Point(_x, _y);

            gameState = GameState.Intro;
            timer2.Enabled = true;
        }

        private void Movement(object sender, KeyEventArgs e)
        {
            if (playable == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (lblPlayPause.Text == "START")
                        {
                            gameState = GameState.Started;
                        }
                        else if (lblPlayPause.Text == "RESET")
                        {
                            gameState = GameState.Started;
                        }
                        PlayPause();
                        break;
                    case Keys.NumPad8:
                        movingDown = false;
                        break;
                    case Keys.NumPad5:
                        movingDown = true;
                        break;
                    case Keys.Up:
                        movingDown = false;
                        break;
                    case Keys.Down:
                        movingDown = true;
                        break;
                    case Keys.Escape:
                        reloadLevel = true;
                        var frm1 = new Menu();
                        frm1.Show(this);
                        break;
                    case Keys.Space:
                        timer1.Enabled = timer1.Enabled == false;
                        break;
                }
            }
            else if (e.KeyCode == Keys.Enter && gameState == GameState.Death)
            {
                gameState = GameState.Reset;
                PlayPause();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Player Movement
            if (movingDown)
            {
                Y += delta;
                player.Location = new Point(X, Y);
            }

            if (!movingDown)
            {
                Y -= delta;
                player.Location = new Point(X, Y);
            }

            // Mariah Carey Movement

            for (var i = 0; i < 6; i++)
            {
                var xpb = obstacles[i].Location.X;
                var ypb = obstacles[i].Location.Y;

                var width = obstacles[i].Width;
                var height = obstacles[i].Height;

                xpb -= speed;

                obstacles[i].Location = new Point(xpb, ypb);

                if (xpb < 85)
                {
                    iScore++;
                    if (LevelSelect > 0 && iScore > xCo.Count - 6)
                    {
                        timer1.Stop();
                        MessageBox.Show("You won!");
                        iLoadedIn++;
                    }
                    else
                    {
                        lblScore.Text = iScore.ToString();
                        picbox = i;
                        GeneratePosition();
                    }
                }

                // Collision
                if (X + 20 >= xpb && X + 20 <= xpb + width)
                {
                    if (i == 0 || i == 2 || i == 4)
                    {
                        if (Y + player.Size.Height >= ypb && Y + player.Size.Height <= ypb + height)
                        {
                            gameState = GameState.Death;
                            player.BackgroundImage = Properties.Resources.player_death;
                            var death = new SoundPlayer(Properties.Resources.death2);
                            death.Play();

                            playable = false;
                            timer1.Enabled = false;
                            timer2.Enabled = true;
                            PlayPause();
                        }
                    }
                    else
                    {
                        if (Y >= ypb && Y <= ypb + height)
                        {
                            gameState = GameState.Death;
                            player.BackgroundImage = Properties.Resources.player_death;
                            var death = new SoundPlayer(Properties.Resources.death2);
                            death.Play();

                            playable = false;
                            timer1.Enabled = false;
                            timer2.Enabled = true;
                            PlayPause();
                        }
                    }
                }
            }
        }
        private void GeneratePosition()
        {
            if (LevelSelect == 0)
            {
                var rng = new Random();

                var HeightY = 0;
                var LocY = 0;

                switch (picbox)
                {
                    case 0:
                        HeightY = rng.Next(120, 180);

                        LocY = HeightY;
                        break;
                    case 1:
                        HeightY = rng.Next(100, 130);

                        break;
                    case 2:
                        HeightY = rng.Next(120, 180);

                        LocY = HeightY;
                        break;
                    case 3:
                        HeightY = rng.Next(100, 130);
                        break;
                    case 4:
                        HeightY = rng.Next(120, 180);

                        LocY = HeightY;
                        break;
                    case 5:
                        HeightY = rng.Next(100, 130);

                        LocY = HeightY;
                        break;
                }

                if (picbox == 0 || picbox == 2 || picbox == 4)
                {
                    obstacles[picbox].Location = new Point(550, (places[picbox + 6] + sizes[picbox + 6]) - LocY);
                    obstacles[picbox].Size = new Size(45, HeightY);
                }
                else
                {
                    obstacles[picbox].Location = new Point(550, 0);
                    obstacles[picbox].Size = new Size(45, HeightY);
                }
            }
            else
            {
                var which = picbox + (iLoadedIn * 6);

                if (which < xCo.Count)
                {
                    obstacles[picbox].Size = new Size(xCo[which], yCo[which]);

                    if (picbox == 0 || picbox == 2 || picbox == 4)
                    {
                        obstacles[picbox].Location = new Point(550, ((places[picbox + 6] + sizes[picbox + 6]) - yCo[which]));
                    }
                    else
                    {
                        obstacles[picbox].Location = new Point(550, yCo[which] - yCo[which]);
                    }
                }
                else if (which >= xCo.Count + 5)
                {
                    timer1.Stop();
                    MessageBox.Show("You won!");
                    iLoadedIn++;
                }
                else
                {
                    obstacles[picbox].Location = new Point(6000, 1000);
                }

                if (picbox == 5)
                {
                    iLoadedIn++;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var welcomeX = lblWelcome.Location.X;
            var welcomeY = lblWelcome.Location.Y;
            var playerX = player.Location.X;
            var playerY = player.Location.Y;
            var PlaneX = pbPlane.Location.X;
            var PlaneY = pbPlane.Location.Y;

            if (gameState == GameState.Intro)
            {
                var rollspeed = 3;

                welcomeX -= rollspeed;
                playerX -= rollspeed;
                PlaneX -= rollspeed;

                lblWelcome.Location = new Point(welcomeX, welcomeY);
                pbPlane.Location = new Point(PlaneX, PlaneY);

                if (playerX > 132)
                {
                    player.Location = new Point(playerX, playerY);
                }

                if (welcomeX < 0 - lblWelcome.Size.Width)
                {
                    if (LevelSelect == 0)
                    {
                        timer2.Enabled = false;
                        playable = true;
                    }
                    else if (LevelSelect > 0 && xCo.Count > 0)
                    {
                        timer2.Enabled = false;
                        playable = true;
                    }
                }
            }
            else if (gameState == GameState.Death)
            {
                playerY += 2;
                player.Location = new Point(playerX, playerY);

                if (playerY > Size.Height)
                {
                    gameState = GameState.Reset;
                    PlayPause();
                }
            }
        }

        private void PlayPause()
        {
            var text = lblPlayPause.Text;

            switch (gameState)
            {
                case GameState.Started:
                    timer1.Enabled = true;
                    lblPlayPause.Text = "RESET";

                    themesong.Play();
                    break;
                case GameState.Reset:
                    iLoadedIn = 1;
                    playable = true;
                    player.BackgroundImage = Properties.Resources.player_alive;

                    lblPlayPause.Text = "START";
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    themesong.Stop();

                    // Put player back at the starting position
                    Y = 150;
                    player.Location = new Point(X, Y);

                    if (LevelSelect > 0)
                    {
                        for (var i = 0; i < 6; i++)
                        {
                            obstacles[i].Size = new Size(xCo[i], yCo[i]);

                            if (i == 0 || i == 2 || i == 4)
                            {
                                var Offset = 38;

                                var canvasSize = Size.Height;
                                obstacles[i].Location = new Point(places[i], (canvasSize - yCo[i] - Offset));
                            }
                            else
                            {
                                obstacles[i].Location = new Point(places[i], places[i + 6]);
                            }
                        }
                    }
                    else
                    {
                        // Put pictureboxes back at the starting position
                        for (var i = 0; i < 6; i++)
                        {
                            obstacles[i].Location = new Point(places[i], places[i + 6]);
                            obstacles[i].Size = new Size(sizes[i], sizes[i + 6]);
                        }
                    }

                    // Update score
                    lblLast.Text = iScore.ToString();

                    var best = int.Parse(lblBest.Text);

                    if (iScore > best)
                    {
                        lblBest.Text = iScore.ToString();
                    }

                    iScore = 0;
                    lblScore.Text = iScore.ToString();
                    break;
            }
        }

        private void LoadLevel()
        {
            timer1.Stop();

            // Create a list to load in the rows in the .csv
            var rowLoader = new List<string>();

            StreamReader sReader = new StreamReader(@"..\..\Resources\Levels\Level1.csv");

            switch (LevelSelect)
            {
                case 1:
                    sReader = new StreamReader(@"..\..\Resources\Levels\Level1.csv");
                    break;
                case 2:
                    sReader = new StreamReader(@"..\..\Resources\Levels\Level2.csv");
                    break;
                case 3:
                    sReader = new StreamReader(@"..\..\Resources\Levels\Level3.csv");
                    break;
                case 4:
                    sReader = new StreamReader(@"..\..\Resources\Levels\Level4.csv");
                    break;
                case 5:
                    sReader = new StreamReader(@"..\..\Resources\Levels\Level5.csv");
                    break;
            }

            // Open the file and read it's contents
            using (sReader) //sReader = new Streamreader(@"[file]");
            {
                while (!sReader.EndOfStream)
                {
                    rowLoader.Add(sReader.ReadLine());
                }
            }

            for (var i = 1; i < rowLoader.Count; i++)
            {
                var import = rowLoader[i];
                var loader = import.Split(';');

                xCo.Add(int.Parse(loader[0]));
                yCo.Add(int.Parse(loader[1]));
            }

            for (var i = 0; i < 6; i++)
            {
                obstacles[i].Size = new Size(xCo[i], yCo[i]);

                if (i == 0 || i == 2 || i == 4)
                {
                    var Offset = 38;

                    var tempX = obstacles[i].Location.X;
                    var canvasSize = Size.Height;
                    obstacles[i].Location = new Point(tempX, (canvasSize - yCo[i] - Offset));
                }
            }

            iLoadedIn = 1;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (reloadLevel && PlayerName != "")
            {
                lblPlayerName.Text = PlayerName;

                if (LevelSelect != 0)
                {
                    lblLevel.Text = "Level " + LevelSelect.ToString();
                    LoadLevel();
                }
                else
                {
                    lblLevel.Text = "FREEPLAY";
                }

                gameState = GameState.Reset;
                PlayPause();
                reloadLevel = false;
            }
        }
    }
}
