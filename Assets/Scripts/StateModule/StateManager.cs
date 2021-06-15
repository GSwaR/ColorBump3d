using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    private State currentState;

    [SerializeField] public State GameState;
    [SerializeField] public State SettingsState;
    [SerializeField] public State StartGameState;
    [SerializeField] public State RestartGameState;
    [SerializeField] public State WinState;

    private void Start()
    {
        currentState = StartGameState;
        StartGameState.OnStateActivated();
    }

    public void SetState(State _state)
    {
        if (currentState.ToString() != _state.ToString())
        {
            currentState.OnStateDeactivated();
        }

        currentState = _state;
        currentState.OnStateActivated();
    }
}
