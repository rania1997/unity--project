using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoToARScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
    }
}
