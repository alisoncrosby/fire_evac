using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class packingList : MonoBehaviour
{

    private string pack;
    private TextMeshProUGUI packlist;

    // Start is called before the first frame update
    void Start()
    {
        pack = GameObject.FindGameObjectWithTag("Collected").GetComponent<collected>().itemList;
        packlist = GetComponent<TextMeshProUGUI>();
        packlist.text = pack;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
