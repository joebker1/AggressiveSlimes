using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject deathEffect;

    public float knightHealth = 4f;
    public float kingHealth = 10f;

    public int enemiesAlive = 0;

    public float waitTime = 2f;

    private Animator anim;

    public GameObject slime;



    void Start()
    {
        enemiesAlive++;

        anim = GetComponent<Animator>();

    }

    void Update()
    {
        

        
    }



    
    
    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if (this.gameObject.CompareTag("Knight") && colInfo.relativeVelocity.magnitude > knightHealth)
        {
            Die();
        } else
        {
            knightHealth = knightHealth - colInfo.relativeVelocity.magnitude;
        }

        if (this.gameObject.CompareTag("King") && colInfo.relativeVelocity.magnitude > kingHealth)
        {
            Die();
        } else
        {
            anim.SetTrigger("Hit");
            

            kingHealth = kingHealth - colInfo.relativeVelocity.magnitude;
            Debug.Log("KingHealth = " + kingHealth);
        }

        Debug.Log(colInfo.relativeVelocity.magnitude);
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        StartCoroutine(Disappear());
        

        enemiesAlive--;
        
    }


    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(waitTime);

        Destroy(gameObject);
    }

    




}
