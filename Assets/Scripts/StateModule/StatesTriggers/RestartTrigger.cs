using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartTrigger : MonoBehaviour
{
    [SerializeField] private StateManager StateManager;
    [SerializeField] private GameObject restartGUI;
    [SerializeField] private SectionManager sectionManager;

    private void OnMouseDown()
    {
        StateManager.SetState(StateManager.StartGameState);
        sectionManager.GenerateNewLevel();
        gameObject.SetActive(false);
        restartGUI.SetActive(false);

    }
}
