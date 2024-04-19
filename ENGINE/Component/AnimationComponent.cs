using Raylib_cs;
using static Raylib_cs.Raylib;

public class Animation
{
	public Texture2D[] Frames;
	public string Name;
	public float Framerate;

	private Texture2D CurrentFrame;

	public Animation(Texture2D[] frames, string name, float framerate)
	{
		this.Frames = frames;
		this.Name = name;
		this.Framerate = framerate;
	}
}

public class AnimationComponent : Component
{
	protected Animation[] Animations;

	public AnimationComponent(Animation[] animations)
	{
		this.Animations = animations;
	}
}
