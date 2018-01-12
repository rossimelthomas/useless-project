using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour {

    /*void Start() { }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000f))
        {
            Debug.Log("top");
            GameObject.Find("Start Game").GetComponent<Renderer>().material.color = Color.green;
        }
    }*/
    
    bool mouseOver = false;

    void OnMouseEnter()
    {
        mouseOver = true;
        if (this.name == "Start Game")
        {
            GetComponent<Transform>().localScale += new Vector3(0.1F, 0.1F, 0);
            GetComponent<Transform>().localPosition = new Vector3(2.9F, 9.84F, 0.19F);
        }
        if (this.name == "Credits")
        {
            GetComponent<Transform>().localScale += new Vector3(0.1F, 0.1F, 0);
            GetComponent<Transform>().localPosition = new Vector3(-1.11F, 7.56F, 0.41F);
        }
        if (this.name == "Quit")
        {
            GetComponent<Transform>().localScale += new Vector3(0.1F, 0.1F, 0);
            GetComponent<Transform>().localPosition = new Vector3(-4.03F, 5.3F, 0.58F);
        }
    }

    void OnMouseExit()
    {
        mouseOver = false;
        if (this.name == "Start Game")
        {
            GetComponent<Transform>().localScale -= new Vector3(0.1F, 0.1F, 0);
            GetComponent<Transform>().localPosition = new Vector3(0.11F, 9.84F, 0.26F);
        }
        if (this.name == "Credits")
        {
            GetComponent<Transform>().localScale -= new Vector3(0.1F, 0.1F, 0);
            GetComponent<Transform>().localPosition = new Vector3(-2.6F, 7.56F, 0.44F);
        }
        if (this.name == "Quit")
        {
            GetComponent<Transform>().localScale -= new Vector3(0.1F, 0.1F, 0);
            GetComponent<Transform>().localPosition = new Vector3(-4.8F, 5.3F, 0.6F);
        }
    }
}
