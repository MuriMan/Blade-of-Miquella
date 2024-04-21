using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;

public class Floor : Object
{
	CollisionRect CollisionRect;
	PhysicsComponent PhysicsComponent;

	public override void _ObjectStart()
	{
		this.Position = new Vector2(0, 50);

		this.CollisionRect = new CollisionRect(
			new Vector2(800, 100),
			this.Position
		);
		this.PhysicsComponent = new PhysicsComponent(
			this.CollisionRect
		);

		this.Components.Add(this.CollisionRect);
		this.Components.Add(this.PhysicsComponent);
	}
}
