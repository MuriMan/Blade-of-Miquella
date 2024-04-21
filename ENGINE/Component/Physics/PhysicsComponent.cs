using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;

public class PhysicsComponent : Component
{
	public string hi = "HI";

	public Vector2 Velocity = Vector2.Zero;
	public Vector2 Acceleration = new Vector2(0, 10);

	public CollisionRect Rect;

	public PhysicsComponent(CollisionRect rect)
	{
		this.Rect = rect;
	}

	public override void _ComponentStart()
	{
		Game.COLLISION_HANDLER.PhysicsComponents.Add(this);
	}

	public override void _ComponentUpdate(float deltaTime)
	{
		this.Velocity += this.Acceleration;
		this.ParentObject.Position += this.Velocity * deltaTime;
	}

	public virtual void _ResolveCollision(PhysicsComponent collider) { }
}
