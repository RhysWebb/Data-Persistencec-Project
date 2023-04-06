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
    [SerializeField] TextMeshProUGUI highScoreMainMenuText;
    [SerializeField] TextMeshProUGUI highScoreOneText;
    [SerializeField] TextMeshProUGUI highScoreTwoText;
    [SerializeField] TextMeshProUGUI highScoreThree;
    [SerializeField] GameObject highScoreHolder;
    [SerializeField] TMP_InputField playerInput;
    private bool isHighScoreActive;

    // Start is called before the first frame update
    void Start()
    {
        highScoreHolder.SetActive(false);
        isHighScoreActive = false;
        playerInput = GetComponent<TMP_InputField>();
        highScoreThree.text = GameManager.instance.highScoreThree;
        highScoreTwoText.text = GameManager.instance.highScoreTwo;
        highScoreOneText.text = GameManager.instance.highScoreOne;
        highScoreMainMenuText.text = GameManager.instance.highScoreOne;
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
        GameManager.instance.playerName = playerInput.text;
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
