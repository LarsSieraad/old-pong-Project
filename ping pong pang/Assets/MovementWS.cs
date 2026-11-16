using UnityEngine;
using UnityEngine.Rendering;

public class player_movement : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D rb;
    float movement_y;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movement_y = 0;
    }

    void Update()
    {
        rb.AddForce(new Vector2(0, movement_y * speed * Time.deltaTime), ForceMode2D.Impulse);

        if (Input.GetKeyDown(KeyCode.W))
        {
            movement_y =+ 1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            movement_y =- 1;
        }
    }
}
