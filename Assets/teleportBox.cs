using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportBox : MonoBehaviour
{

    private Transform teleportSpot;
    public Animator packed1;
    public Animator packed2;
    public Animator packed3;
    public Animator carrier1;
    public Animator carrier2;
    public Animator carrier3;
    private GameObject temp;

    private void Start()
    {
        teleportSpot = GameObject.FindGameObjectWithTag("TeleportSpot").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collectable" && other.gameObject.name != "Salem the Cat" && other.gameObject.name != "Laptop")
        {
                temp = Instantiate(other.gameObject, teleportSpot.position, other.transform.rotation) as GameObject;
                temp.name = other.gameObject.name;
                Destroy(other.gameObject);
                packed1.SetTrigger("pack");
                packed2.SetTrigger("pack");
                packed3.SetTrigger("pack");
                GetComponent<ParticleSystem>().Play();
            
        }

        else if(other.gameObject.name == "Salem the Cat" || other.gameObject.name == "Laptop")
        {
            carrier1.SetTrigger("pack");
            carrier2.SetTrigger("pack");
            carrier3.SetTrigger("pack");
        }
    }
}
