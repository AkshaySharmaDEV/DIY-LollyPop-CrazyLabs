using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBucketPosition : MonoBehaviour
{
    // The object whose position will be changed
    public GameObject targetObject;

    
    
    public GameObject[] TransformPoints;

    
    public Color newColor;
    public Color newColor2;

    Renderer[] childrenRenderers;

    public Animator anim;

    public AudioSource DipSound;

    private void Start()
    {
        // Get all the renderers of the child objects of this object
        childrenRenderers = GetComponentsInChildren<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {

        

        if (other.tag == "Red")
        {
            anim.enabled = true;
            anim.Play("FluteShake");
            targetObject.transform.position = TransformPoints[0].transform.position;
            
            DipSound.Play();

            foreach (Renderer renderer in childrenRenderers)
            {
                renderer.material.color = newColor;
            }
            StartCoroutine(ExampleCoroutine());

        }   

        if (other.tag == "Green" )
        {
            anim.enabled = true;
            anim.Play("FluteShake");
            targetObject.transform.position = TransformPoints[1].transform.position;

            DipSound.Play();
            foreach (Renderer renderer in childrenRenderers)
            {
                renderer.material.color = newColor2;
            }
           
            StartCoroutine(ExampleCoroutine());

        }



    }

    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(3);

        anim.enabled = false;


    }
}
