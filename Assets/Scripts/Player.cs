using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine StateMachine {  get; private set; }

    [SerializeField]
    private PlayerData playerData;

    public PlayerInputHandler InputHandler { get; private set; }
    public Rigidbody2D RB { get; private set; }
    private Vector2 workspace;

    private void Awake()
    {
        StateMachine = new PlayerStateMachine();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    public void SetVelocityX(float velocity)
    {

    }

    public void SetVelocityY(float velocity)
    {

    }
}
