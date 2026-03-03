using UnityEngine;

public class AirSpawner2D : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);
        }
    }
}