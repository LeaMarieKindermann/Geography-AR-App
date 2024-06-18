using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoManagerSea : MonoBehaviour
{
    public TextMeshProUGUI seaNameText;
    public TextMeshProUGUI sourceText;
    public TextMeshProUGUI muedungText;
    public TextMeshProUGUI lenghtText;
    public TextMeshProUGUI citiesText;
    public TextMeshProUGUI meaningText;
    public Image Image;

    public List<SeaData> seaDataList; // Liste aller Bundesländer
    private int currentIndex = 0;

    void Start()
    {
        LoadStateData(currentIndex);
    }

    public void LoadStateData(int index)
    {
        if (seaDataList != null && seaDataList.Count > 0)
        {
            SeaData seaData = seaDataList[index];
            seaNameText.text = seaData.seaName;
            sourceText.text = seaData.source;
            muedungText.text = seaData.muendung;
            lenghtText.text = seaData.lenght;
            citiesText.text = seaData.cities;
            meaningText.text = seaData.meaning;

            if (seaData.flag != null)
            {
                Image.sprite = seaData.flag;
                Image.gameObject.SetActive(true);
            }
            else
            {
                Image.gameObject.SetActive(false);
            }
        }
    }

    public void NextState()
    {
        currentIndex = (currentIndex + 1) % seaDataList.Count;
        LoadStateData(currentIndex);
    }

    public void PreviousState()
    {
        currentIndex = (currentIndex - 1 + seaDataList.Count) % seaDataList.Count;
        LoadStateData(currentIndex);
    }

    public void Quit()
    {
        SceneManager.LoadScene("AR-Camera");
    }
}