using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    public float second = 60;
    public int minute = 3;
    public int roundSeconds;
    public TextMeshProUGUI timerText;

    void Update()
    {
     second -= Time.deltaTime;
     if(second <= 0)
     {
     if(minute >= 1)
     {
        minute--;
        print(minute);
        second = 59;
     }
     }
     if(minute == 0)
     {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
       SceneManager.LoadScene(sceneIndex);
     }
     roundSeconds = Mathf.RoundToInt(second);
     timerText.text = minute + ":" + roundSeconds.ToString("00");
    }
}
