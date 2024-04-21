using Raylib_cs;
using static Raylib_cs.Raylib;

public class CollisionHandler : Object
{
	public List<PhysicsComponent> PhysicsComponents = new List<PhysicsComponent>(50);

	public override void _ObjectTick(float deltaTime)
	{
		// iterates through every PhysicsComponent, checks if they are colliding and calls _ResolveCollision() if they are.
		for (int i = 0; i < PhysicsComponents.Count; i++)
		{
			for (int j = 0; j < PhysicsComponents.Count; j++)
			{
				if (i != j)
				{
					if (this.CheckCollision(PhysicsComponents.ElementAt(i), PhysicsComponents.ElementAt(j)))
					{
						PhysicsComponents.ElementAt(i)._ResolveCollision(PhysicsComponents.ElementAt(j));
						PhysicsComponents.ElementAt(j)._ResolveCollision(PhysicsComponents.ElementAt(i));
					}
				}
			}

			// Console.WriteLine(PhysicsComponents[0] + " 0 ");
			// Console.WriteLine(PhysicsComponents[1] + " 1 " );
		}
	}

	bool CheckCollision(PhysicsComponent a, PhysicsComponent b)
	{
		return a.ParentObject.Position.X <= b.ParentObject.Position.X + b.Rect.Rect.X &&
			   a.ParentObject.Position.X + a.Rect.Rect.X >= b.ParentObject.Position.X &&
			   a.ParentObject.Position.Y <= b.ParentObject.Position.Y + b.Rect.Rect.Y &&
			   a.ParentObject.Position.Y + a.Rect.Rect.Y >= b.ParentObject.Position.Y;
	}
}
