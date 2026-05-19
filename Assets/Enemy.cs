using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject EnemyCounter;
    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip yay;


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
            audioSource.PlayOneShot(yay);
            Destroy(gameObject);
            EnemyCounter.GetComponent<EnemyCounter>().UpdateCounter(1);
          
        }

    }
}
