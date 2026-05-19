using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public EnemyCounter enemyCounter;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            if (enemyCounter.CurrentEnemyCount >= 2)
            {
                SceneManager.LoadScene("win screen");
            }
        }
    }
}
