namespace ChickenCatch
{
    public partial class Game : Form
    {
        //# Instance Variables
        /// <summary>
        /// The player bucket.
        /// Displayed at the bottom of the screen and is controlled by the arrow keys.
        /// </summary>
        private Bucket _bucket;
        /// <summary>
        /// List of fresh chicken pieces that move downwards from the top of the screen.
        /// </summary>
        private List<FreshChicken> _freshChicken;
        /// <summary>
        /// List of rotten chicken pieces that move downwards from the top of the screen.
        /// </summary>
        private List<RottenChicken> _rottenChicken;

        /// <summary>
        /// Player score that starts at zero.
        /// </summary>
        private int _score = 0;

        /// <summary>
        /// Player life count that starts at 3 and reduces depending on penalties.
        /// </summary>
        private int _lives = 3;

        //# Constructor
        /// <summary>
        /// Creates and initialies the Chicken Catch game.
        /// </summary>
        public Game()
        {
            InitializeComponent();
            MinimumSize = Size;
            MaximumSize = Size;
            _bucket = new Bucket(_pictureBox.Height);
            _freshChicken = new List<FreshChicken>();
            _rottenChicken = new List<RottenChicken>();
            _scoreCount.Text = "Score: " + _score.ToString();
            _lifeCount.Text = "Lives: " + _lives.ToString();
        }

        private void AnimationTimerTick(object sender, EventArgs e)
        {
            // For loop to move each rotten chicken piece downwards.
            for (int i = _rottenChicken.Count - 1; i >= 0; i--)
            {
                RottenChicken rottenChicken = _rottenChicken[i];
                rottenChicken.Move();
                if (rottenChicken.CollidedWith(_bucket))
                {
                    _lives--;
                    _rottenChicken.Remove(rottenChicken);
                    if (_lives == 0)
                    {
                        Lose();
                    }
                }
               
            }

            // For loop to move each fresh chicken piece downwards.
            for (int i = _freshChicken.Count - 1; i >= 0; i--)
            {
                FreshChicken freshChicken = _freshChicken[i];
                if (freshChicken.Y >= Height)
                {
                    _freshChicken.RemoveAt(i);
                }
                else
                {
                    freshChicken.Move();
                    if (freshChicken.CollidedWith(_bucket))
                    {
                        _score++;
                        _freshChicken.Remove(freshChicken);
                        if (_score == 10)
                        {
                            Win();
                        }
                    }
                    if (freshChicken.Y == 519)
                    {
                        _lives--;
                        _freshChicken.Remove(freshChicken);
                        if (_lives == 0)
                        {
                            Lose();
                        }
                    }
                }
            }

            // Calling of method to see if a piece of chicken will spawn
            FreshChicken newFreshChicken = _bucket.SpawnFreshChicken();
            if (newFreshChicken != null)
            {
                _freshChicken.Add(newFreshChicken);
            }
            RottenChicken newRottenChicken = _bucket.SpawnRottenChicken();
            if (newRottenChicken != null)
            {
                _rottenChicken.Add(newRottenChicken);
            }
            _scoreCount.Text = "Score: " + _score.ToString();
            _lifeCount.Text = "Lives: " + _lives.ToString();
            Refresh();
        }

        //# Event Handlers
        /// <summary>
        /// Paint event handler of picture box.
        /// </summary>
        private void GamePaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            _bucket.Display(graphics);
            foreach (FreshChicken fc in _freshChicken)
            {
                fc.Display(graphics);
            }
            foreach (RottenChicken rc in _rottenChicken)
            {
                rc.Display(graphics);
            }
        }

        /// <summary>
        /// Key press event handler of picture box.
        /// Moves the bucket according to arrow key pressed.
        /// Starts game when enter key is pressed.
        /// </summary>
        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _animationTimer.Enabled = true;
                _playLabel.Visible = false;
            }
            if (e.KeyCode == Keys.Left && _bucket.X > 0)
            {
                _bucket.MoveLeft();
            } else if (e.KeyCode == Keys.Right && _bucket.X < 691)
            {
                _bucket.MoveRight();
            }
        }

        //# Private Methods
        /// <summary>
        /// Win method that stops the animation timer and quits the application.
        /// </summary>
        private void Lose()
        {
            _animationTimer.Enabled = false;
            DialogResult result = MessageBox.Show("You Lose :(");
            if (result == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        /// <summary>
        /// Lose method that stops the animation timer and quits the application.
        /// </summary>
        private void Win()
        {
            _animationTimer.Enabled = false;
            DialogResult result = MessageBox.Show("You Win!!!");
            if (result == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

    }
}