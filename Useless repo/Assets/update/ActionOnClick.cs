using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionOnClick : MonoBehaviour {
    


    public void OnMouseUp()
    {
        if (this.name == "Start Game")
        {
            SceneManager.LoadScene(1);
        }
        if (this.name == "Credits")
        {
            //SceneManager.LoadScene("MazeGenerator\\demo");
        }
        if (this.name == "Quit")
        {
            Application.Quit();
        }

    }
}
