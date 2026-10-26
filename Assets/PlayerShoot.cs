using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject normalProjectile;
    public GameObject heavyProjectile;
    public GameObject exsplosionProjectile;
    public Transform firepoint;
    public int maxMana = 100;
    public int Mana = 100;
    private Projectile.ProjectileType selectedProjectile = Projectile.ProjectileType.Normal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void onShoot(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed)
            return;
        Shoot();
    }
    public void Update()
    {
        maxMana = 100 + SoulPickup.totalSouls;
    }

    // Update is called once per frame
    public void OnNormalShot(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            selectedProjectile = Projectile.ProjectileType.Normal;
    }
    public void OnHeavyShot(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            selectedProjectile = Projectile.ProjectileType.Heavy;
    }
    public void OnExplosionShot(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            selectedProjectile = Projectile.ProjectileType.Explosion;
    }
     void Shoot ()
    {
        GameObject projectile = normalProjectile;
            int manaCost = 5;

        if (selectedProjectile == Projectile.ProjectileType.Heavy)
        {
            projectile = heavyProjectile;
            manaCost = 15;
        }

        else if (selectedProjectile == Projectile.ProjectileType.Explosion)
        {
            projectile = exsplosionProjectile;
            manaCost = 10;
        }
        if (Mana < manaCost || projectile == null || firepoint == null)
            return;
        Mana -= manaCost;
        Instantiate(projectile, firepoint.position, firepoint.rotation);
    }
    public void RestoreMana(int amount)
    {
        Mana = Mathf.Clamp(Mana + amount, 0, maxMana);
    }
}
