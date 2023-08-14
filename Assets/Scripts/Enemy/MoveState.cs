using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{
    protected EntityData stateData;
    public MoveState(Entity entity, FiniteStateMachine stateMachine, EntityData stateData) : base(entity, stateMachine)
    {
        this.stateData = stateData;
    }

    public override void DoCheck()
    {
        base.DoCheck();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
