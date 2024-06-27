using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cubeStart : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "StartBox")
        {
            SceneManager.LoadScene(1);
        }
    }
}
