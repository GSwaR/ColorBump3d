using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionPrefab : MonoBehaviour
{
    public Color deadlyColor;
    public Color friendlyColor;

    public void SetColors(Color deadly, Color friendly)
    {
        deadlyColor = deadly;
        friendlyColor = friendly;
    }

}
