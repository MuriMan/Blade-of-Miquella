using Raylib_cs;
using System.Numerics;
using static Raylib_cs.Raylib;

public class Player : Object
{
	AnimationComponent AnimationComponent;
	CollisionRect CollisionRect;
	PlayerPhysicsComponent PhysicsComponent;

	public Player(Vector2 pos)
	{
		this.Position = pos;
	}

	public override void _ObjectStart()
	{
		this.AnimationComponent = new AnimationComponent(
			new Animation[]{
				new Animation(new Texture2D[]{
					LoadTexture("RES/Kenney/green1.png"),
					LoadTexture("RES/Kenney/green2.png")
				}, "IDLE")
			}
		);
		this.CollisionRect = new CollisionRect(
			new Vector2(20, 50),
			this.Position
		);
		this.PhysicsComponent = new PlayerPhysicsComponent(
			this.CollisionRect
		);
		this.PhysicsComponent.Acceleration = new Vector2(0, 10);

		this.Components.Add(this.AnimationComponent);
		this.Components.Add(this.CollisionRect);
		this.Components.Add(this.PhysicsComponent);
	}

	public override void _ObjectUpdate(float deltaTime)
	{
	}

	public override void _ObjectDraw()
	{
		DrawTextureV(this.AnimationComponent.CurrentFrame, this.Position, Color.White);
	}
}

public class PlayerPhysicsComponent : PhysicsComponent
{
	public PlayerPhysicsComponent(CollisionRect rect) : base(rect)
	{ }

	public override void _ResolveCollision(PhysicsComponent collider)
	{
		Console.WriteLine("HI");
	}
}
