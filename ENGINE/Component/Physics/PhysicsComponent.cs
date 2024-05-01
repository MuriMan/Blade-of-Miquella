public class PhysicsComponent : Component
{
	public CollisionComponent CollisionComponent;

	public PhysicsComponent(CollisionComponent colComponent)
	{
		this.CollisionComponent = colComponent;
		World.PhysicsEngine.PhysicsComponents.Add(this);
	}
}
