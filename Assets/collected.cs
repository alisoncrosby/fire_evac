using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collected : MonoBehaviour
{
    public string itemList;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Rigidbody>() != null && other.transform.parent.name != "TrackerOffsets" && other.gameObject.name != "Auto Hand Player")
        {
            itemList += other.gameObject.name + "\n";
        }
    }

}
