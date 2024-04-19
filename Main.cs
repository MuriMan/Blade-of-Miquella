using Raylib_cs;
using static Raylib_cs.Raylib;

const int SCREEN_WIDTH = 450;
const int SCREEN_HEIGHT = 800;

InitWindow(SCREEN_WIDTH, SCREEN_HEIGHT, "GAME");
SetTargetFPS(60);

Console.WriteLine("\n\n\n================= MY DEBUGS =================");
Game.Start();

while (!WindowShouldClose())
{
	Game.Update(GetFrameTime());
	Game.SecondsPerTick = (double)1/60;

	double tickTimer = GetFrameTime();
	while (tickTimer >= Game.SecondsPerTick)
	{
		tickTimer -= Game.SecondsPerTick;
		Game.Tick(GetFrameTime());
	}

	BeginDrawing();
		ClearBackground(Color.Black);
		Game.Draw();
	EndDrawing();
}

CloseWindow();
