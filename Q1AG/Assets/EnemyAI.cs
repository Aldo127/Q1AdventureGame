using System.Collections;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed of enemy movement
    public float minWaitTime = 3f; // Minimum wait time before the next move
    public float maxWaitTime = 5f; // Maximum wait time before the next move

    private Vector2 randomDirection; // Random movement direction
    private float timer; // Timer to control movement delay
    private bool colliding; // Flag to track collisions

    private void Start()
    {
        // Initialize the timer with a random value within the specified range
        timer = Random.Range(minWaitTime, maxWaitTime);
        // Start the initial movement
        MoveRandomDirection();
    }

    private void Update()
    {
        // Update the timer
        timer -= Time.deltaTime;

        // Check if it's time to change direction
        if (timer <= 0f)
        {
            // Choose a new random direction
            MoveRandomDirection();
            // Reset the timer with a new random value within the specified range
            timer = Random.Range(minWaitTime, maxWaitTime);
        }

        // Move the enemy in the current direction
        transform.Translate(randomDirection * moveSpeed * Time.deltaTime);

        // Check for collisions
        if (colliding)
        {
            // Reverse the direction if a collision occurs
            MoveRandomDirection();
            colliding = false;
        }
    }

    private void MoveRandomDirection()
    {
        // Generate a random direction vector
        randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Detect collisions with other objects
        colliding = true;
    }
}
