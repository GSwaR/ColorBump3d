using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionManager : MonoBehaviour
{
    public Section[] Sections;
    [SerializeField] private StateManager StateManager;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private CameraController cameraController;

    public void RegenerateLevel()
    {
        foreach (Section section in Sections)
        {
            section.GenerateSection();
        }
        //playerController.ResetPlayer();
    }

    public void GenerateNewLevel()
    {
        foreach(Section section in Sections)
        {
            section.GenerateNewSection();
        }
        //playerController.ResetPlayer();

    }
}
