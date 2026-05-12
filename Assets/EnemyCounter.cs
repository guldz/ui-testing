using UnityEngine;
using TMPro;
public class EnemyCounter : MonoBehaviour
{

    public TextMeshProUGUI counterText;
    private int enemyCount = 0;
    private bool mafiaDead = false;
    public bool MafiaDead => mafiaDead;
    int totalEnemies = 2;


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

    }
}