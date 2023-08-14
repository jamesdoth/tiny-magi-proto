using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected Core core;

    protected Player player;
    protected PlayerStateMachine stateMachine;
    protected PlayerData playerData;
    protected float startTime;

    protected int xInput;
    protected int yInput;

    protected bool isExitingState;

    protected Movement Movement { get => movement ?? core.GetCoreComponent(ref movement); }
    private Movement movement;

    public PlayerState(Player player, PlayerStateMachine stateMachine, PlayerData playerData)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.playerData = playerData;
        core = player.Core;
    }

    public virtual void Enter()
    {
        DoCheck();
        startTime = Time.time;
        isExitingState = false;
    }

    public virtual void Exit()
    {
        isExitingState = true;
    }

    public virtual void LogicUpdate()
    {
        xInput = player.InputHandler.NormInputX;
        yInput = player.InputHandler.NormInputY;
    }

    public virtual void PhysicsUpdate()
    {
        DoCheck();
    }

    public virtual void DoCheck()
    {

    }
}
