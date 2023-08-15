using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine StateMachine {  get; private set; }
    public PlayerMoveState MoveState { get; private set; }

    private Teleport teleportScript;

    [SerializeField]
    private PlayerData playerData;

    public Core Core { get; private set; }
    public PlayerInputHandler InputHandler { get; private set; }
    public Rigidbody2D RB { get; private set; }
    public Vector2 CurrentVelocity { get; private set; }

    private void Awake()
    {
        Core = GetComponentInChildren<Core>();
        if (Core == null)
        {
            Debug.LogError("Core component not found!");
        }


        StateMachine = new PlayerStateMachine();

        MoveState = new PlayerMoveState(this, StateMachine, playerData);
    }

    private void Start()
    {
        InputHandler = GetComponent<PlayerInputHandler>();
        RB = GetComponent<Rigidbody2D>();

        StateMachine.Initialize(MoveState);

        teleportScript = GetComponent<Teleport>();
    }

    private void Update()
    {
        Core.LogicUpdate();
        StateMachine.CurrentState.LogicUpdate();

        if (InputHandler.IsTeleportInput())
        {
            teleportScript.TeleportToMousePosition();
        }
    }

    private void FixedUpdate()
    {
        StateMachine.CurrentState.PhysicsUpdate();
    }
}
