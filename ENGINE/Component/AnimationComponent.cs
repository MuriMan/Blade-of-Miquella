using Raylib_cs;
using static Raylib_cs.Raylib;

public class Animation
{
	public const int FRAMERATE = 10;

	public Texture2D[] Frames;
	public string Name;
	public float Framerate;

	private Texture2D CurrentFrame;

	public Animation(Texture2D[] frames, string name)
	{
		this.Frames = frames;
		this.Name = name;
	}
}

public class AnimationComponent : Component
{
	private Animation[] Animations;
	
	public Texture2D CurrentFrame;
	public Animation CurrentAnimation;

	public AnimationComponent(Animation[] animations)
	{
		this.Animations = animations;
		this.CurrentAnimation = Animations[0];
	}

	public override void _ComponentTick(float deltaTime)
	{
		this.play(this.CurrentAnimation.Name);
	}

	int frame;
	private void play(string animName)
	{
		Animation animation = findAnimationWithName(animName);

		if (frame % (Game.TICKS_PER_SECOND/Animation.FRAMERATE) == 0)
			this.CurrentFrame = animation.Frames[frame / (Game.TICKS_PER_SECOND/Animation.FRAMERATE)];

		frame++;
		if (frame >= animation.Frames.Length * (Game.TICKS_PER_SECOND/Animation.FRAMERATE))
			frame = 0;

		// NOTE: Game.TicksPerSecond IS THE TICK RATE
	}

	private Animation findAnimationWithName(string name)
	{
		Animation? res = null;
		for (int i = 0; i < Animations.Length; i++)
		{
			if (Animations[i].Name == name)
			{
				res = Animations[i];
				break;
			}
		}

		return res;
	}

	public void ChangeAnimation(string animName)
	{
		frame = 0;
		this.CurrentAnimation = findAnimationWithName(animName);
	}
}
