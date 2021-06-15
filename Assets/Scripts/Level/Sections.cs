using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sections : MonoBehaviour
{
    public GameObject[] SectionPrefabs;
    public List<int> SelectedSections;

    private void Start()
    {
        ResetSelections();
    }

    public void AddSelection(int position)
    {
        SelectedSections.Add(position);
    }

    public void ResetSelections()
    {
        SelectedSections = new List<int>();
    }

    public GameObject SelectPrefab()
    {
        System.Random random = new System.Random();
        int pos = 0;
        while (true)
        {
            pos = random.Next(0, SectionPrefabs.Length);

            if (SelectedSections.Contains(pos))
            {
                continue;
            }
            else
            {
                break;
            }
        }

        SelectedSections.Add(pos);
        return SectionPrefabs[pos];
    }
}
