using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoManagerMarkerSea : MonoBehaviour
{
    public TextMeshProUGUI seaNameText;
    public TextMeshProUGUI sourceText;
    public TextMeshProUGUI muedungText;
    public TextMeshProUGUI lenghtText;
    public TextMeshProUGUI citiesText;
    public TextMeshProUGUI meaningText;
    public Image Image;

    void Start()
    {
        // Lade das aktuelle StateData-Objekt aus dem DataTransferObject
        SeaData seaData = DataTransferScriptSea.GetCurrentSeaData();

        // Lade die Informationen
        LoadSeaData(seaData);
    }

    public void LoadSeaData(SeaData seaData)
    {
        if (seaData != null)
        {

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

    public void Quit()
    {
        SceneManager.LoadScene("AR-Camera");
    }
}
