using Raylib_cs;
using static Raylib_cs.Raylib;
using System.Numerics;

public class Tile
{
	public Texture2D Texture;
	public bool IsCollidable;

	public Tile(string texturePath, bool isCollidable)
	{
		this.Texture = LoadTexture(texturePath);
		this.IsCollidable = isCollidable;
	}
}


public class TileMap : Object
{
	public Tile[] Tileset = new Tile[20];
	public int[,] Map = new int[10,10];

	public TileMap(Tile[] tileset, int[,] map)
	{
		this.Tileset = tileset;
		this.Map = map;
	}

	public override void _ObjectDraw()
	{
		Vector2 drawPos = new Vector2(0, 0);

		for (int i = 0; i < 10; i++)
		{
			for (int j = 0; j < 10; j++)
			{
				DrawTextureV(this.Tileset[this.Map[i, j] - 1].Texture, drawPos, Color.White);
				drawPos += new Vector2(18, 0);
			}
			drawPos = new Vector2(0, drawPos.Y);
			drawPos += new Vector2(0, 18);
		}
	}
}
