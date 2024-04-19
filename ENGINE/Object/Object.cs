using System.Numerics;

public class Object
{
	List<Component> Components = new List<Component>(50);
	Vector2 Position = Vector2.Zero;

	public void Start()
	{
		for (int i = 0; i < Components.Count; i++)
		{
			Components.ElementAt(i).ParentObject = this;
			Components.ElementAt(i).Start();
		}
		this._ObjectStart();
	}
	public virtual void _ObjectStart() { }

	public void Update(float deltaTime)
	{
		for (int i = 0; i < Components.Count; i++)
			Components.ElementAt(i).Update(deltaTime);

		this._ObjectUpdate(deltaTime);
	}
	public virtual void _ObjectUpdate(float deltaTime) { }

	public void Tick(float deltaTime)
	{
		for (int i = 0;i < Components.Count; i++)
			Components.ElementAt(i).Tick(deltaTime);
		this._ObjectTick(deltaTime);
	}
	public virtual void _ObjectTick(float deltaTime) { }

	public void Draw()
	{
		for (int i = 0; i < Components.Count; i++)
			Components.ElementAt(i).Draw();

		this._ObjectDraw();
	}
	public virtual void _ObjectDraw() { }
}
