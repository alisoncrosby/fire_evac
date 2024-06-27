using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meowScript : MonoBehaviour
{

    private float timer;
    private AudioSource meow;
    public GameObject cat;

    // Start is called before the first frame update
    void Start()
    {
        meow = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            timer = Random.Range(3, 6);
            meow.pitch = Random.Range(0.75f, 1.25f);
            meow.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Carrier")
        {
            cat.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}