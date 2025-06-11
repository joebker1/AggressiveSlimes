using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject enemy;

    public GameObject levSelMen;

    public GameObject slime;






    void Update()
    {
        if (slime == null || enemy == null)
        {
            SceneManager.LoadScene("NextLevel");
        }

        
    }

    




}
