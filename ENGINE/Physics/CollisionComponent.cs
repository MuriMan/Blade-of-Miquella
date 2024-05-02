using Raylib_cs;
using static Raylib_cs.Raylib;

public class CollisionComponent : Component
{
	public Rectangle Rect;

	public CollisionComponent(Rectangle rect)
	{
		this.Rect = rect;
	}

	public override void _ComponentDraw2D()
	{
		DrawRectangleRec(this.Rect, Color.Blue);
	}
}
