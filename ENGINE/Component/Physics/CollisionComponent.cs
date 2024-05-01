using Raylib_cs;

public class CollisionComponent : Component
{
	Rectangle CollisionRect;

	public CollisionComponent(Rectangle colRect)
	{
		this.CollisionRect = colRect;
	}
}
