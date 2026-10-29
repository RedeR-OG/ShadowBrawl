using UnityEngine;
using UnityEngine.UIElements;

public class rangboi : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float range = 8f;
    public float chargeTime = 1.5f;
    private Transform player;
    private float chargeTimer;
    public float moveSpeed = 3f;
    public float aggroRange = 10f;
    private bool charging;
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
        if (distance > aggroRange)
        {
            return;
        }

        if (distance > range)
        {
            //transform.position = Vector2.MoveTowards(enemyPosition, playerPosition, moveSpeed * Time.deltaTime);
            GetComponent<Rigidbody2D>().linearVelocity = (playerPosition - enemyPosition).normalized * moveSpeed;
        }
        if (distance > range)
        {
            charging = false;
            chargeTimer = 0;

        }

        if (!charging)
        {
            charging = true;
            chargeTimer = 0;

        }
        chargeTimer += Time.deltaTime;

        if (chargeTimer >= chargeTime)
        {
            chargeTimer = 0;
            charging = false;
            Instantiate(projectilePrefab, firePoint.position, Quaternion.Euler(0, 0, Mathf.Atan2(player.position.y - firePoint.position.y, player.position.x - firePoint.position.x) * Mathf.Rad2Deg));
        }

    }
}
