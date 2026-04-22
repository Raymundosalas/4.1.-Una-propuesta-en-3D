using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int value = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.score += value;
            Destroy(gameObject);
        }
    }
}
