using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTriggerMouse : MonoBehaviour
{
    [SerializeField] private StateManager StateManager;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject winGUI;
    private void OnMouseDown()
    {
        StateManager.SetState(StateManager.StartGameState);
        playerController.DestroyPlayer();
        playerController.ResetPlayer();
        gameObject.SetActive(false);
        winGUI.SetActive(false);
    }
}
