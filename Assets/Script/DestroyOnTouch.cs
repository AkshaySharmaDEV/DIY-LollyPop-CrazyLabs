using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class DestroyOnTouch : MonoBehaviour
{

    
    public GameObject gameObjectToCheck1;
    public GameObject gameObjectToCheck2;
    public GameObject gameObjectToCheck3;

    public GameObject Candy;


    public Transform parentTransform;

    public GameObject CandyEatCamera;
    public GameObject CandyCameraMain;
    public GameObject CandyCamera2;

    public Transform CandyEatPoint;

    public GameObject Layer1Active;
    public GameObject Layer2Active;

    public Animator CandyBoyAnimation;

    public Transform CandyInitialPoint;

    public GameObject L1;
    public GameObject L2;
    public GameObject L3;

    bool CandyTriangle = false;

    int count = 0;


    public GameObject drill;
    public Transform TargetDrillPosition;
    public Transform TargetDrillPosition1;

    public Slider slider;

    public TMP_Text CurrentLevelText;
    public TMP_Text NextLevelText;

    void Update()
    {
        int inactiveChildCount = 0; // variable to store the count of inactive children

        // loop through all the children of the parent transform
        foreach (Transform child in parentTransform)
        {
            if (!child.gameObject.activeInHierarchy) // check if the child is inactive
            {
                inactiveChildCount++; // increment the count
            }
        }

        Debug.Log("Number of inactive children: " + inactiveChildCount); // print the count to the console

        if (inactiveChildCount >= 1200 && gameObjectToCheck1.activeInHierarchy && !CandyEatCamera.activeInHierarchy)
        {
            Layer1Active.SetActive(false);
            Layer2Active.SetActive(false);
            CandyEatCamera.SetActive(true);
            CandyCameraMain.SetActive(false);
            CandyCamera2.SetActive(false);
            
            CandyBoyAnimation.Play("CandyEat");

            CandyTriangle = true;

            count = 1;



            StartCoroutine(ExampleCoroutine());
        }
        
        if(CandyTriangle == true)
        {
            Candy.transform.position = CandyEatPoint.position;
            Candy.transform.rotation = CandyEatPoint.rotation;
        }


        if (inactiveChildCount >= 750 && gameObjectToCheck2.activeInHierarchy && !CandyEatCamera.activeInHierarchy)
        {
            Layer1Active.SetActive(false);
            Layer2Active.SetActive(false);
            CandyEatCamera.SetActive(true);
            CandyCameraMain.SetActive(false);
            CandyCamera2.SetActive(false);

            CandyBoyAnimation.Play("CandyEat");

            CandyTriangle = true;

            count = 2;



            StartCoroutine(ExampleCoroutine());
        }

        if (inactiveChildCount >= 450 && gameObjectToCheck3.activeInHierarchy && !CandyEatCamera.activeInHierarchy)
        {
            Layer1Active.SetActive(false);
            Layer2Active.SetActive(false);
            CandyEatCamera.SetActive(true);
            CandyCameraMain.SetActive(false);
            CandyCamera2.SetActive(false);

            CandyBoyAnimation.Play("CandyEat");

            CandyTriangle = true;

            count = 3;



            StartCoroutine(ExampleCoroutine());
        }


        if(gameObjectToCheck1.activeInHierarchy)
        {
            float floatValue = (float)inactiveChildCount / 1200f;
            // Set the slider value to the converted float value
            slider.value = floatValue;
            CurrentLevelText.text = "1";
            NextLevelText.text = "2";
        }


        if (gameObjectToCheck2.activeInHierarchy)
        {
            float floatValue = (float)inactiveChildCount / 750f;
            // Set the slider value to the converted float value
            slider.value = floatValue;
            CurrentLevelText.text = "2";
            NextLevelText.text = "3";
        }

        if (gameObjectToCheck3.activeInHierarchy)
        {
            float floatValue = (float)inactiveChildCount / 450f;
            // Set the slider value to the converted float value
            slider.value = floatValue;
            CurrentLevelText.text = "3";
            NextLevelText.text = "#";
        }

        


    }

    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(6f);

        Candy.transform.position = CandyInitialPoint.position;
        Candy.transform.rotation = CandyInitialPoint.rotation;
        CandyEatCamera.SetActive(false);
        CandyCameraMain.SetActive(true);
        CandyCamera2.SetActive(false);

        if (count == 1)
        {
            L1.SetActive(false);
            L2.SetActive(true);
        }

        if (count == 2)
        {
            
            L2.SetActive(false);
            L3.SetActive(true);
        }

        if (count == 3)
        {

          
            L3.SetActive(false);
        }




        CandyTriangle = false;

        drill.transform.position = TargetDrillPosition.position;
        drill.transform.rotation = TargetDrillPosition.rotation;

        foreach (Transform child in Candy.transform)
        {
            child.gameObject.SetActive(true); // set the child game object to active
        }

    }

    float toggleZrotation = -39.3f;
    

    private void OnTriggerEnter(Collider other)
    {
        Handheld.Vibrate();

        

        if (other.tag == "CandyCube")
        {
            other.gameObject.SetActive(false);
        }

        if (gameObjectToCheck1.activeInHierarchy && other.tag == "GameOver")
        {

            foreach (Transform child in Candy.transform)
            {
                child.gameObject.SetActive(true); // set the child game object to active
            }

            

            
        }

        if (gameObjectToCheck2.activeInHierarchy && other.tag == "GameOver")
        {
            foreach (Transform child in Candy.transform)
            {
                child.gameObject.SetActive(true); // set the child game object to active
            }
            

        }

        if (gameObjectToCheck3.activeInHierarchy && other.tag == "GameOver")
        {
            foreach (Transform child in Candy.transform)
            {
                child.gameObject.SetActive(true); // set the child game object to active
            }

            


        }

    }

    public void ChangeDrillToStraight()
    {

        
        drill.transform.rotation = TargetDrillPosition1.rotation;

    }

    public void ChangeDrillToInitialPosition()
    {

        drill.transform.position = TargetDrillPosition.position;
        drill.transform.rotation = TargetDrillPosition.rotation;

    }

    private void OnTriggerExit(Collider other)
    {
        

        if (gameObjectToCheck1.activeInHierarchy && other.tag == "GameOver")
        {

            foreach (Transform child in Candy.transform)
            {
                child.gameObject.SetActive(true); // set the child game object to active
            }




        }

        if (gameObjectToCheck2.activeInHierarchy && other.tag == "GameOver")
        {
            foreach (Transform child in Candy.transform)
            {
                child.gameObject.SetActive(true); // set the child game object to active
            }


        }

        if (gameObjectToCheck3.activeInHierarchy && other.tag == "GameOver")
        {
            foreach (Transform child in Candy.transform)
            {
                child.gameObject.SetActive(true); // set the child game object to active
            }




        }

    }
}