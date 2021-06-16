using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private StateManager stateManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            playerController.DestroyPlayer();

            Time.timeScale = 0.2f;
            Time.fixedDeltaTime = 0.02f * 0.2f;
            stateManager.SetState(stateManager.RestartGameState);
        }
    }
}
