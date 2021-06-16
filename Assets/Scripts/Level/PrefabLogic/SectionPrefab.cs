using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionPrefab : MonoBehaviour
{
    [SerializeField] private Material[] deadlyMaterials;
    [SerializeField] private Material[] friendlyMaterials;

    private Color deadlyColor;
    private Color friendlyColor;

    public void SetColors(Color deadly, Color friendly)
    {
        deadlyColor = deadly;
        friendlyColor = friendly;
    }

    public void PaintPrefabs()
    {
        foreach(Material material in deadlyMaterials)
        {
            material.color = deadlyColor;
        }

        foreach (Material material in friendlyMaterials)
        {
            material.color = friendlyColor;
        }
    }
}
