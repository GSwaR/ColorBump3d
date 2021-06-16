using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartTrigger : MonoBehaviour
{
    [SerializeField] private StateManager StateManager;
    [SerializeField] private GameObject restartGUI;


    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        restartGUI.SetActive(false);

        StateManager.SetState(StateManager.StartGameState);
    }
}
