using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoManagerMarker : MonoBehaviour
{
    public TextMeshProUGUI stateNameText;
    public TextMeshProUGUI cityNameText;
    public TextMeshProUGUI locationText;
    public TextMeshProUGUI areaText;
    public TextMeshProUGUI populationText;
    public TextMeshProUGUI sightseeingAttractionsText;
    public TextMeshProUGUI descriptionText;
    public Image flagImage;

    void Start()
    {
        // Lade das aktuelle StateData-Objekt aus dem DataTransferObject
        StateData stateData = DataTransferScript.GetCurrentStateData();

        // Lade die Informationen
        LoadStateData(stateData);
    }

    public void LoadStateData(StateData stateData)
    {
        if (stateData != null)
        {
            stateNameText.text = stateData.stateName;
            cityNameText.text = stateData.cityName;
            locationText.text = stateData.location;
            areaText.text = stateData.area;
            populationText.text = stateData.population;
            sightseeingAttractionsText.text = stateData.sightseeingAttractions;
            descriptionText.text = stateData.description;

            if (stateData.flag != null)
            {
                flagImage.sprite = stateData.flag;
                flagImage.gameObject.SetActive(true);
            }
            else
            {
                flagImage.gameObject.SetActive(false);
            }
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene("AR-Camera");
    }
}
