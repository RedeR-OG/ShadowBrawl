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
        Vector2 enemyPosition = transform.position;
        Vector2 playerPosition = player.position;
        float distance = Vector2.Distance(enemyPosition, playerPosition);

        if (distance > aggroRange)
        {
            return;
        }
        if (distance > attackRange)
        {
            transform.position = Vector2.MoveTowards(enemyPosition, playerPosition, moveSpeed * Time.deltaTime);
        }
        else if (Time.time >= nextAttckTime)
        {
            player.GetComponent<PlayerHP>().TakeDamage(attackDamage);
            nextAttckTime = Time.time + attackCooldown;
        }
    }
}
