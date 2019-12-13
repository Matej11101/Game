using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public Text highscoreText;

    void Start()
    {
        if (PlayerPrefs.GetString("HIGHSCORENAME") != "")
        {


            highscoreText.text = "High Score set by " + PlayerPrefs.GetString("HIGHSCORENAME") + "" + PlayerPrefs.GetInt("HIGHSCORE");
        }
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUit Button Pushed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
