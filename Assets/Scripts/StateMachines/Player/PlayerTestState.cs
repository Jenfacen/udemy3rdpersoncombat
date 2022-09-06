using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{

    private float timer = 5f;

    public PlayerTestState(PlayerStateMachine StateMachine) : base(StateMachine) { }

    public override void Enter()
    {
        Debug.Log("Enter");
    }

    public override void Tick(float deltaTime)
    {
        timer -= deltaTime;
        Debug.Log(timer);
        if (timer <= 0)
        {
            StateMachine.SwitchState(new PlayerTestState(StateMachine));
        }
        
    }

    public override void Exit()
    {
        Debug.Log("Exit");
       
    }

    
}
