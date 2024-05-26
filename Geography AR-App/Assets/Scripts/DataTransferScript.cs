using UnityEngine;

public class DataTransferScript : MonoBehaviour
{
    // Statische Referenz auf das aktuelle StateData-Objekt
    public static StateData currentStateData;

    // Funktion zum Setzen des aktuellen StateData-Objekts
    public static void SetCurrentStateData(StateData stateData)
    {
        currentStateData = stateData;
        Debug.Log("stateData gesetzt");
    }

    // Funktion zum Abrufen des aktuellen StateData-Objekts
    public static StateData GetCurrentStateData()
    {
        return currentStateData;
    }

    void Start()
    {
        // Das GameObject nicht beim Szenenwechsel zerstören
        DontDestroyOnLoad(gameObject);
    }
}
