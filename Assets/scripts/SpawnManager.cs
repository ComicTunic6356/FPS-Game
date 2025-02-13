using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;

    SpawnPoint[] spawnpoints;

    void Awake()
    {
        instance = this;
        spawnpoints = GetComponentsInChildren<SpawnPoint>();
    }

    public Transform GetSpawnpoint()
    {
        return spawnpoints[Random.Range( 0, spawnpoints.Length)].transform;
    }
}
