using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    //Public variables to access scene load from any other script - might need in gamne manager?
    public Animator transition;
    public float transitionTime = 1f;

    //Function to load the scene
    public void LoadNextScene()
    { 
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    //Courotine To delay the Scene Load - Animation has to play first
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

        //SceneManager.LoadScene("Scene B");   -Can also do this :)
    }
}
