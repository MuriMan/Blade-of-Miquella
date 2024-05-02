using Raylib_cs;
using static Raylib_cs.Raylib;
using System.Numerics;

public static class Game
{
	public static int TICKS_PER_SECOND;
	public static double SECONDS_PER_TICK;

	public static Camera2D Camera = new Camera2D(new Vector2(1024/2, 512/2), new Vector2(0, 0), 0, 1.0f);

	public static Scene[] Scenes = {
		new World()
	};
	public static Scene CurrentScene = Scenes[0];

	public static CollisionChecker CollisionChecker = new CollisionChecker();
	public static Singleton[] Singletons = {
		CollisionChecker
	};

	public static void Start()
	{
		CurrentScene._InitialiseScene();
		for (int i = 0; i < CurrentScene.Objects.Count; i++)
		{
			if (CurrentScene.Objects.ElementAt(i).ParentScene == null)
				CurrentScene.Objects.ElementAt(i).ParentScene = CurrentScene;
			CurrentScene.Objects.ElementAt(i).Start();
		}

		for (int i = 0; i < Singletons.Length; i++)
		{
			if (Singletons[i].IsEnabled)
				Singletons[i]._Start();
		}
	}

	public static void Update(float deltaTime)
	{
		for (int i = 0; i < CurrentScene.Objects.Count; i++)
		{
			if (CurrentScene.Objects.ElementAt(i).ParentScene == null)
				CurrentScene.Objects.ElementAt(i).ParentScene = CurrentScene;
			CurrentScene.Objects.ElementAt(i).Update(deltaTime);
		}
		
		for (int i = 0; i < Singletons.Length; i++)
		{
			if (Singletons[i].IsEnabled)
				Singletons[i]._Update(deltaTime);
		}
	}

	public static void Tick(float deltaTime)
	{
		for (int i = 0; i < CurrentScene.Objects.Count; i++)
		{
			CurrentScene.Objects.ElementAt(i).Tick(deltaTime);
		}

		for (int i = 0; i < Singletons.Length; i++)
		{
			if (Singletons[i].IsEnabled)
				Singletons[i]._Tick(deltaTime);
		}
	}

	public static void Draw()
	{
		for (int i = 0; i < CurrentScene.Objects.Count; i++)
		{
			CurrentScene.Objects.ElementAt(i).Draw();
		}

		for (int i = 0; i < Singletons.Length; i++)
		{
			if (Singletons[i].IsEnabled)
				Singletons[i]._Draw();
		}
	}

	public static void Draw2D()
	{
		// Draw axes.
		DrawLine(0, -512/2, 0, 512/2, Color.Gray);
		DrawLine(-1024/2, 0, 1024/2, 0, Color.Gray);

		for (int i = 0; i < CurrentScene.Objects.Count; i++)
		{
			CurrentScene.Objects.ElementAt(i).Draw2D();
		}
		for (int i = 0; i < Singletons.Length; i++)
		{
			if (Singletons[i].IsEnabled)
				Singletons[i]._Draw2D();
		}
	}
}
