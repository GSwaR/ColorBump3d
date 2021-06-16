using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionManager : MonoBehaviour
{
    [SerializeField] private Sections sectionsManaging;
    public Section[] Sections;
    [SerializeField] private StateManager StateManager;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private CameraController cameraController;

    public void RegenerateLevel()
    {
        sectionsManaging.ResetSelections();
        foreach (Section section in Sections)
        {
            section.GenerateSection();
        }
    }

    public void GenerateNewLevel()
    {
        sectionsManaging.ResetSelections();
        foreach(Section section in Sections)
        {
            section.GenerateNewSection();
        }

    }
}
