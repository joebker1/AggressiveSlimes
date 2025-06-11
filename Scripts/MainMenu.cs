using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Quit Game");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("NextLevel");
    }
}
