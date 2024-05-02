using System.Numerics;
using Raylib_cs;

public class World : Scene
{
	Player Player = new Player(
		new Vector2(0, 0)
	);
	Player Player1 = new Player(
		new Vector2(100, 10)
	);

	public override void _InitialiseScene()
	{
		Objects.Add(this.Player);
		Objects.Add(this.Player1);
	}
}
