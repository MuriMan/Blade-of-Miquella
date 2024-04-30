public class Object
{
	protected List<Component> Components = new List<Component>(100);

	public void Start()
	{
		this._ObjectStart();

		for (int i = 0; i < Components.Count; i++)
		{
			Components.ElementAt(i).ParentObject = this;
			Components.ElementAt(i).Start();
		}
	}
	public virtual void _ObjectStart() { }

	public void Update(float deltaTime)
	{
		for (int i = 0; i < Components.Count; i++)
		{
			Components.ElementAt(i).Update(deltaTime);

			if (Components.ElementAt(i).ParentObject == null)
				Components.ElementAt(i).ParentObject = this;
		}

		this._ObjectUpdate(deltaTime);
	}
	public virtual void _ObjectUpdate(float deltaTime) { }

	public void Tick(float deltaTime)
	{
		this._ObjectTick(deltaTime);

		for (int i = 0;i < Components.Count; i++)
			Components.ElementAt(i).Tick(deltaTime);
	}
	public virtual void _ObjectTick(float deltaTime) { }

	public void Draw()
	{
		this._ObjectDraw();

		for (int i = 0; i < Components.Count; i++)
			Components.ElementAt(i).Draw();
	}
	public virtual void _ObjectDraw() { }

	public void Draw2D()
	{
		this._ObjectDraw2D();

		for (int i = 0; i < Components.Count; i++)
			Components.ElementAt(i).Draw2D();
	}
	public virtual void _ObjectDraw2D() {}
}
