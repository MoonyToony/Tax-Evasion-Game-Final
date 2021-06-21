using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject Spawned;

    public float spawnTime;
    public float spawnDelay;
    // Start is called before the first frame update
    public void SpawnObject()
    {
        GameObject temporary = Instantiate(Spawned, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
}
