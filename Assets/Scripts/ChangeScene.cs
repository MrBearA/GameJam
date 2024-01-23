using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Exit_Button()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void Enter_Button()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void Play_Button()
    {
        SceneManager.LoadScene("GameScene");
    }

}
