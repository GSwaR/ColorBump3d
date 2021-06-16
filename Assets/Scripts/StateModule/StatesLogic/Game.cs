using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private void OnEnable()
    {
        Camera.main.GetComponent<CameraController>().enabled = true;
        player.GetComponent<PlayerController>().enabled = true;
    }

}
