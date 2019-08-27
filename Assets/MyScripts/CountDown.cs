using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountDown : MonoBehaviour
{
    float timeLeft = 30.0f;

    public Text text;
   

    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "time Left: " + timeLeft;
        
    }

    public Text updateTimeLeft(Text counter)
    {
        counter.text = "time Left: " + 10.0f;
        
        if (timeLeft < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        return (counter);
    }
}