using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject restartLogic;
    [SerializeField] private GameObject restartGUI;

    private void OnEnable()
    {
        restartGUI.SetActive(true);
        restartLogic.SetActive(true);
    }
}
