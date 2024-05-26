using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StateData : ScriptableObject
{
    public string stateName;
    public string cityName;
    public string location;
    public string area;
    public string population;
    public string sightseeingAttractions;
    public string description;
    public Sprite flag; // Bild für die Landesflagge
}
