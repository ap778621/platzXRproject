using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;
    public float spawnInterval = 2f;
    public float minX = -4f; 
    public float maxX = 4f;   

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 0f, spawnInterval);
    }

    private void SpawnObject()
    {
        Vector3 position = spawnPoint != null ? spawnPoint.position : transform.position;
        position.x = Random.Range(minX, maxX); 
        Instantiate(prefab, position, Quaternion.identity);
    }
}