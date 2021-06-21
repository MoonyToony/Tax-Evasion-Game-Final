using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public float speed = 40;
    // this is only for full auto weapons
    [Tooltip("This is only for full auto weapons. Does nothing if it's semi auto")]
    public float fullAutoFireRate = 0.1f;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource audioSource;
    public AudioClip audioClip;

    // for full auto firing
    Coroutine firingRoutine;
    WaitForSeconds firingWait;

    void Awake()
    {
        firingWait = new WaitForSeconds(fullAutoFireRate);
    }

    public void Fire()
    {
        CreateProjectile();
    }

    public void StartFullAuto()
    {
        firingRoutine = StartCoroutine(FullAutoFire());
    }

    public void EndFullAuto()
    {
        StopCoroutine(firingRoutine);
    }

    IEnumerator FullAutoFire()
    {
        while (gameObject.activeSelf)
        {
            CreateProjectile();
            yield return firingWait;
        }
    }

    void CreateProjectile()
    {
        GameObject projectile = Instantiate(bullet, barrel.position, barrel.rotation);
        projectile.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
        audioSource.PlayOneShot(audioClip);
        Destroy(projectile, 2);
    }
}
