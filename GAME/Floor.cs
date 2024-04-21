using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;

public class Floor : Object
{
	CollisionRect CollisionRect;
	PhysicsComponent PhysicsComponent;

	// public Floor(Vector2 pos)
	// {
	// 	this.Position = pos;
	// }

	public override void _ObjectStart()
	{
		this.CollisionRect = new CollisionRect(
			new Vector2(450, 10), this.Position
		);
		this.PhysicsComponent = new PhysicsComponent(
			this.CollisionRect
		);

	}

	public override void _ObjectUpdate(float deltaTime)
	{
		Console.WriteLine(CollisionRect == null);
	}
}
