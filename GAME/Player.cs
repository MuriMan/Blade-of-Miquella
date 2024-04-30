using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;

public class Player : Object
{
	Vector2 Position;

	public Player(Vector2 pos)
	{
		this.Position = pos;
	}

	public override void _ObjectDraw2D()
	{
		DrawRectangleV(this.Position, new Vector2(10, 30), Color.White);
	}
}
