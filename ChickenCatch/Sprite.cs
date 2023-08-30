namespace ChickenCatch
{
    internal abstract class Sprite
    {
        //# Instance Variables
        // The x coordinate of the top edge of the sprite.
        private int _x;
        // The y coordinate of the top edge of the sprite.
        private int _y;
        // The width of the sprite, in pixels.
        private int _width;
        // The height of the sprite, in pixels.
        private int _height;

        //# Constructor
        /// <summary>
        /// Creates a new sprite.
        /// </summary>
        /// <param name="x">The x coordinate of the top edge of the sprite.</param>
        /// <param name="y">The y coordinate of the top edge of the sprite.</param>
        /// <param name="width">The width of the new sprite.</param>
        /// <param name="height">The height of the new sprite.</param>
        public Sprite(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        //# Properties
        /// <summary>
        /// The x coordinate of the top edge of the sprite.
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// The y coordinate of the top edge of the sprite.
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// The width of the sprite, in pixels.
        /// </summary>
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// The height of the sprite, in pixels.
        /// </summary>
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        /// The area occupied by the sprite.
        /// </summary>
        public Rectangle BoundingBox
        {
            get
            {
                return new Rectangle(_x, _y, _width - 50, _height - 50);
            }
        }

        //# Public Methods.
        /// <summary>
        /// Displays the sprite.
        /// This method is displayed intermittently by a paint event handler and
        /// draws the sprite. It is an abstract method with different implementations
        /// in every sublass.
        /// </summary>
        public abstract void Display(Graphics graphics);

        /// <summary>
        /// Moves the sprite.
        /// Method is called intermittently using a timer and moves the sprite according
        /// to its speed and/or behaviour. This is an abstract method with different
        /// implementations in every subclass.
        /// </summary>
        public abstract void Move();

        /// <summary>
        /// Checks whether the sprite has a collision with another sprite.
        /// The method compares the regions of the two sprites to check for
        /// and overlap.
        /// </summary>
        /// <param name="other">The other sprite to check for a collision with.</param>
        /// <returns>false if the sprites aren't overlapping, true otherwise.</returns>
        public bool CollidedWith(Sprite other)
        {
            Rectangle box1 = BoundingBox;
            Rectangle box2 = other.BoundingBox;
            return box1.IntersectsWith(box2);
        }
    }
}
