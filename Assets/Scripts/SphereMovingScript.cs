using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereMovingScript : MonoBehaviour
{ 
    public GameObject sphere;
    public Text text;
    private bool up = false;
    private bool down = false;
    private float upperBorder = 2.5f;
    private float lowerBorder = 1.6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (text.text.Contains("move up"))
        {
            down = false;
            up = true;
        }

        if (text.text.Contains("move down"))
        {
            up = false;
            down = true;
        }

        Debug.Log(sphere.transform.position.y);

        if (down && sphere.transform.position.y <= lowerBorder)
        {
            down = false;
            up = false;
            sphere.transform.Translate(0, 0, 0);
        }
        else if (up && sphere.transform.position.y >= upperBorder)
        {
            up = false;
            down = false;
            sphere.transform.Translate(0, 0, 0);
        }        

        if (up)
        {
            sphere.transform.Translate(0, 0.005f, 0);

        }
        else if (down)
        {
            sphere.transform.Translate(0, -0.005f, 0);
        }
        else
        {
            sphere.transform.Translate(0, 0, 0);
        } 
    }
}
