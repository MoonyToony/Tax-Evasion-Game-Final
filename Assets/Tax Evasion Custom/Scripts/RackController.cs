using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RackController : MonoBehaviour
{

    public Animator doorAnim;

    private bool doorOpen = false;

    private void awake()
    {
        //doorAnim = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
            doorAnim.Play("New Animation1", 0, 0f);
            doorOpen = true;
    }

}
