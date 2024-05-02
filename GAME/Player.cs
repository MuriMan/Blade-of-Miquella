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

	public override void _ObjectStart()
	{
		this.Components.Add(new CollisionComponent(new Rectangle(this.Position, new Vector2(10, 30))));
		this.Components.Add(new PhysicsComponent(this.Components[0] as CollisionComponent));
	}
}
