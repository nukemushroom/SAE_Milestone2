using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour
{
    //Exits the game
    public void ExitBrn()
    {
        Application.Quit();
    }
    //Goes to another scene
    public void StartButton(string level)
    {
        SceneManager.LoadScene(level);
    }
}
