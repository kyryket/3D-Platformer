using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float second = 60;
    public int minute = 3;

    void Update()
    {
     second -= Time.deltaTime;
     if(minute >= 1)
     {
     if(second <= 0)
     {
        minute--;
        second = 59;
     }
     }
     if(minute == 0)
     {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
       SceneManager.LoadScene(sceneIndex);
     }
    }
}
