using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoreSystem.currentScore += 50;
        Destroy(gameObject);
    }
}

