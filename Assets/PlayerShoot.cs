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
    private int selectedProjectile = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void onShoot(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed)
            return;
        Shoot();
    }

    // Update is called once per frame
    public void OnNormalShot(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            selectedProjectile = 1;
    }
    public void OnHeavyShot(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            selectedProjectile = 2;
    }
    public void OnExplosionShot(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            selectedProjectile = 3;
    }
     void Shoot ()
    {
        GameObject projectile = normalProjectile;
            int manaCost = 5;

        if (selectedProjectile == 2)
        {
            projectile = heavyProjectile;
        }

        else if (selectedProjectile == 3)
        {
            projectile = exsplosionProjectile;
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
