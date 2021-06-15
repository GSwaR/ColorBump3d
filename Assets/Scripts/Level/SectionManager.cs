using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionManager : MonoBehaviour
{
    public Section[] Sections;
    [SerializeField] private StateManager StateManager;

    public void RegenerateLevel()
    {
        foreach (Section section in Sections)
        {
            section.GenerateSection();
        }
    }

    public void GenerateNewLevel()
    {
        foreach(Section section in Sections)
        {
            section.GenerateNewSection();
        }
    }
}
