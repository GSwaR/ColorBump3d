using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    [SerializeField] private Color[] colors;

    public Color friendlyColor;
    public Color deadlyColor;
    public Color fieldColor;

    public void GetNewColors()
    {
        System.Random random = new System.Random();

        int friendly = random.Next(0, colors.Length);
        int deadly = random.Next(0, colors.Length);
        int field = random.Next(0, colors.Length);
        while (friendly == deadly || friendly == deadly)
        {
            friendly = random.Next(0, colors.Length);
        }

        friendlyColor = colors[friendly];
        deadlyColor = colors[deadly];
        fieldColor = colors[field];
    }

}
