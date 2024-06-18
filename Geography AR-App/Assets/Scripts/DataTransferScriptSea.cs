using UnityEngine;

public class DataTransferScriptSea : MonoBehaviour
{
    // Statische Referenz auf das aktuelle SeaData-Objekt
    public static SeaData currentSeaData;

    // Funktion zum Setzen des aktuellen StateData-Objekts
    public static void SetCurrentSeaData(SeaData seaData)
    {
        currentSeaData = seaData;
        Debug.Log("seaData gesetzt");
    }

    // Funktion zum Abrufen des aktuellen StateData-Objekts
    public static SeaData GetCurrentSeaData()
    {
        return currentSeaData;
    }

    void Start()
    {
        // Das GameObject nicht beim Szenenwechsel zerstören
        DontDestroyOnLoad(gameObject);
    }
}
