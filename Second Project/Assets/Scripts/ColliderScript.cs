using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Table")
        {
            animator.Play("Hip Hop");
            audioSource.Play();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Table")
        {
            audioSource.Pause();
            animator.Play("Idle");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Trigger")
        {
            animator.Play("Boxing");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        animator.Play("Idle");
    }
}
