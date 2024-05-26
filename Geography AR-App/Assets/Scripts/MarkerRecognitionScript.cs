using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MarkerRecognitionScript : MonoBehaviour
{
    public GameObject button;
    public StateData stateDataBerlin;
    public StateData stateDataBayern;
    public StateData stateDataBaWue;
    public StateData stateDataBremen;
    public StateData stateDataHamburg;
    public StateData stateDataHessen;
    public StateData stateDataMecklenburg;
    public StateData stateDataBrandenburg;
    public StateData stateDataNiedersachsen;
    public StateData stateDataSachsen;
    public StateData stateDataSachsenAnhalt;
    public StateData stateDataRheinland;
    public StateData stateDataSaarland;
    public StateData stateDataSchlieswig;
    public StateData stateDataTuehringen;
    public StateData stateDataNordrhein;

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
        SceneManager.LoadScene("InformationsseitenMarker");
    }

    public void Berlin()
    {
        DataTransferScript.SetCurrentStateData(stateDataBerlin);
    }

    public void Bayern()
    {
        DataTransferScript.SetCurrentStateData(stateDataBayern);
    }

    public void BaWue()
    {
        DataTransferScript.SetCurrentStateData(stateDataBaWue);
    }

    public void Bremen() 
    {
        DataTransferScript.SetCurrentStateData(stateDataBremen);
    }

    public void Hamburg() 
    {
        DataTransferScript.SetCurrentStateData(stateDataHamburg);
    }

    public void Hessen() 
    {
        DataTransferScript.SetCurrentStateData(stateDataHessen);
    }

    public void Mecklenburg() 
    {
        DataTransferScript.SetCurrentStateData(stateDataMecklenburg);
    }

    public void Brandenburg() 
    {
        DataTransferScript.SetCurrentStateData(stateDataBrandenburg);
    }

    public void Niedersachsen() 
    {
        DataTransferScript.SetCurrentStateData(stateDataNiedersachsen);
    }

    public void Sachsen() 
    {
        DataTransferScript.SetCurrentStateData(stateDataSachsen);
    }

    public void SachsenAnhalt() 
    {
        DataTransferScript.SetCurrentStateData(stateDataSachsenAnhalt);
    }

    public void Rheinland() 
    {
        DataTransferScript.SetCurrentStateData(stateDataRheinland);
    }

    public void Saarland() 
    {
        DataTransferScript.SetCurrentStateData(stateDataSaarland);
    }

    public void Schlieswig() 
    {
        DataTransferScript.SetCurrentStateData(stateDataSchlieswig);
    }

    public void Tuehringen() 
    {
        DataTransferScript.SetCurrentStateData(stateDataTuehringen);
    }

    public void Nordrhein() 
    {
        DataTransferScript.SetCurrentStateData(stateDataNordrhein);
    }
}
