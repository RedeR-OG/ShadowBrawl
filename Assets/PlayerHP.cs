using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int MaxHP = 3;
    public int nowHP;
    public static int currentHP = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        nowHP = currentHP;
    }
    // Update is called once per frame
    void Update()
    {
        
        
        if (currentHP > MaxHP)
        {
            currentHP = MaxHP;
        }
    }
}
