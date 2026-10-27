using UnityEngine;
public class
TestProceduralGeneration : MonoBehaviour
{
    [SerializeField] int width, height, Range;
    [SerializeField] GameObject[] Rooms;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) { SpawnNextRoom(); }
    }
    private void SpawnNextRoom()
    {
        
        var element = Rooms[Random.Range(0, Rooms.Length)];

        Vector3 spawnPosition = transform.position + new Vector3(Range * width, 1f, 1f);
        

        Vector2 checkSize = new Vector2(width * 1f, 5f); Collider2D hit = Physics2D.OverlapBox(spawnPosition, checkSize, 0f); 

        if (hit != null) { return; }

        Instantiate(element, spawnPosition, Quaternion.identity);
        GetComponent<counter>().kingkong++;
        
    }
}