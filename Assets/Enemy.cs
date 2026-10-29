using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float aggroRange = 10f;
    public float attackRange = 1.5f;
    public float attackCooldown = 1.5f;
    public int attackDamage = 1;
    public Transform player;
    private float nextAttckTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Rigidbody2D>().linearVelocity.magnitude > 0.1f)
        {
            GetComponent<Animator>().SetBool("walk", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("walk", false);
        }
        Vector2 enemyPosition = transform.position;
        Vector2 playerPosition = player.position;
        float distance = Vector2.Distance(enemyPosition, playerPosition);



        
        
        if (distance > attackRange)
        {
            GetComponent<Rigidbody2D>().linearVelocity = (playerPosition - enemyPosition).normalized * moveSpeed;
        }
        else if (Time.time >= nextAttckTime)
        {
            player.GetComponent<PlayerHP>().TakeDamage(attackDamage);
            nextAttckTime = Time.time + attackCooldown;
        }
    }
}
