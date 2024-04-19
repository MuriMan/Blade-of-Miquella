public static class Game
{
	public static double SecondsPerTick;
	static List<Object> Objects = new List<Object>(100);

	public static void Start()
	{
		Objects.Add(new Object());

		for (int i = 0; i < Objects.Count; i++)
		{
			Objects.ElementAt(i).Start();
		}
	}

	public static void Update(float deltaTime)
	{
		for (int i = 0; i < Objects.Count; i++)
		{
			Objects.ElementAt(i).Update(deltaTime);
		}
	}

	public static void Tick(float deltaTime)
	{
		for (int i = 0; i < Objects.Count; i++)
		{
			Objects.ElementAt(i).Tick(deltaTime);
		}
	}

	public static void Draw()
	{
		for (int i = 0; i < Objects.Count; i++)
		{
			Objects.ElementAt(i).Draw();
		}
	}
}
