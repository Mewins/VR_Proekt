using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Key"))
        {
            animator.SetTrigger("Open");
            Destroy(other.gameObject);
        }
    }
}
