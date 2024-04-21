using System.Numerics;

public class CollisionRect : Component
{
	public Vector2 Rect = Vector2.Zero;

	public int RightBound;
	public int LeftBound;
	public int UpBound;
	public int DownBound;

	public CollisionRect(Vector2 rect, Vector2 pos)
	{
		this.Rect = rect;
	}

	public override void _ComponentStart()
	{
		this.RightBound = (int)MathF.Round(this.Rect.X + this.ParentObject.Position.X);
		this.LeftBound = (int)MathF.Round(this.Rect.X);
		this.UpBound = (int)MathF.Round(this.Rect.Y);
		this.RightBound = (int)MathF.Round(this.Rect.X + this.ParentObject.Position.X);
	}
}
