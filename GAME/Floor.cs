using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;

public class Floor : Object
{
	public override void _ObjectStart()
	{
		this.Position = new Vector2(0, 50);

	}
}
