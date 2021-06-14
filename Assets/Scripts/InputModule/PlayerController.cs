using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private new Rigidbody rigidbody;
    [SerializeField] private float value;
    [SerializeField] private float fieldWidgth;
    [SerializeField] private float cameraDistance;

    private Vector2 lastMousePosition = Vector2.zero;

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePosition = Input.mousePosition;

            if (lastMousePosition == Vector2.zero)
            {
                lastMousePosition = mousePosition;
            }

            Vector2 delta = mousePosition - lastMousePosition;
            lastMousePosition = mousePosition;

            Vector3 force = new Vector3(delta.x, 0, delta.y) * value;

            rigidbody.AddForce(force);
        }
        else
        {
            lastMousePosition = Vector2.zero;
        }
    }

    private void LateUpdate()
    {
        Vector3 position = transform.position;

        if (transform.position.x < -fieldWidgth)
        {
            position.x = -fieldWidgth;
        }
        else if (transform.position.x > fieldWidgth)
        {
            position.x = fieldWidgth;
        }

        if (transform.position.z < Camera.main.transform.position.z + cameraDistance)
        {
            position.z = Camera.main.transform.position.z + cameraDistance;
        }

        transform.position = position;

    }
}
