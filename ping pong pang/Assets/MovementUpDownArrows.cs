using UnityEngine;

public class MovementUpDownArrows : MonoBehaviour
{
    public float speed = 200;
    Rigidbody2D rb;
    float movement_y;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movement_y = 0;
    }

    void Update()
    {
        
        rb.AddForce(new Vector2(0,movement_y * speed * Time.deltaTime), ForceMode2D.Impulse);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movement_y = 1;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movement_y = -1;
        }

     }
}
