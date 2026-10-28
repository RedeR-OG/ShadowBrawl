using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public bool gambleCollide = false;
    public int HPgamble;
    public int Gamba;
    public int SoulGamble;

    void Start()
    {
        GetComponent<PlayerShoot>();
        GetComponent<PlayerHP>();
        GetComponent<SoulPickup>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("GambleZone"))
        {
            gambleCollide = true;
            Debug.Log("gamble enter");
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("GambleZone"))
        {
            gambleCollide = false;
            Debug.Log("gamble exit");
        }
    }

    void Update()
    {
        Gamba = Random.Range(1, 3);
        if (gambleCollide == true && Input.GetKeyDown(KeyCode.G) && SoulPickup.totalSouls >= 10)
        {
            if (Gamba == 1)
            {
                SoulPickup.totalSouls -= 10;
                HPgamble = Random.Range(0, 3);
                Debug.Log("HP+ " + HPgamble);
                GetComponent<PlayerHP>().currentHP += HPgamble;
                
            }
            if (Gamba == 2)
            {
                SoulPickup.totalSouls -= 10;
                SoulGamble = Random.Range(0, 31);
                Debug.Log("Souls +" + SoulGamble);
                SoulPickup.totalSouls += SoulGamble;
            }
            if (SoulPickup.totalSouls < 10)
            {
                Debug.Log("no gamble");
            }
            
        }
    }
}
