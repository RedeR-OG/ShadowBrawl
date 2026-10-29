using UnityEngine;

public class SoulPickup : MonoBehaviour
{
    public int soulAmount = 1;
    public static int totalSouls = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            totalSouls += soulAmount;

            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
