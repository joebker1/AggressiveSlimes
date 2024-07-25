/*
Description: This script controls the abilities of the special slimes. When the red slime comes into contact with objects labelled "wood", the wood will
be destroyed after a couple of seconds. The green slimes will destroy the objects labelled "metal" after a couple of seconds. I couldn't figure out how to
get the wood and metal to change colors to show that something was happening during the couple of seconds between the slime hitting the object.
*/

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
