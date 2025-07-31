using UnityEngine;

public abstract class EntityState
{
	protected Player player;
	protected StateMachine stateMachine;
	protected string stateName;

	public EntityState(Player player, StateMachine stateMachine, string stateName)
	{
		this.player = player;
		this.stateMachine = stateMachine;
		this.stateName = stateName;
	}

	// Called everytime the state is changed
	public virtual void Enter()
	{
		Debug.Log("I enter " + stateName);
	}

	// Run the logic of the state here
	public virtual void Update()
	{
		Debug.Log("I run update of " + stateName);
	}

	// Called everytime we exit a state and change to a new one
	public virtual void Exit()
	{
		Debug.Log("I exit " + stateName);
	}
}
