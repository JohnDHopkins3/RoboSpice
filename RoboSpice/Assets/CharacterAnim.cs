using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            animator.SetBool("isJumping",true);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }
    }

}
