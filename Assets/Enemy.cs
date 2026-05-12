using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject EnemyCounter;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            EnemyCounter.GetComponent<EnemyCounter>().UpdateCounter(1);
        }

    }
}
