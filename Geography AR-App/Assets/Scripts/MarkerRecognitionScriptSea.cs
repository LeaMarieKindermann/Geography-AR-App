using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MarkerRecognitionScriptSea : MonoBehaviour
{
    public GameObject button;
    public SeaData seaDataDonau;
    public SeaData seaDataRhein;
    public SeaData seaDataFulda;
    public SeaData seaDataMain;
    public SeaData seaDataElbe;


    public void MarkerFound()
    {
        button.SetActive(true);
    }

    public void MarkerLost()
    {
        button.SetActive(false);
    }

    public void Button()
    {
        SceneManager.LoadScene("InformationFluesseMarker");
    }

    public void Elbe()
    {
        DataTransferScriptSea.SetCurrentSeaData(seaDataElbe);
    }

    public void Rhein()
    {
        DataTransferScriptSea.SetCurrentSeaData(seaDataRhein);
    }

    public void Fulda()
    {
        DataTransferScriptSea.SetCurrentSeaData(seaDataFulda);
    }

    public void Main()
    {
        DataTransferScriptSea.SetCurrentSeaData(seaDataMain);
    }

    public void Donau()
    {
        DataTransferScriptSea.SetCurrentSeaData(seaDataDonau);
    }
} 
