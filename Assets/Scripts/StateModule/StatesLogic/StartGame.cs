using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject mouseTrigger;

    private void OnEnable()
    {
        mouseTrigger.SetActive(true);
    }
}
