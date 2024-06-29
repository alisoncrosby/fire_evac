using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{

    private float endTimer = 3;
    public bool win;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        endTimer -= Time.deltaTime;
        if(endTimer < 0)
        {
            if (win)
            {
                SceneManager.LoadScene(2);
            } else
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
