using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public Collectables c;

    public float walkSpeed = 5f;
    float speedLimiter = 0.7f;
    public float inputHorizontal;
    public float inputVertical;
    public SpriteRenderer sr;
    public Sprite gooseDisguise;
    public bool playerIsClose;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown("a"))
        {
            sr.flipX = true;
        }

        if (Input.GetKeyDown("d"))
        {
            sr.flipX = false;
        }

        if (Input.GetKeyUp(KeyCode.E) && playerIsClose)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = gooseDisguise;
            Debug.Log("tag");
        }
    }

    
 

    private void FixedUpdate()
    {
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            if (inputHorizontal != 0 && inputVertical != 0)
            {
                inputHorizontal *= speedLimiter;
                inputVertical *= speedLimiter;
            }

            rb.velocity = new Vector2(inputHorizontal * walkSpeed, inputVertical * walkSpeed);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BIN"))
        {
            playerIsClose = true;
        }

        if (other.CompareTag("Evidence"))
        {
            Destroy(other.gameObject);
            c.evidenceCount++;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("BIN"))
        {
            playerIsClose = false;

        }
    }
}