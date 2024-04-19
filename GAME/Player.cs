using Raylib_cs;
using static Raylib_cs.Raylib;

public class Player : Object
{
	AnimationComponent AnimationComponent;

	public override void _ObjectStart()
	{
		this.AnimationComponent = new AnimationComponent(
			new Animation[]{
				new Animation(new Texture2D[]{
					LoadTexture("RES/Kenney/green1.png"),
					LoadTexture("RES/Kenney/green2.png")
				}, "IDLE")
			}
		);
		this.Components.Add(AnimationComponent);
	}
	
	public override void _ObjectDraw()
	{
		DrawTextureV(this.AnimationComponent.CurrentFrame, this.Position, Color.White);
	}
}
