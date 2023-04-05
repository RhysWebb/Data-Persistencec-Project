using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Variables

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadSaveFile();
    }

    public void LoadSaveFile()
    {

    }

    public void SaveFile()
    {

    }

    [System.Serializable]
    class SaveData
    {
        
    } // Class

}
