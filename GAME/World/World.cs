using System.Numerics;
using Raylib_cs;

public class World : Scene
{
	Player Player = new Player(
		new Vector2(0, 0)
	);

	public override void _InitialiseScene()
	{
		Objects.Add(this.Player);
	}
}
