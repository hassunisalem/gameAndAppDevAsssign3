using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PointScriptCar : MonoBehaviour
{
    float timeLeft = 30.0f;
    CountDown countDown;
        public Text counter;


    void Update()
    {
        timeLeft -= Time.deltaTime;
        counter.text = "time Left: " + timeLeft;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

        public void OnTriggerEnter(Collider col)
        {


            print("ramt");

        timeLeft += 10.0f;

       
        //counter.text = "timerrs Left: " + 10.0f;
    }
    }

