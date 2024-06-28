using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopCase : MonoBehaviour
{
    public GameObject lid1;
    public GameObject lid2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Laptop")
        {
            other.gameObject.SetActive(false);
            lid1.SetActive(false);
            lid2.SetActive(true);
        }
    }
}
