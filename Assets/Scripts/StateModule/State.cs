using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    [SerializeField] private GameObject logic;

    public void OnStateActivated()
    {
        logic.SetActive(true);
    }

    public void OnStateDeactivated()
    {
        logic.SetActive(false);
    }
}
