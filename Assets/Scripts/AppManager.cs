using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour
{
    public Cities activeCity;
    public Text roomInfo;

    public string[] CityNames = new string[]
    {
        "Utrecht",
        "Amsterdam",
        "Den Haag",
        "Zwolle",
        "Rotterdam",
        "Gouda",
        "Antwerpen",
        "Essen"
    };

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void EnterWebsite()
    {
        Application.OpenURL("https://www.google.com");
    }

    public void SetRoom(int cityId)
    {
        activeCity = (Cities) cityId;
        roomInfo.text = "Naar " + CityNames[cityId] + ": " + Random.Range(1, 100) + " buddies";
    }
}

public enum Cities
{
    Utrecht,
    Amsterdam,
    DenHaag,
    Zwolle,
    Rotterdam,
    Gouda,
    Antwerpen,
    Essen
}
