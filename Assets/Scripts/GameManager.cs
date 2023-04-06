using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Variables
    public string playerName;
    public int playerScore;
    // High Score 
    public string highScoreOne;
    public int highScoreOneInt;
    public string highScoreTwo;
    public int highScoreTwoInt;
    public string highScoreThree;
    public int highScoreThreeInt;

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

    public void HighScoreTable(string name, int score)
    {
        if (score > highScoreOneInt)
        {
            highScoreThreeInt = highScoreTwoInt;
            highScoreTwoInt = highScoreOneInt;
            highScoreOneInt = score;
            highScoreThree = highScoreTwo;
            highScoreTwo = highScoreOne;
            highScoreOne = name + " - " + score;
        }
        else if (score > highScoreTwoInt && score < highScoreOneInt)
        {
            highScoreThreeInt = highScoreTwoInt;
            highScoreTwoInt = score;
            highScoreThree = highScoreTwo;
            highScoreTwo = name + " - " + score;
        }
        else if (score > highScoreThreeInt && score < highScoreTwoInt)
        {
            highScoreThreeInt = score;
            highScoreThree = name + " - " + score;
        }
    }


    [System.Serializable]
    class SaveDate
    {
        public string highScoreOneString;
        public int highScoreOneInt;
        public string highScoreTwoString;
        public int highScoreTwoInt;
        public string highScoreThreeString;
        public int highScoreThreeInt;
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
