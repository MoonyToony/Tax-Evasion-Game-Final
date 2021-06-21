using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 20;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Zombie")
        {
            other.gameObject.GetComponent<ZombieManager>().health -= damage;
            // debug
            print("Projectile struck zombie. Zombie Health: " + other.gameObject.GetComponent<ZombieManager>().health);
        }
    }
}
