using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool wKeyPressed = Input.GetKey("w");
        bool sKeyPressed = Input.GetKey("s");
        bool aKeyPressed = Input.GetKey("a");
        bool dKeyPressed = Input.GetKey("d");


            
        if (wKeyPressed)
        {
            animator.SetBool("isJogging", true);
        }
        if(!wKeyPressed)
        {
            animator.SetBool("isJogging", false);
        }

        if (sKeyPressed)
        {
            animator.SetBool("isJoggingBack", true);
        }
        if (!sKeyPressed)
        {
            animator.SetBool("isJoggingBack", false);
        }

        if (aKeyPressed)
        {
            animator.SetBool("isJoggingLeft", true);
        }
        if (!aKeyPressed)
        {
            animator.SetBool("isJoggingLeft", false);
        }

        if (dKeyPressed)
        {
            animator.SetBool("isJoggingRight", true);
        }
        if (!dKeyPressed)
        {
            animator.SetBool("isJoggingRight", false);
        }

        if (sKeyPressed && dKeyPressed)
        {
            animator.SetBool("isJoggingBack", false);
            animator.SetBool("isJoggingRight", false);
            animator.SetBool("isJoggingBR", true);
        }
        if (!sKeyPressed && !dKeyPressed)
        {
            animator.SetBool("isJoggingBR", false);
        }

        if (sKeyPressed && aKeyPressed)
        {
            animator.SetBool("isJoggingBack", false);
            animator.SetBool("isJoggingLeft", false);
            animator.SetBool("isJoggingBL", true);
        }
        if (!sKeyPressed && !aKeyPressed)
        {
            animator.SetBool("isJoggingBL", false);
        }

        if (wKeyPressed && aKeyPressed)
        {
            animator.SetBool("isJogging", false);
            animator.SetBool("isJoggingLeft", false);
            animator.SetBool("isJoggingFL", true);
        }
        if (!wKeyPressed && !aKeyPressed)
        {
            animator.SetBool("isJoggingFL", false);
        }

        if (wKeyPressed && dKeyPressed)
        {
            animator.SetBool("isJogging", false);
            animator.SetBool("isJoggingRight", false);
            animator.SetBool("isJoggingFR", true);
        }
        if (!wKeyPressed && !dKeyPressed)
        {
            animator.SetBool("isJoggingFR", false);
        }
    }
}
