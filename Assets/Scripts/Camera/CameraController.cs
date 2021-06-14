using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float value;

    private void FixedUpdate()
    {
        Vector3 posCamera = new Vector3(0, gameObject.transform.position.y, gameObject.transform.position.z + value);
        gameObject.transform.position = posCamera;
    }
}
