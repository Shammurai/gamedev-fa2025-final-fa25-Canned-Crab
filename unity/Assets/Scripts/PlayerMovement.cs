using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 5f;

    private Rigidbody2D rb;
    //private Vector2 movementInput;

    public InputAction MoveAction;
    Vector2 move = Vector2.zero;

    //Animator animator;
    Vector2 moveDirection = new Vector2(0.0f, 0.0f);


    void Start()
    {
        MoveAction.Enable();
        rb = GetComponent<Rigidbody2D>();
        enabled = true;

       // animator = GetComponent<Animator>();
    }

    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();

        //animator
        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            moveDirection.Set(move.x, move.y);
            moveDirection.Normalize();
        }

        /*
        animator.SetFloat("Look X", moveDirection.x);
        animator.SetFloat("Look Y", moveDirection.y);
        animator.SetFloat("Speed", move.magnitude);
        */
    }

    private void FixedUpdate()
    {
        Vector2 targetPos = rb.position + (move * walkSpeed * Time.deltaTime);
        rb.MovePosition(targetPos);
    }
}
