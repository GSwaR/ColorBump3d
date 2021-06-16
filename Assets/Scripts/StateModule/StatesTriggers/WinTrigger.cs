using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private StateManager stateManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.2f;
            Time.fixedDeltaTime = 0.02f * 0.2f;
            stateManager.SetState(stateManager.WinState);
        }
    }
}
