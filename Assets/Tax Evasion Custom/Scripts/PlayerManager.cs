using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    // player health
    public int health = 100;
    [SerializeField]
    private int maxHealth = 100;
    // player purchasing points
    public int points = 500;

    float dmgReceivedDelay = 1f;

    void Awake()
    {
        NormalizeHealth();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Zombie")
            Die();
    }
    
    void Update()
    {
        CheckHealth();
    }

    void CheckHealth()
    {
        if (health > maxHealth)
            NormalizeHealth();
        
        if (health <= 0)
            Die();
    }

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void NormalizeHealth()
    {
        health = maxHealth;
    }
}
