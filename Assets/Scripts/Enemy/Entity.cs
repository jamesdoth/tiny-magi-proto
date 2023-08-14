using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public FiniteStateMachine stateMachine;

    public EntityData entityData;

    public Core core { get; private set; }

    private float currentHealth;
    private Vector2 velocityWorkspace;
    protected bool isDead;

    public virtual void Awake()
    {
        core = GetComponentInChildren<Core>();

        currentHealth = entityData.maxHealth;

        stateMachine = new FiniteStateMachine();
    }

    public virtual void Update()
    {
        core.LogicUpdate();
        stateMachine.CurrentState.LogicUpdate();
    }

    public virtual void FixedUpdate()
    {
        stateMachine.CurrentState.PhysicsUpdate();
    }
}
