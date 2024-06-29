using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keys : MonoBehaviour
{

    public GameObject fader;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key" && !fader.activeInHierarchy)
        {
            fader.SetActive(true);
            fader.GetComponent<gameOver>().win = true;
        }
    }
}
