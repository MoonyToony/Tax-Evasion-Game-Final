using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{

    public Animator doorAnim;

    private bool doorOpen = false;

    private void awake()
    {
        //doorAnim = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
            doorAnim.Play("New Animation", 0, 0f);
            doorOpen = true;
    }

}
