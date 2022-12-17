using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class UIContoller : MonoBehaviour
{
    public Transform Drill;

    public Transform drillsize1;
    public Transform drillsize2;
    public Transform drillsize3;
    public Transform drillsize4;
    public Transform drillsize5;

    public AudioSource audioSource;
    public AudioSource audioSource1;






    public void ChangeDrillSize1()
    {
        Drill.localScale = drillsize1.localScale;
    }

    public void ChangeDrillSize2()
    {
        Drill.localScale = drillsize2.localScale;
    }

    public void ChangeDrillSize3()
    {
        Drill.localScale = drillsize3.localScale;
    }

    public void ChangeDrillSize4()
    {
        Drill.localScale = drillsize4.localScale;
    }

    public void ChangeDrillSize5()
    {
        Drill.localScale = drillsize5.localScale;
    }

    public void VibrateOnPaint()
    {
        Handheld.Vibrate();
    }

    public void VibrateOnDrill()
    {
        Handheld.Vibrate();
    }


    public void MuteAll()
    {
        audioSource.mute = true;
        audioSource1.mute = true;



    }

    public void UNMuteAll()
    {
        audioSource.mute = false;
        audioSource1.mute = false;



    }


    public void RestartScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }

}
