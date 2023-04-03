using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiTarget : MonoBehaviour
{
    [SerializeField] private GameObject startModel;
    [SerializeField] TMP_Text namePlanet;

    private int modelsCount;
    private int indexCurrentModel;
    private string[] planets = new string[9]
            {
                "The Sun", "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"
            };

    void Start()
    {
        modelsCount = transform.childCount;
        indexCurrentModel = startModel.transform.GetSiblingIndex();
        namePlanet.text = planets[startModel.transform.GetSiblingIndex()];
    }

    public void ChangeArModel(int index)
    {
        transform.GetChild(indexCurrentModel).gameObject.SetActive(false);

        int newIndex = indexCurrentModel + index;

        if (newIndex < 0)
        {
            newIndex = modelsCount - 1;
        }
        else if (newIndex > modelsCount - 1)
        {
            newIndex = 0;  
        }

        GameObject newModel = transform.GetChild(newIndex).gameObject;
        newModel.SetActive(true);

        namePlanet.enabled = true;
        namePlanet.text = planets[newIndex];

        indexCurrentModel = newModel.transform.GetSiblingIndex();
    }
}
