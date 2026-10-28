using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public bool gambleCollide = false;
    public int HPgamble;

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
        if (gambleCollide == true && Input.GetKeyDown(KeyCode.G))
        {
            HPgamble = Random.Range(0, 3);
            Debug.Log("HP+ " + HPgamble);
            
        }
    }
}
