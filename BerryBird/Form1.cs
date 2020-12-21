using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;
using System.IO;

namespace BerryBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int iScore = 0;

        int delta = 2;
        int speed = 2;

        int picbox = 0;

        // Variabelen vanaf het hoofdmenu
        public int LevelSelect = 6;
        public string PlayerName = "";
        // 0 = Freeplay 1 = 1 2 = 2 etc
        bool reloadLevel = true;

        // Lijsten voor importeren coördinaten
        List<int> yCo = new List<int>();
        List<int> xCo = new List<int>();
        int iLoadedIn = 0;

        // 0 = Start 1 = Reset 2 = Intro 3 = Death
        int iEvent = 0;

        int X = 132;
        int Y = 150;

        int[] places = new int[12];
        int[] sizes = new int[12];

        // SoundPlayer song = new SoundPlayer(Properties.Resources.christmas_tune);

        PictureBox[] carey = new PictureBox[6];

        bool D = false;
        bool Playable = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Menu frm1 = new Menu();
            frm1.Show(this);

            timer1.Enabled = false;

            carey[0] = pb0;
            carey[1] = pb1;
            carey[2] = pb2;
            carey[3] = pb3;
            carey[4] = pb4;
            carey[5] = pb5;

            for (int i = 0; i < 6; i++)
            {
                places[i] = carey[i].Location.X;
                places[i + 6] = carey[i].Location.Y;

                sizes[i] = carey[i].Size.Width;
                sizes[i + 6] = carey[i].Size.Height;
            }

            SoundPlayer intro = new SoundPlayer(Properties.Resources.intro_loud);
            intro.Play();

            lblWelcome.Visible = false;

            //int _x = lblWelcome.Location.X + lblWelcome.Size.Width - player.Size.Width - player.Size.Width;
            
            int _x = pbPlane.Location.X + (pbPlane.Size.Width / 2);
            int _y = player.Location.Y;
            player.Location = new Point(_x, _y);

            iEvent = 2;
            timer2.Enabled = true;
        }

        private void Movement(object sender, KeyEventArgs e)
        {
            if (Playable == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (lblPlayPause.Text == "START")
                        {
                            iEvent = 0;
                        }
                        else if (lblPlayPause.Text == "RESET")
                        {
                            iEvent = 1;
                        }
                        PlayPause();
                        break;
                    case Keys.NumPad8:
                        D = false;
                        break;
                    case Keys.NumPad5:
                        D = true;
                        break;
                    case Keys.Up:
                        D = false;
                        break;
                    case Keys.Down:
                        D = true;
                        break;
                    case Keys.Escape:
                        reloadLevel = true;
                        Menu frm1 = new Menu();
                        frm1.Show(this);
                        break;
                    case Keys.Space:
                        if (timer1.Enabled == false)
                        {
                            timer1.Enabled = true;
                        }
                        else
                        {
                            timer1.Enabled = false;
                        }
                        break;
                }
            }
            else if (e.KeyCode == Keys.Enter && iEvent == 3)
            {
                iEvent = 1;
                PlayPause();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Player Movement
            if (D)
            {
                Y += delta;
                player.Location = new Point(X, Y);
            }

            if (!D)
            {
                Y -= delta;
                player.Location = new Point(X, Y);
            }

            // Mariah Carey Movement

            for (int i = 0; i < 6; i++)
            {
                int xpb = carey[i].Location.X;
                int ypb = carey[i].Location.Y;

                int width = carey[i].Width;
                int height = carey[i].Height;

                xpb -= speed;

                carey[i].Location = new Point(xpb, ypb);

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
                        axWindowsMediaPlayer1.URL = "coinsound.wav";
                        axWindowsMediaPlayer1.Ctlcontrols.play();

                        picbox = i;
                        GeneratePosition();
                    }
                }

                // // FOUTEN
                // De rechterhoek van de picturebox is soms doorgaanbaar

                // Collision
                if (X + 20 >= xpb && X + 20 <= xpb + width)
                {
                    if (i == 0 || i == 2 || i == 4)
                    {
                        if (Y + player.Size.Height >= ypb && Y + player.Size.Height <= ypb + height)
                        {
                            iEvent = 3;
                            player.BackgroundImage = Properties.Resources.player_death;
                            SoundPlayer death = new SoundPlayer(Properties.Resources.death2);
                            death.Play();

                            Playable = false;
                            timer1.Enabled = false;
                            timer2.Enabled = true;
                            PlayPause();
                        }
                    }
                    else
                    {
                        if (Y >= ypb && Y <= ypb + height)
                        {
                            iEvent = 3;
                            player.BackgroundImage = Properties.Resources.player_death;
                            axWindowsMediaPlayerMAIN.URL = "death2.wav";
                            axWindowsMediaPlayerMAIN.Ctlcontrols.play();
                            //SoundPlayer death = new SoundPlayer(Properties.Resources.death2);
                            //death.Play();

                            Playable = false;
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
                Random rng = new Random();

                // int LocX = 0;
                int HeightY = 0;
                int LocY = 0;

                switch (picbox)
                {
                    case 0:
                        // LocX = rng.Next(-10, 10);
                        HeightY = rng.Next(120, 180);

                        LocY = HeightY;
                        break;
                    case 1:
                        // LocX = rng.Next(-10, 10);
                        HeightY = rng.Next(100, 130);

                        break;
                    case 2:
                        // LocX = rng.Next(-10, 10);
                        HeightY = rng.Next(120, 180);

                        LocY = HeightY;
                        break;
                    case 3:
                        // LocX = rng.Next(-10, 10);
                        HeightY = rng.Next(100, 130);
                        break;
                    case 4:
                        // LocX = rng.Next(-10, 10);
                        HeightY = rng.Next(120, 180);

                        LocY = HeightY;
                        break;
                    case 5:
                        // LocX = rng.Next(-10, 10);
                        HeightY = rng.Next(100, 130);

                        LocY = HeightY;
                        break;
                }

                // LocX =+ 600;

                if (picbox == 0 || picbox == 2 || picbox == 4)
                {
                    carey[picbox].Location = new Point(550, (places[picbox + 6] + sizes[picbox + 6]) - LocY);
                    carey[picbox].Size = new Size(45, HeightY);

                    // Probleem: Draait de bovenste en onderste pictureboxes om
                    //carey[picbox].Location = new Point(550, LocY);
                    //carey[picbox].Size = new Size(45, HeightY);
                }
                else
                {
                    carey[picbox].Location = new Point(550, 0);
                    carey[picbox].Size = new Size(45, HeightY);

                    //carey[picbox].Location = new Point(550, (places[picbox + 6] + sizes[picbox + 6]) + LocY);
                    //carey[picbox].Size = new Size(45, HeightY);
                }
            }
            else
            {
                //carey[picbox].Location = new Point(700, ((places[picbox + 6] + sizes[picbox + 6]) - yCo[picbox]));

                int Which = picbox + (iLoadedIn * 6);

                if (Which < xCo.Count)
                {
                    carey[picbox].Size = new Size(xCo[Which], yCo[Which]);

                    if (picbox == 0 || picbox == 2 || picbox == 4)
                    {
                        // int tempX = carey[picbox].Location.X;
                        carey[picbox].Location = new Point(550, ((places[picbox + 6] + sizes[picbox + 6]) - yCo[Which]));
                    }
                    else
                    {
                        carey[picbox].Location = new Point(550, yCo[Which]-yCo[Which]);
                    }
                }
                else if (Which >= xCo.Count + 5)
                {
                    timer1.Stop();
                    MessageBox.Show("You won!");
                    iLoadedIn++;
                }
                else
                {
                    carey[picbox].Location = new Point(6000, 1000);
                }

                if (picbox == 5)
                {
                    iLoadedIn++;
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int welcomeX = lblWelcome.Location.X;
            int welcomeY = lblWelcome.Location.Y;
            int playerX = player.Location.X;
            int playerY = player.Location.Y;
            int PlaneX = pbPlane.Location.X;
            int PlaneY = pbPlane.Location.Y;

            if (iEvent == 2)
            {
                int rollspeed = 3;

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
                        Playable = true;
                    }
                    else if (LevelSelect > 0 && xCo.Count > 0)
                    {
                        timer2.Enabled = false;
                        Playable = true;
                    }
                }
            }
            else if (iEvent == 3)
            {
                playerY += 2;
                player.Location = new Point(playerX, playerY);

                if (playerY > Size.Height)
                {
                    iEvent = 1;
                    PlayPause();
                }
            }
        }

        private void PlayPause()
        {
            string text = lblPlayPause.Text;

            switch (iEvent)
            {
                case 0:
                    timer1.Enabled = true;
                    lblPlayPause.Text = "RESET";
                    axWindowsMediaPlayerMAIN.URL = "themesong.mp3";
                    axWindowsMediaPlayerMAIN.Ctlcontrols.play();
                    // song.Play();
                    break;
                case 1:
                    iLoadedIn = 1;
                    Playable = true;
                    player.BackgroundImage = Properties.Resources.player_alive;

                    lblPlayPause.Text = "START";
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();

                    // Player op de juiste plek terugzetten
                    Y = 150;
                    player.Location = new Point(X, Y);

                    if (LevelSelect > 0)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            carey[i].Size = new Size(xCo[i], yCo[i]);

                            if (i == 0 || i == 2 || i == 4)
                            {
                                int Offset = 38;

                                int canvasSize = Size.Height;
                                carey[i].Location = new Point(places[i], (canvasSize - yCo[i] - Offset));
                            }
                            else
                            {
                                carey[i].Location = new Point(places[i], places[i + 6]);
                            }
                        }
                    }
                    else
                    {
                        // Pictureboxen op de juiste plek terugzetten
                        for (int i = 0; i < 6; i++)
                        {
                            carey[i].Location = new Point(places[i], places[i + 6]);
                            carey[i].Size = new Size(sizes[i], sizes[i + 6]);
                        }
                    }

                    // Score-Update
                    lblLast.Text = iScore.ToString();

                    int best = int.Parse(lblBest.Text);

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

            // Een lijst om de rijen in te laden wordt aangemaakt
            List<string> rowLoader = new List<string>();
            // Een array om de 4 geïmporteerde getallen in te zetten
            string[] Loader = new string[2];

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

            // Het bestand openen en de informatie inladen
            using (sReader ) //sReader = new Streamreader(@"[bestand]");
            {
                while (!sReader.EndOfStream)
                {
                    // Alle rijen worden ingeladen
                    rowLoader.Add(sReader.ReadLine());
                }
            }

            // Een string wordt aangemaakt om de geïmporteerde rij te kunnen splitsen
            string import = "";

            for (int i = 1; i < rowLoader.Count; i++)
            {
                // De string krijgt de inhoud van "rowLoader[i]" toegewezen
                import = rowLoader[i];

                // De string wordt gesplitst in kleine stukjes met daarin de variabelen
                Loader = import.Split(';');

                xCo.Add(int.Parse(Loader[0]));
                yCo.Add(int.Parse(Loader[1]));

            }

            for (int i = 0; i < 6; i++)
            {
                carey[i].Size = new Size(xCo[i], yCo[i]);

                if (i == 0 || i == 2 || i == 4)
                {
                    int Offset = 38;

                    int tempX = carey[i].Location.X;
                    int canvasSize = Size.Height;
                    carey[i].Location = new Point(tempX, (canvasSize - yCo[i] - Offset));
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

                reloadLevel = false;
            }
            
        }
    }
}
