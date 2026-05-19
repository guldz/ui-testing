using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyCounter : MonoBehaviour
{

    public TextMeshProUGUI counterText;
    private int enemyCount = 0;
    private bool mafiaDead = false;
    public bool MafiaDead => mafiaDead;
    int totalEnemies = 2;

    public int CurrentEnemyCount => enemyCount;

    void Start()
    {
        UpdateCounterText();
    }


    void UpdateCounterText()
    {
        counterText.text = $"Enemies: {enemyCount}/{totalEnemies}";
    }
    public void UpdateCounter(int Count)
    {

        enemyCount += Count;
        UpdateCounterText();

       // if (enemyCount >= totalEnemies)
      //  {
       //     SceneManager.LoadScene("win screen");  //if were to implement in mors cita when walking into the boom trigger at the 2dcollider make this run
       // }
    }

    


}