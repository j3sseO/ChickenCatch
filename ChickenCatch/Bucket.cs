namespace ChickenCatch
{
    class Bucket : Sprite
    {
        //# Class Constants
        /// <summary>
        /// The width of the bucket, in pixels.
        /// </summary>
        private static readonly int WIDTH = Properties.Resources.PlayerBucket.Width;
        /// <summary>
        /// The height of the bucket, in pixels.
        /// </summary>
        private static readonly int HEIGHT = Properties.Resources.PlayerBucket.Height;

        private static Random _randomNumberGenerator = new Random();

        //# Constructor
        /// <summary>
        /// Creates a bucket at the left edge of the screen.
        /// </summary>
        /// <param name="y">y coordinate of the top edge of the bucket.</param>
        public Bucket(int y)
            : base(0, y - HEIGHT, WIDTH, HEIGHT)
        { }

        //# Public Methods
        /// <summary>
        /// Moves the ship horizontally.
        /// </summary>
        /// <param name="newX">New x coordinate for the left edge of the bucket.</param>
        public void MoveLeft()
        {
            X -= 20;
        }
        
        public void MoveRight()
        {
            X += 20;
        }

        public override void Move()
        {
        }

        /// <summary>
        /// Draws bucket at specific coordinates.
        /// </summary>
        public override void Display(Graphics graphics)
        {
            graphics.DrawImage(Properties.Resources.PlayerBucket, X, Y);
        }

        /// <summary>
        /// Method to decide whether to spawn a piece of fresh chicken with random
        /// x coordinates.
        /// </summary>
        /// <returns>New piece of chicken with random x coordinate, or null</returns>
        public FreshChicken SpawnFreshChicken()
        {
            if (_randomNumberGenerator.Next(1000) < 7)
            {
                return new FreshChicken(_randomNumberGenerator.Next(50, 470), 0);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Method to decide whether to spawn a piece of rotten chicken with random
        /// x coordinates.
        /// </summary>
        /// <returns>New piece of chicken with random x coordinate, or null</returns>
        public RottenChicken SpawnRottenChicken()
        {
            if (_randomNumberGenerator.Next(1000) < 7)
            {
                return new RottenChicken(_randomNumberGenerator.Next(50, 470), 0);
            }
            else
            {
                return null;
            }
        }
    }
}
