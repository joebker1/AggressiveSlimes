using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialSlimes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Wood") && gameObject.tag == "RedSlime")
        {
            //StartCoroutine(SpecialEffect());

            Destroy(col.gameObject);
        }

        if (col.gameObject.CompareTag("Stone") && gameObject.tag == "GreenSlime")
        {
            //StartCoroutine(SpecialEffect());

            Destroy(col.gameObject);
        }

    }

    IEnumerator SpecialEffect()
    {
        //fire and acid animation

        yield return new WaitForSeconds(2f);

        
    }



}
