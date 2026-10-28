using UnityEngine;

public class project : MonoBehaviour
{
    public float speed = 6f;
    public int damage = 1;
    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = transform.right;
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHP hp = other.GetComponent<PlayerHP>();
            if (hp != null)
                hp.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
