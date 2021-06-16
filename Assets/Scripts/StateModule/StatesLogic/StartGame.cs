using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject startLogic;
    [SerializeField] private GameObject startGUI;

    [SerializeField] private SectionManager sectionManager;

    [SerializeField] private GameObject player;
    [SerializeField] private PlayerController playerController;

    [SerializeField] private CameraController cameraController;
    [SerializeField] private ColorManager colorManager;

    [SerializeField] private Vector3 cameraPos;
    [SerializeField] private Vector3 playerPos;

    private void OnEnable()
    {
        colorManager.GetNewColors();

        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;

        playerController.ResetPlayer();

        cameraController.enabled = false;
        Camera.main.transform.position = cameraPos;
        player.transform.position = playerPos;

        sectionManager.RegenerateLevel();

        startLogic.SetActive(true);
        startGUI.SetActive(true);


    }
}
