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
<<<<<<< HEAD
            Souldrop souldrop = GetComponent<Souldrop>();
            if (souldrop != null)
                souldrop.DroupSoul();
=======
>>>>>>> 8ba3cf62495ddabe40e337c3120bf761d6cd7664
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
