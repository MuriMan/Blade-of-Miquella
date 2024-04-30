using Raylib_cs;
using System.Numerics;

public static class Game
{
	public static int TICKS_PER_SECOND;
	public static double SECONDS_PER_TICK;

	public static Camera2D Camera = new Camera2D(new Vector2(400, 225), new Vector2(0, 0), 0, 1.0f);

	static Scene[] Scenes = {
		new World()
	};
	static Scene CurrentScene = Scenes[0];

	public static void Start()
	{
		CurrentScene._InitialiseScene();
		for (int i = 0; i < CurrentScene.Objects.Count; i++)
		{
			CurrentScene.Objects.ElementAt(i).Start();
		}
	}

	public static void Update(float deltaTime)
	{
		for (int i = 0; i < CurrentScene.Objects.Count; i++)
		{
			CurrentScene.Objects.ElementAt(i).Update(deltaTime);
		}
	}

	public static void Tick(float deltaTime)
	{
		for (int i = 0; i < CurrentScene.Objects.Count; i++)
		{
			CurrentScene.Objects.ElementAt(i).Tick(deltaTime);
		}
	}

	public static void Draw()
	{
		Camera.Offset += new Vector2(1, 1);
		for (int i = 0; i < CurrentScene.Objects.Count; i++)
		{
			CurrentScene.Objects.ElementAt(i).Draw();
		}
	}

	public static void Draw2D()
	{
		for (int i = 0; i < CurrentScene.Objects.Count; i++)
		{
			CurrentScene.Objects.ElementAt(i).Draw2D();
		}
	}
}
