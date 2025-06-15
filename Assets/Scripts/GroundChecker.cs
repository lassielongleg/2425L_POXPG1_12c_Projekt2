using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool isGrounded;
    public Animator anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        anim.SetBool("IsJump", false);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
