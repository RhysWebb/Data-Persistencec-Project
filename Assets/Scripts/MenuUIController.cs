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
    [SerializeField] Button startGameButton;
    [SerializeField] TextMeshProUGUI highScoreMainMenuText;
    [SerializeField] TextMeshProUGUI highScoreOneText;
    [SerializeField] TextMeshProUGUI highScoreTwoText;
    [SerializeField] TextMeshProUGUI highScoreThree;
    [SerializeField] GameObject highScoreHolder;
    [SerializeField] GameObject playerInput;
    private bool isHighScoreActive;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.LoadSaveFile();
        highScoreHolder.SetActive(false);
        isHighScoreActive = false;
        highScoreThree.text = GameManager.instance.highScoreThree;
        highScoreTwoText.text = GameManager.instance.highScoreTwo;
        highScoreOneText.text = GameManager.instance.highScoreOne;
        highScoreMainMenuText.text = GameManager.instance.highScoreOne;
        startGameButton.onClick.AddListener(PlayerName);
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
        GameManager.instance.playerName = playerInput.GetComponent<TMP_InputField>().text;
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
