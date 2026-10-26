using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void TakeDamage(int damage)
    {
        health -= damage;
        
       if (health <= 0)
        {
            Souldrop souldrop = GetComponent<Souldrop>();
            if (souldrop != null)
                souldrop.DroupSoul();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
