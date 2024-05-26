using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoManager : MonoBehaviour
{
    public TextMeshProUGUI stateNameText;
    public TextMeshProUGUI cityNameText;
    public TextMeshProUGUI locationText;
    public TextMeshProUGUI areaText;
    public TextMeshProUGUI populationText;
    public TextMeshProUGUI sightseeingAttractionsText;
    public TextMeshProUGUI descriptionText;
    public Image flagImage;

    public List<StateData> stateDataList; // Liste aller Bundesländer
    private int currentIndex = 0;

    void Start()
    {
        LoadStateData(currentIndex);
    }

    public void LoadStateData(int index)
    {
        if (stateDataList != null && stateDataList.Count > 0)
        {
            StateData stateData = stateDataList[index];
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

    public void NextState()
    {
        currentIndex = (currentIndex + 1) % stateDataList.Count;
        LoadStateData(currentIndex);
    }

    public void PreviousState()
    {
        currentIndex = (currentIndex - 1 + stateDataList.Count) % stateDataList.Count;
        LoadStateData(currentIndex);
    }

    public void Quit()
    {
        SceneManager.LoadScene("AR-Camera");
    }
}