using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2D : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(10, 4, 6);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.position + offset;
    }
}
