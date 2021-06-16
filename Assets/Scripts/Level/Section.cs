using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section : MonoBehaviour
{
    [SerializeField] private GameObject sectionPrefab;
    [SerializeField] private GameObject generatedSection;

    public void GenerateNewSection()
    {
        sectionPrefab = FindObjectOfType<Sections>().SelectPrefab();

        GenerateSection();
    }

    public void GenerateSection()
    {
        if (generatedSection != null)
        {
            generatedSection.SetActive(false);
            Destroy(generatedSection);
        }

        generatedSection = Instantiate(sectionPrefab, gameObject.transform.position, new Quaternion());
    }
}
