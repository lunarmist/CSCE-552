using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "TutorialLevel")
        {
            remainingTime = 300;
        }

        if (SceneManager.GetActiveScene().name == "Level_1")
        {
            remainingTime = 180;

        }

        if (SceneManager.GetActiveScene().name == "Level_2")
        {
            remainingTime = 240;

        }

    }

    // Update is called once per frame
    void Update()
    {

        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;
            gameOver();
        }

        if (remainingTime < 10)
        {
            timerText.color = Color.red;
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        
    }

    void gameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}
