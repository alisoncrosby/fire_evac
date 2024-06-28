using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cubeStart : MonoBehaviour
{

    private float timer = -1;
    public Image dark;

    private void Update()
    {
        if(timer >= 0)
        {
            timer += Time.deltaTime;
            dark.color = Color.Lerp(dark.color, Color.black,timer/3f);
            if(timer >= 3)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "StartBox")
        {
            timer = 0;
        }
    }
}
