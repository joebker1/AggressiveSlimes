/*
Description: This script controls the launching animation for when the player pulls back on the slime. This controls flight time, forcing the player to wait
before launching another slime (this can be fixed if you set an OutOfBounds border past the screen, then once destroyed, go back to the launcher), and
destruction of slimes.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;

    private Launcher launch;

    public bool isDead = false;

    public float waitTime = 5f;

    public bool isFly = false;
    



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        launch = GameObject.FindObjectOfType<Launcher>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (launch.isFlying == true || isFly == true)
        {
            anim.SetBool("isFlying", true);
            isFly = true;
        }

        if (isDead == true)
        {
            anim.SetBool("isDead", true);

            StartCoroutine(Disappear());

            
            //StartCoroutine(Disappear());
        }

        

    }

    void OnCollisionEnter2D()
    {
        isDead = true;
        isFly = false;
        
    }

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(waitTime);

        isDead = false;

        Destroy(gameObject);
    }




}
