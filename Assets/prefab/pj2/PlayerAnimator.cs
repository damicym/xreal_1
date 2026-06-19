using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Movimiento
        float speed = 0f;

        if (Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.D))
        {
            speed = 1f;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 2f;
        }

        animator.SetFloat("Speed", speed);

        // Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        // Golpe
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Punch");
        }

        // Saludo
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("Salute");
        }
    }
}