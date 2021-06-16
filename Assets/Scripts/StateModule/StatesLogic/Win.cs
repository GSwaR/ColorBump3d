using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject WinLogic;
    [SerializeField] private GameObject WinGUI;

    private void OnEnable()
    {
        WinLogic.SetActive(true);
        WinGUI.SetActive(true);
    }
}
