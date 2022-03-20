using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public IState currentState;

    public StateMachine()
    {

    }

    public void NextState(IState nextState)
    {
        currentState.Stop();
        this.currentState = nextState;
        nextState.Start();
    }

    public void Update()
    {
        if (currentState != null)
        {
            currentState.Update();
        }
    }
}
