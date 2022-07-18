using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction: MonoBehaviour
{
    public Animator animator;

    public void Punch()
    {
        animator.Play("Punch");
    }

    public void Running()
    {
        animator.Play("Running");
    }

}
