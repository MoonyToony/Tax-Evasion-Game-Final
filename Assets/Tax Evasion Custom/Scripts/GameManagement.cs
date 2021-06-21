using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    [Tooltip("This map will start spawning zombies")]
    public bool spawnZombies = false;
    [Tooltip("Array of zombie spawn GameObject locations")]
    public GameObject[] listOfZombieSpawns;
    [Tooltip("The zombie game object to spawn in")]
    public GameObject zombie;

    /// <summary>The current time for the timer that forces a next round to begin.</summary>
    float currentTime;

    /// <summary>Start a coroutine for zombie spawning</summary>
    Coroutine runZombieSpawner;
    /// <summary>Cooldown for zombie spawning so that they don't spawn on top of each other</summary>
    WaitForSeconds zombieSpawnerCooldown;

    void Awake()
    {
        // zombie spawner will instantiate a new zombie every 1 second (only when there are zombies to spawn since there is a limit)
        zombieSpawnerCooldown = new WaitForSeconds(1f);
    }

    void StartSpawningZombies()
    {
        runZombieSpawner = StartCoroutine(ZombieSpawningSequence());
    }

    void StopSpawningZombies()
    {
        StopCoroutine(runZombieSpawner);
    }

    IEnumerator ZombieSpawningSequence()
    {
        while (gameObject.activeSelf)
        {
            SpawnZombie();
            // instantiate zombies here
            yield return zombieSpawnerCooldown;
        }
    }

    void SpawnZombie()
    {
        GameObject spawned = Instantiate(
            zombie, 
            listOfZombieSpawns[Random.Range(0, listOfZombieSpawns.Length)].transform.position,
            listOfZombieSpawns[Random.Range(0, listOfZombieSpawns.Length)].transform.rotation
        );
    }
}
