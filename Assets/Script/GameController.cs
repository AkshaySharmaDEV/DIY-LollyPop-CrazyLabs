using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject targetObject;

    public Animator anim;


    private void OnTriggerEnter(Collider other)
    {



        if (other.tag == "LAYER1COLLIDER")
        {
            anim.enabled = true;
            anim.Play("AtCentre");
            
           
            StartCoroutine(ExampleCoroutine());

        }

        if (other.tag == "LAYER2COLLIDER")
        {
            anim.enabled = true;
            anim.Play("AtCentre");

            StartCoroutine(ExampleCoroutine());

        }

        IEnumerator ExampleCoroutine()
        {

            yield return new WaitForSeconds(0.1f);

            anim.enabled = false;


        }



    }
}
