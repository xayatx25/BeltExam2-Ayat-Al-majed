using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] private float TimeToCountDown = 20f;
    private float timer = 0f;
    [SerializeField] Text countdownText;
    [SerializeField] private string LoseScene;
    // Start is called before the first frame update
    void Start()
    {
        timer = TimeToCountDown;  
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        countdownText.text = timer.ToString("0");
        //Debug.Log($"timer is {timer}, and time since last frame is {Time.deltaTime}");
        if (timer <= 0)
        {
            timer = 0;
            SceneManager.LoadScene(LoseScene);
        }
    }
}
