using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement2D : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 velocity;
    public Transform startPosition;

    [SerializeField] float forwardForce;
    [SerializeField] Text label;

    private int attemptCount = 1;

    private void Start()
    {
        forwardForce = 6f;
        StartCoroutine(Timer());
        rb = GetComponent<Rigidbody>();
        rb.transform.position = startPosition.position;
        label.text = "Attempt : " + attemptCount;
    }

    private void Update()
    {
        velocity = rb.velocity;
        Debug.Log("Attempt: " + attemptCount);
    }

    // Fixed update because we are using Physics, and time.deltaTime because
    // we are moving an object over time (makes it frame independent).
    private void FixedUpdate()
    {
        transform.position += transform.forward * forwardForce * Time.deltaTime;
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Restart();
        }
    }

    void Restart()
    {
        Time.timeScale = 0;
        rb.velocity = Vector3.zero;
        attemptCount++;
        label.text = "Attempt : " + attemptCount;
        rb.transform.position = startPosition.position;
        Time.timeScale = 1;
    }
}
