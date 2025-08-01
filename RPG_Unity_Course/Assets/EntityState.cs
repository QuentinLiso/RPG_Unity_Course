using UnityEngine;

public abstract class EntityState
{
	protected Player player;
	protected StateMachine stateMachine;
	protected string animBoolName;
	protected Animator anim;
	protected Rigidbody2D rb;
	protected PlayerInputSet input;

	public EntityState(Player player, StateMachine stateMachine, string animBoolName)
	{
		this.player = player;
		this.stateMachine = stateMachine;
		this.animBoolName = animBoolName;

		anim = player.anim;
		rb = player.rb;
		input = player.input;
	}

	// Called everytime the state is changed
	public virtual void Enter()
	{
		anim.SetBool(animBoolName, true);
	}

	// Run the logic of the state here
	public virtual void Update()
	{
		anim.SetFloat("yVelocity", rb.linearVelocity.y);
	}

	// Called everytime we exit a state and change to a new one
	public virtual void Exit()
	{
		anim.SetBool(animBoolName, false);
	}
}
