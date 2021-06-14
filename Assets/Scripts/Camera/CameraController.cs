using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float Value;
    public GameObject Player;

    private void FixedUpdate()
    {

        Vector3 posCamera = new Vector3(0, gameObject.transform.position.y, gameObject.transform.position.z + Value);
        gameObject.transform.position = posCamera;

        Vector3 posPlayer = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z + Value);
        Player.transform.position = posPlayer;

        if (posPlayer.z - posCamera.z > 0)
        {
            posPlayer.z += Value;
            Player.transform.position = posPlayer;
        }
        else
        {

        }
    }
}
