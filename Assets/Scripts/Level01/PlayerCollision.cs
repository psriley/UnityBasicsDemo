using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Vector3 startingPosition;
    private PlayerMovement movement;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            movement.enabled = false;
            Restart();
        }
    }

    void Restart()
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
