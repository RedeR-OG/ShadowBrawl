using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public bool gambleCollide = false;
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("GambleZone"))
        {
            gambleCollide = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("GambleZone"))
        {
            gambleCollide = false;
        }
    }

    void Update()
    {
        if (gambleCollide == true && Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("gamble zone here");
            //GetComponents(PlayerShoot)
        }
    }
}
