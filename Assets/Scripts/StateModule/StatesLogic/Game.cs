using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Vector3 cameraPos;
    [SerializeField] private Vector3 playerPos;

    [SerializeField] private GameObject player;

    private void OnEnable()
    {
        Camera.main.transform.position = cameraPos;
        Camera.main.GetComponent<CameraController>().enabled = true;

        player.transform.position = playerPos;
        player.GetComponent<PlayerController>().enabled = true;
    }

}
