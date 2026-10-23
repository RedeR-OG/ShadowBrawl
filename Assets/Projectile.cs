using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public LayerMask enemy;
    public enum ProjectileType
    {
        Normal, Heavy, Explosion
    }
    [Header("Projectile Settings")]
    public ProjectileType type;
    public float speed = 8f;
    public float lifetime = 3f;
    public int damage = 1;

    [Header("Explosion Settings")]
    public float explosionRadius = 3f;

    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = transform.right;
        if (type == ProjectileType.Normal)
        {
            damage = 1;
        }
        else if (type == ProjectileType.Heavy)
        {
            damage = 3;
            transform.localScale *= 0.5f;
            
        }
        else if (type == ProjectileType.Explosion)
        {
            damage = 2;
            
        }
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (type == ProjectileType.Explosion)
        {
            Explode();
        }
        else if (other.TryGetComponent(out EnemyHealth target))
        {
            target.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
    void Explode()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, explosionRadius);
        foreach (Collider2D hit in hits)
        {
            EnemyHealth enemy = hit.GetComponent<EnemyHealth>();
            if (enemy != null)
                enemy.TakeDamage(damage);
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (type == ProjectileType.Explosion)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, explosionRadius);
        }
    }
}
