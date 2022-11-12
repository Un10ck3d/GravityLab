using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuScript : MonoBehaviour
{
    public GameObject PlayButton;
    public GameObject SettingsButton;
    public GameObject ExitButton;
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    public TextMeshProUGUI DisplaySettingsText;

    void Start()
    {
        MainMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void ExitGame() {
        Debug.Log("Exiting game");
        Application.Quit();
    }

    public void EnterSettings() {
        Debug.Log("Entering Settings");
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void BackMain() {
        Debug.Log("Going back to main menu");
        MainMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void PlayGame() {
        Debug.Log("Starting game");
        SceneManager.LoadScene("test");
    }

    public void DisplaySettings() {
        Debug.Log(Screen.fullScreen);
        if (Screen.fullScreen == true) {
            Debug.Log("Turning off FullScreen");
            Screen.fullScreen = false;
            DisplaySettingsText.text = "FullScreen: Off";
        } else {
            Debug.Log("Turning on FullScreen");
            Screen.fullScreen = true;
            DisplaySettingsText.text = "FullScreen: On";
        }
    }
}