using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UIElements;

public class BallScript : MonoBehaviour
{
    Rigidbody2D rb;
    float leftBound = -12f;
    float rightBound = 12f;

    float speedX = -100;
    float speedY = 0;

    private float yForceRange = 50;
    float startspeed = 4;

    [SerializeField] GameObject ball;

    private AudioSource AudioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AudioSource = GetComponent<AudioSource>();
        Vector2 force = new Vector2(speedX, speedY);
        rb.AddForce(force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float yForce = Random.Range(-yForceRange, yForceRange);
        Vector2 force = new Vector2(0, yForce);
        rb.AddForce(force);
        AudioSource.Play();
    }

    void Update()
    {
        if (transform.position.x < leftBound)
        {
            transform.position = Vector2.zero;
            rb.linearVelocity = new Vector2(startspeed, 0);
            gameManeger.instance.score2++;
        }
        else if (transform.position.x > rightBound)
        {
            transform.position = Vector2.zero;
            rb.linearVelocity = new Vector2(startspeed, 0);
            gameManeger.instance.score1++;
        }
    }

    
}
