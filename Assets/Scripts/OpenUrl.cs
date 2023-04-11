using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenUrl : MonoBehaviour
{

    [SerializeField] TMP_Text namePlanet;

    string url;
    
    public void Open()
    {
        string text = namePlanet.text;
        switch (text)
        {
            case "The Sun":
                url = "https://en.wikipedia.org/wiki/Solar_System";
                break;
            case "Mercury":
                url = "https://en.wikipedia.org/wiki/Mercury_(planet)";
                break;
            case "Venus":
                url = "https://en.wikipedia.org/wiki/Venus";
                break;
            case "Earth":
                url = "https://en.wikipedia.org/wiki/Earth";
                break;
            case "Mars":
                url = "https://en.wikipedia.org/wiki/Mars";
                break;
            case "Jupiter":
                url = "https://en.wikipedia.org/wiki/Jupiter";
                break;
            case "Saturn":
                url = "https://en.wikipedia.org/wiki/Saturn";
                break;
            case "Uranus":
                url = "https://en.wikipedia.org/wiki/Uranus";
                break;
            case "Neptune":
                url = "https://en.wikipedia.org/wiki/Neptune";
                break;
        }
        Application.OpenURL(url);
    }
}
