using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
    public Animator anim;
    
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            anim.SetTrigger("push");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetTrigger("push");
        }
    }
}
