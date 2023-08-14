using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
    protected FiniteStateMachine stateMachine;
    protected Entity entity;
    protected Core core;

    public float startTime { get; protected set; }

    public State(Entity entity, FiniteStateMachine stateMachine)
    {
        this.entity = entity;
        this.stateMachine = stateMachine;
        core = entity.core;
    }

    public virtual void Enter()
    {
        startTime = Time.time;
        DoCheck();
    }

    public virtual void Exit()
    {

    }

    public virtual void LogicUpdate()
    {

    }

    public virtual void PhysicsUpdate()
    {
        DoCheck();
    }

    public virtual void DoCheck()
    {

    }
}
