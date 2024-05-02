public class PhysicsComponent : Component
{
	public CollisionComponent CollisionComponent;

	public PhysicsComponent(CollisionComponent colComp)
	{
		this.CollisionComponent = colComp;

		Game.CollisionChecker.PhysicsComponents.Add(this);
	}

	public virtual void _OnCollision(PhysicsComponent collider) {} 
}
