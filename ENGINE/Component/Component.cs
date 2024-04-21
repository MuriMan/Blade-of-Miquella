public class Component
{
	public Object? ParentObject;

	public void Start()
	{
		this._ComponentStart();
	}
	public virtual void _ComponentStart() { }

	public void Update(float deltaTime)
	{
		this._ComponentUpdate(deltaTime);
	}
	public virtual void _ComponentUpdate(float deltaTime) { }

	public void Tick(float deltaTime)
	{
		this._ComponentTick(deltaTime);
	}
	public virtual void _ComponentTick(float deltaTime) { }

	public void Draw()
	{
		this._ComponentDraw();
	}
	public virtual void _ComponentDraw() { }
}
