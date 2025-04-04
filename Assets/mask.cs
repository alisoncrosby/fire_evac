using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mask : MonoBehaviour
{

    public GameObject maskMesh;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "KN95 Mask")
        {
            Destroy(other.gameObject);
            maskMesh.SetActive(true);
        }
    }
}
