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
            else if(!itemList.Contains(other.gameObject.name))
            {

                itemList += other.gameObject.name + "\n";
            } else if (other.gameObject.name == "Book" || other.gameObject.name == "Notebook" || other.gameObject.name == "Walkie Talkie" || other.gameObject.name == "Battery" || other.gameObject.name == "Plant" || other.gameObject.name == "VHS Tape" || other.gameObject.name == "Clothes")
            {

                itemList += other.gameObject.name + "\n";
            }
        }
    }

}
