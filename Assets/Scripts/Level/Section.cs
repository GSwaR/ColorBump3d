using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section : MonoBehaviour
{
    [SerializeField] private GameObject sectionPrefab;
    [SerializeField] private GameObject generatedSection;
    [SerializeField] private ColorManager colorManager;
    [SerializeField] private GameObject field;

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
        generatedSection.GetComponent<SectionPrefab>().SetColors(colorManager.deadlyColor, colorManager.friendlyColor);
        field.GetComponent<MeshRenderer>().material.color = colorManager.fieldColor;

    }
}
