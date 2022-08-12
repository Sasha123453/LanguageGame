using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
namespace LanguageGame
{
    public partial class GameForm : Form
    {
        private int mistakes;
        private PictureBox choosenPicture;
        private Point prevPicturePosition;
        private Point prevCursorPosition;
        private Train train;
        private Level level;
        private List<Word> words;
        private System.Windows.Forms.Timer timer;
        private string currentLevelPath = "levels/level1.level";
        private SoundPlayer player;
        public GameForm()
        {
            choosenPicture = new() { Width = 0, Height = 0};
            choosenPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(choosenPicture);
            InitializeComponent();
            LoadLevel(currentLevelPath);
            timer = new();
            timer.Interval = 20;
            timer.Tick += new EventHandler((s, e) => UpdateTimer());
            player = new();
        }
        private void LoadLevel(string fileName)
        {
            gamePanel.Controls.Remove(train);
            BinaryFormatter bf = new();
            using (FileStream fs = new(fileName, FileMode.OpenOrCreate))
            {
                level = (Level)bf.Deserialize(fs);
            }
            nameLabel.Text = "Уровень " + level.Order.ToString();
            mistakes = 0;
            levelresult.Visible = false;

            words = new();
            foreach (WordInfo wordInfo in level.Words)
            {
                Word word = new(wordInfo);
                word.MouseDown += Picture_MouseDown;
                word.MouseUp += Picture_MouseUp;
                word.MouseMove += Picture_MouseMove;
                words.Add(word);
            }
            train = new(words);
            train.Speed = level.TrainSpeed;
            train.Location = new(-train.Width, 270);
            gamePanel.Controls.Add(train);
            picturesPanel.Controls.Clear();
        }
        public void RefreshBottomPictures()
        {
            picturesPanel.Controls.Clear();
            for (int i = 0; i < words.Count; i++)
            {
                Word word = words[i];
                word.Location = new(30 + (word.Width + 30) * i, 30);
                picturesPanel.Controls.Add(word);
            }
        }
        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            
            Word word = (Word)sender;
            if (!word.IsComposed)
            {
                prevPicturePosition = word.Location;
                prevCursorPosition = Cursor.Position;
                choosenPicture.BackColor = word.BackColor;
                choosenPicture.Height = word.Height;
                choosenPicture.Width = word.Width;
                if (word.Image != null)
                    choosenPicture.Image = word.Image;
                word.Image = null;
                word.BackColor = Color.FromArgb(255, 32, 32, 32);
            }
            player.Stop();
            word.soundStream.Position = 0;
            player.Stream = word.soundStream;
            player.Play();
        }
        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            Word word = (Word)sender;
            word.BackColor = Color.FromArgb(255, choosenPicture.BackColor.R, choosenPicture.BackColor.G, choosenPicture.BackColor.B);
            word.Image = choosenPicture.Image;
            choosenPicture.Image = null;
            if (!word.IsComposed)
            {
                bool? matched = train.MatchWith(word, new(choosenPicture.Location.X + choosenPicture.Width / 2, choosenPicture.Location.Y + choosenPicture.Height / 2));
                if (matched == true)
                {
                    word.IsComposed = true;
                    words.Remove(word);
                    RefreshBottomPictures();
                    if (train.CheckMatches()) WinLevel();
                }
                else
                {
                    if (matched == false)
                    {
                        mistakes++;
                    }

                }
            }
            choosenPicture.Width = 0;
            choosenPicture.Height = 0;
        }

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (choosenPicture != null)
            {
                choosenPicture.Location = new(Cursor.Position.X - prevCursorPosition.X + prevPicturePosition.X + picturesPanel.Left, Cursor.Position.Y - prevCursorPosition.Y + prevPicturePosition.Y + picturesPanel.Top);
            }
        }

        private void UpdateTimer()
        {
            train.Left = train.Left + train.Speed * 2;
            float totalMistakes = train.CheckSkipedCarriages(1262) + mistakes;
            if (totalMistakes >= 3)
            {
                LoseLevel();
            }
            if (train.Left > 1262)
            {
                if (totalMistakes < 3)
                    WinLevel();
                else
                    LoseLevel();
            }
            //
            healts.Width = (int)((heartPanel.Width - 10) * (3 - totalMistakes) / 3);
            //

        }
        private void StartLevel(object sender, EventArgs e)
        {
            LoadLevel(currentLevelPath);
            RefreshBottomPictures();
            playButton.Enabled = false;
            playButton.Visible = false;
            levelsButton.Enabled = false;
            levelsButton.Visible = false;
            timer.Start();
        }
        private void LoseLevel()
        {
            timer.Stop();
            playButton.Text = "Повторить";
            levelresult.ForeColor = Color.Red;
            levelresult.Text = "ПОРАЖЕНИЕ!";
            levelresult.Visible = true;
            playButton.Enabled = true;
            playButton.Visible = true;
            levelsButton.Enabled = true;
            levelsButton.Visible = true;
        }
        private void WinLevel()
        {
            timer.Stop();
            playButton.Text = "Повторить";
            levelresult.ForeColor = Color.Green;
            levelresult.Text = "ПОБЕДА!";
            levelresult.Visible = true;
            playButton.Enabled = true;
            playButton.Visible = true;
            levelsButton.Enabled = true;
            levelsButton.Visible = true;
        }

        private void ChooseLevelButtonClick(object sender, EventArgs e)
        {
            using(LevelsForm chooselevel = new())
            {
                if(chooselevel.ShowDialog() == DialogResult.OK)
                {
                    currentLevelPath = chooselevel.CurrentLevelPath;
                    LoadLevel(currentLevelPath);
                    playButton.Text = "Начать";
                    playButton.Enabled = true;
                    playButton.Visible = true;
                    levelsButton.Enabled = true;
                    levelsButton.Visible = true;
                }
            }
        }
    }
}