namespace P06_RectanglePosition
{
	public class Rectangle
	{
		public int Top { get; set; }
		public int Left { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public int Bottom
		{
			get
			{
				return Top - Height;
			}
		}
		public int Right
		{
			get
			{
				return Left + Width;
			}
		}
		public int Area
		{
			get
			{
				return Width * Height;
			}
		}

		public bool IsInside(Rectangle r)
		{
			return (Left >= r.Left) && (Top <= r.Top) &&
				(Right <= r.Right) && (Bottom >= r.Bottom);
		}
	}
}
