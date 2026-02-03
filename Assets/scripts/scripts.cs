using UnityEngine;

public class scripts : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public float moveSpeed = 4;
    public float jumpForce = 10;

    private float inputX = 0;
    private float facing = 1; //1 = right, -1 left
    private bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");

        //facing direction

        if (inputX > 0)
        {
            facing = 1;
        }

        else if (inputX <0)
        {
            facing = -1;
        }

        //flipping sprite
        if (facing >= 0.01f)
        {
            spriteRenderer.flipX = false;
        }
        else if(facing < 0.01f)
        {
            spriteRenderer.flipX = true;
        }

        //if (Input.GetButtonDown("KeyCode.Space"))
        //{

        //}




        //if (Input.GetButtonDown("Jump"))
        //{
        //    rigidBody.AddForce(Vector2)
        //}

    }

    private void FixedUpdate()
    {
        rigidBody.linearVelocityX = inputX * moveSpeed;
        // rigidBody.linearVelocityX = new Vector2(input.
    }

}
