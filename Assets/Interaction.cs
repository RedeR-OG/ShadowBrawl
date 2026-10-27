using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public bool gambleCollide = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter2D()
    {
        CompareTag("GambleZone");
        {
            
            gambleCollide = true;

            if (gambleCollide == true)
            {
                Debug.Log("gamble zone here");
            //    KeyCode.G;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
