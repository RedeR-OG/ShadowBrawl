
using UnityEngine;
using TMPro;

public class ManaCounter : MonoBehaviour
{
    public PlayerShoot playerShoot;
    public TMP_Text manaText;

    void Update()
    {
        if (playerShoot == null || manaText == null)
            return;

        manaText.text = playerShoot.Mana + " / " + playerShoot.maxMana;
    }
}
