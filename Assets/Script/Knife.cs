using TMPro;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float forwardDistance = 0.5f;
    public Vector3 targetPosition;
    private Rigidbody rb;
    private bool isCutting = false;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        anim.SetBool("isCutting", false);

    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            anim.SetBool("isCutting", false);
            Debug.Log("right");
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && !isCutting)
        {
            anim.SetBool("isCutting", true);
        }
    }
}