using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerPunch : MonoBehaviour
{
    public int damage = 1;
    public float punchRange = 2f;
    public LayerMask enemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnAttack(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) return;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, punchRange, enemy);
        if (hit.collider != null)
        {
            if (hit.collider.TryGetComponent(out EnemyHealth target))
            {
                target.TakeDamage(damage);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
