using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTreasure : MonoBehaviour {

    void Update()
    {

    }
    
    void Start()
    {

    }

	void OnTriggerEnter(Collider obj)
    {
        Debug.Log(obj.gameObject.name + "ciao");
        Debug.Log(  "ciao");
        if (obj.gameObject.name == "FPSController")
        {
            GetComponent<Animator>().SetBool("open", true);
        }
    }
}
