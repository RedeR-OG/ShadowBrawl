using System.Globalization;
using UnityEngine;

public class TestProceduralGeneration : MonoBehaviour
{
    [SerializeField] int width, height;
    [SerializeField] int Range;
    [SerializeField] GameObject[] Rooms;
    //      Make Sure to Randomize the Room Selection process when spawning the next room

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))  //WARNING WARNING WARNING - Make Sure the Player character has the "Player" Tag
        {
            SpawnNextRoom();
            Debug.Log("SpawnSomething!");
        }
    }

    private void SpawnNextRoom()
    {
        var element = Rooms[Random.Range(0, 1)];
        Vector3 spawnPosition = transform.position + new Vector3(Range * width, 1f, 1f);
    }
}