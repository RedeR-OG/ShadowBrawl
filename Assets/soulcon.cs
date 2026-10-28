using UnityEngine;
using TMPro;

public class soulcon : MonoBehaviour
{
    public TextMeshProUGUI soulText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SoulPickup.totalSouls = 0;
    }

    // Update is called once per frame
    void Update()
    {
        soulText.text = " " + SoulPickup.totalSouls;
    }
}
