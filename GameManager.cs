/*
Description: This script controls when the player moves onto the next level. This script was used to move onto the next level to continue testing and submission
*/

.using System.Collections;
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
