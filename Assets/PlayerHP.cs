using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int MaxHP = 3;
<<<<<<< HEAD
    public int nowHP;
    public static int currentHP = 3;
=======
    public int currentHP = 3;
>>>>>>> 8ba3cf62495ddabe40e337c3120bf761d6cd7664
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
<<<<<<< HEAD
    private void Start()
    {
        nowHP = currentHP;
    }
=======

>>>>>>> 8ba3cf62495ddabe40e337c3120bf761d6cd7664
    // Update is called once per frame
    void Update()
    {
        
<<<<<<< HEAD
        
        if (currentHP > MaxHP)
        {
            currentHP = MaxHP;
        }
=======
>>>>>>> 8ba3cf62495ddabe40e337c3120bf761d6cd7664
    }
}
