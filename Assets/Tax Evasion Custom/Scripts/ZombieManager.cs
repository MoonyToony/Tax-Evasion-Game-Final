using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{
    public int health = 100;
    public int damage = 25;

    // Update is called once per frame
    void Update()
    {
        CheckHealth();
    }

    void CheckHealth()
    {
        if (health <= 0)
            Die();
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
}
