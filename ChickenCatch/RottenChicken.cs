namespace ChickenCatch
{
    class RottenChicken : Sprite
    {
        //# Instance Variables
        /// <summary>
        /// Width of the chicken piece in pixels.
        /// </summary>
        private static readonly int WIDTH = Properties.Resources.RottenChicken.Width;
        /// <summary>
        /// Height of the chicken piece in pixels.
        /// </summary>
        private static readonly int HEIGHT = Properties.Resources.RottenChicken.Height;

        //# Constructor
        /// <summary>
        /// Creates new rotten chicken piece at indicated position.
        /// </summary>
        /// <param name="x">x coordinate of the centre of the piece.</param>
        /// <param name="y">y coordinate of the centre of the piece.</param>
        public RottenChicken(int x, int y)
            : base(x - WIDTH / 2, y - HEIGHT / 2, WIDTH, HEIGHT)
        {
        }

        //# Public Methods
        /// <summary>
        /// Chicken piece moves downwards a small amount.
        /// </summary>
        public override void Move()
        {
            Y += 1;
        }

        public override void Display(Graphics graphics)
        {
            graphics.DrawImage(Properties.Resources.RottenChicken, X, Y);
        }
    }
}
