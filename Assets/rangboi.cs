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
    private bool charging;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

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
            Instantiate(projectilePrefab, firePoint.position, Quaternion.Euler(0, 0, Mathf.Atan2(player.position.y - firePoint.position.y, player.position.x - firePoint.position.x));
        }
    }
}
