using Unity.VisualScripting;
using UnityEngine;
public class
TestProceduralGeneration : MonoBehaviour
{
    [SerializeField] int width, height, Range;
    [SerializeField] GameObject[] Rooms;
    [SerializeField] GameObject[] Enemies;
    [SerializeField] int BaseEnemyCount = 1;
    public static event System.Action RoomSpawned;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        { 
            SpawnNextRoom();  
        }
        
    }
    private void SpawnNextRoom()
    {
        
        var element = Rooms[Random.Range(0, Rooms.Length)];

        Vector3 spawnPosition = transform.position + new Vector3(Range * width, 1f, 1f);
        

        Vector2 checkSize = new Vector2(width * 1f, 5f); 
        Collider2D hit = Physics2D.OverlapBox(spawnPosition, checkSize, 0f); 

        if (hit != null) 
        { return; }

        Instantiate(element, spawnPosition, Quaternion.identity);

        GameObject playerObj = GameObject.FindWithTag("Player");
        
        if (playerObj != null)
        {
            counter playerCounterComponent = playerObj.GetComponent<counter>();
            if (playerCounterComponent != null)
            {
                playerCounterComponent.kingkong++;
            }
        }

        Invoke(nameof(spawnEnemies), 0.2f);
    }

    void spawnEnemies()
    {
        

        Vector3 SpawnPosition = transform.position + new Vector3(Range * width, 5f, 1f);

        int currentDifficulty = 0;
        GameObject playerObj = GameObject.FindWithTag("Player");
        if (playerObj != null)
        {
            counter playerCounterComponent = playerObj.GetComponent<counter>();
            if (playerCounterComponent != null)
            {
                currentDifficulty = playerCounterComponent.kingkong;
            }
        }

        int spawnAmount = BaseEnemyCount + (currentDifficulty / 2);
        for (int i = 0; i < spawnAmount; i++)
        {
            var element = Enemies[Random.Range(0, Enemies.Length)];
            Instantiate(element, SpawnPosition, Quaternion.identity);
        }

        RoomSpawned?.Invoke();
    }

}