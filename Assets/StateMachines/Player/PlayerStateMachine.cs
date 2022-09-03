using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    private void State()
    {
        SwitchState(new PlayerTestState(this));
    }
}