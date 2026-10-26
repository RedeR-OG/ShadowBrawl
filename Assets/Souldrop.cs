using UnityEngine;

public class Souldrop : MonoBehaviour
{
    public GameObject soulPrefab;
    public int soulAmount = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void DroupSoul()
    {
        GameObject soul = Instantiate(soulPrefab, transform.position, Quaternion.identity);
        soul.GetComponent<SoulPickup>().soulAmount = soulAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
