using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private LayerMask ground;
    [SerializeField] private Transform groundTransform;

    public float jumpForce;

    private Rigidbody rb;
    private bool spacePressed = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }
    }

    void FixedUpdate()
    {
        if (Physics.OverlapSphere(groundTransform.position, 1f, ground).Length > 0)
        {
            if (spacePressed)
            {
                rb.AddForce(Vector3.up * jumpForce);
                spacePressed = false;
            }
        }
    }
}
