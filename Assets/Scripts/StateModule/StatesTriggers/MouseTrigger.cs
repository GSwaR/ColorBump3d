using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrigger : MonoBehaviour
{
    [SerializeField] private StateManager StateManager;
    private void OnMouseDown()
    {
        StateManager.SetState(StateManager.GameState);
        gameObject.SetActive(false);
    }
}
