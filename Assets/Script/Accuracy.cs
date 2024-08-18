using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Accuracy : MonoBehaviour
{
    private Animator animator;
    public Cut score;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Hihi", false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (score.score < 45)
        {
            animator.SetBool("Hihi", false);
        }
        else if (score.score >= 45)
        {
            animator.SetBool("Hihi", true);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Hihi", false);
            StartCoroutine(LoadSceneAndDestroy());
        }
    }

    IEnumerator LoadSceneAndDestroy()
    {
        StartCoroutine(LoadSceneAfterDelay());
        
        yield return new WaitForSeconds(1f); 
        Destroy(gameObject);
    }

    IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(1f); // Adjust delay as needed
        SceneManager.LoadScene(1); // Replace with your scene name
    }
}