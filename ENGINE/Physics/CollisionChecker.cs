using static Raylib_cs.Raylib;

public class CollisionChecker : Singleton
{
	public List<PhysicsComponent> PhysicsComponents = new List<PhysicsComponent>(100);

	public override void _Tick(float deltaTime)
	{
		for (int i = 0; i < PhysicsComponents.Count; i++)
		{
			PhysicsComponent a = PhysicsComponents.ElementAt(i);
			for (int j = 0; j < PhysicsComponents.Count; j++)
			{
				PhysicsComponent b = PhysicsComponents.ElementAt(j);
				if (i != j)
				{
					if (CheckCollisionRecs(a.CollisionComponent.Rect, b.CollisionComponent.Rect))
					{
						a._OnCollision(b);
						b._OnCollision(a);
					}
				}
			}
		}
	}
}

