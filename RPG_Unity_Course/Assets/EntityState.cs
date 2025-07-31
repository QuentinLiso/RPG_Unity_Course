using UnityEngine;

public class EntityState
{
	protected StateMachine stateMachine;
	protected string stateName;

	public EntityState(StateMachine stateMachine, string stateName)
	{
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
