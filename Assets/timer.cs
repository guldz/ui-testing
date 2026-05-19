using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    void Update()
    {
       // if (remainingTime > 0)
       // {
          // remainingTime -= Time.deltaTime;
      // }
        if (remainingTime < 0)
        {
            remainingTime = 0;

            SceneManager.LoadScene("Game over");
        }

            remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    //if time 0 switch to loose screen, when collected all enemies switch to win screen
}
