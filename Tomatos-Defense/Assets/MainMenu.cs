using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayStory()
    {
        SceneManager.LoadScene(1);
    }
    public void PlaySurvival()
    {
        SceneManager.LoadScene(2);
    }
    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
