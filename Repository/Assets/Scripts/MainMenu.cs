using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public Text PlayerDisplay;

    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            PlayerDisplay.text = "Player: " + DBManager.username;
        }

    }

    public void GoToRegister()
    {
        SceneManager.LoadScene(1); // We can set up the indexes of the scenes in (File > build settings) 
    }

    public void GoToLogin()
    {
        SceneManager.LoadScene(2); 
    }
}
