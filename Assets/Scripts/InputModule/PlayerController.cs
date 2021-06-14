using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public float Value;
    private Vector3 startPoint;
    private Vector3 middlePoint;
    public Camera camera;
    public GameObject Player;

    private void OnMouseDown()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycast;

        Physics.Raycast(ray, out raycast);
        startPoint = raycast.point;
        middlePoint = raycast.point;
    }

    private void OnMouseDrag()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycast;

        Physics.Raycast(ray, out raycast);
        Vector3 endPoint = raycast.point;

        Vector3 direction = endPoint - middlePoint;

        int posZ = (int)direction.z;
        direction.Normalize();

        Player.GetComponent<Rigidbody>().AddForce(direction* Value);
        middlePoint = raycast.point;
    }

    private void OnMouseUp()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycast;

        Physics.Raycast(ray, out raycast);
        Vector3 endPoint = raycast.point;

        Vector3 direction = startPoint - endPoint;

        int posZ = (int)direction.z;
        direction.Normalize();

        Debug.Log(direction.z);

        Player.GetComponent<Rigidbody>().AddForce(direction* Value);
        startPoint = raycast.point;
    }
}
