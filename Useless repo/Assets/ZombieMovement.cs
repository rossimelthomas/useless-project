using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour {

    const int movementSpeed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            other.SendMessage("die");
        }
        else
        { 
            transform.Rotate(new Vector3(0, Random.Range(0, 1) >= 0.5 ? -50 : 50, 0) * Time.deltaTime);
        } 
    }


}
