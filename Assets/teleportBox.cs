using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportBox : MonoBehaviour
{

    private Transform teleportSpot;
    public Animator packed1;
    public Animator packed2;

    private void Start()
    {
        teleportSpot = GameObject.FindGameObjectWithTag("TeleportSpot").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collectable")
        {
            if(other.gameObject.name != "Salem the Cat")
            {
                other.transform.position = teleportSpot.position;
                packed1.SetTrigger("pack");
                packed2.SetTrigger("pack");
                GetComponent<ParticleSystem>().Play();
            }
        }
    }
}
