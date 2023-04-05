using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIController : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject highScoreHolder;
    [SerializeField] TMP_InputField playerInput;
    private bool isHighScoreActive;

    public string playerName;

    // Start is called before the first frame update
    void Start()
    {
        highScoreHolder.SetActive(false);
        isHighScoreActive = false;
        playerInput = GetComponent<TMP_InputField>();
    }
    
    public void OpenHighScore()
    {
        if (!isHighScoreActive)
        {
            highScoreHolder.SetActive(true);
            isHighScoreActive = true;
        }
        else if (isHighScoreActive)
        {
            highScoreHolder.SetActive(false); 
            isHighScoreActive = false;
        }
        
    }

    public void PlayerName()
    {
        playerName = playerInput.text;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        GameManager.instance.SaveFile();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }



}
