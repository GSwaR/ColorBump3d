using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private float value;
    [SerializeField] private float fieldWidgth;
    [SerializeField] private float cameraDistance;
    [SerializeField] private SphereCollider sphereCollider;
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private GameObject deathParticles;

    private Vector2 lastMousePosition = Vector2.zero;

    public void ResetPlayer()
    {
        rigidBody.constraints = RigidbodyConstraints.None;
        rigidBody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
        sphereCollider.enabled = true;
        meshRenderer.enabled = true;
        deathParticles.SetActive(false);
    }

    public void DestroyPlayer()
    {
        rigidBody.constraints = RigidbodyConstraints.FreezeAll;
        sphereCollider.enabled = false;
        meshRenderer.enabled = false;
        deathParticles.SetActive(true);
    }

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

            rigidBody.AddForce(force);
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
