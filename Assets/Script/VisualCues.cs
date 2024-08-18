using UnityEngine;

public class VisualCues : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Get the Animator component
        animator = GetComponent<Animator>();

        // Set the initial value of the "Hehe" parameter
        animator.SetBool("Hehe", true);
    }

    void FixedUpdate()
    {
        // Check for input and toggle the "Hehe" parameter
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Destroy(gameObject);
        }
    }
}