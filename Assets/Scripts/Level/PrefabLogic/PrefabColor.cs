using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabColor : MonoBehaviour
{
    [SerializeField] private SectionPrefab sectionPrefab;

    void Start()
    {
        if (gameObject.CompareTag("Death"))
        {
            GetComponent<MeshRenderer>().material.color = sectionPrefab.deadlyColor;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = sectionPrefab.friendlyColor;
        }

    }
}
