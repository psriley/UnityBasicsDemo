using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 6, -8);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.position + offset;
    }
}
