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
	Game.TICKS_PER_SECOND = 60;
	Game.SECONDS_PER_TICK = (double)1/60;

	double tickTimer = GetFrameTime();
	while (tickTimer >= Game.SECONDS_PER_TICK)
	{
		tickTimer -= Game.SECONDS_PER_TICK;
		Game.Tick(GetFrameTime());
	}

	BeginDrawing();
		ClearBackground(Color.Black);
		Game.Draw();
	EndDrawing();
}

CloseWindow();
