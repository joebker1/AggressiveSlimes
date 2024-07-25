using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Launcher : MonoBehaviour
{
    


    [Header("Rigidbody")]
    public Rigidbody2D rb;
    public Rigidbody2D hook;



    [Header("Animation")]
    public bool isFlying = false;
    public bool isDead = false;
    public float waitTime = 5f;
    private Animator anim;
    public TrailRenderer trail;



    [Header("Slime Order")]
    public float releaseTime = .15f;
    public float maxDragDistance = 2f;
    private bool isPressed = false;
    public GameObject nextSlime;

    public GameObject chargeEffect;

    public Animator enem;

    public GameObject enemy;

    public GameObject tAM;

    public GameObject wM;





    void Start()
    {
        enem = GetComponent<Animator>();

        anim = GetComponent<Animator>();

        trail = GetComponent<TrailRenderer>();

        //enemAlive = script.enemiesAlive;

        //Debug.Log("Enemies Alive: " + enemAlive);
    }


    void Update()
    {
        if (isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Vector3.Distance(mousePos, hook.position) > maxDragDistance)
            {
                rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;

            }
            else
            {
                rb.position = mousePos;
            }

        }

        if (isFlying == true)
        {
            anim.SetBool("isFlying", true);
            enem.SetBool("isFlying", true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }

        


    }
        


    void OnMouseDown ()
    {
        isPressed = true;
        rb.isKinematic = true;

        chargeEffect.SetActive(true);

        
    }

    void OnMouseUp ()
    {
        isPressed = false;
        rb.isKinematic = false;

        chargeEffect.SetActive(false);
        
        StartCoroutine(Release());

        
    }

    IEnumerator Release ()
    {
        isFlying = true;

        enem.SetBool("isFlying", true);

        yield return new WaitForSeconds(releaseTime);

        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(1f);

        if (nextSlime != null)
        {
            nextSlime.SetActive(true);

        } 
        
        

        //Debug.Log("Enemies Alive Now: " + enemAlive);
        

    }


    void OnCollisionEnter2D()
    {
        anim.SetBool("isDead", true);

        trail.Clear();

        StartCoroutine(Disappear());
    }

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(waitTime);

        Destroy(gameObject);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    



}
