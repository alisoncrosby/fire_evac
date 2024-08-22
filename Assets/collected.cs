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
        if(other.tag == "Collectable" || other.tag == "Carrier" || other.tag == "Case")
        {
            if(other.gameObject.name == "Cat Carrier" && itemList.Contains("Cat Carrier"))
            {
                //don't add cat carrier twice
            }
            else
            {

                itemList += other.gameObject.name + "\n";
            }
        }
    }

}
