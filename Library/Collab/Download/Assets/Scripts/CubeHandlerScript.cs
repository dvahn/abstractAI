using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeHandlerScript : MonoBehaviour {

    public Text text;
    public GameObject abstractGeometry;
    private GameObject selectedPrimitive;
    private Vector3 movementValue;
    private string optionValue;
    private Ray ray1;
    private Ray ray2;
    private Ray ray3;
    private Ray ray4;
    private RaycastHit hit1;


    // Use this for initialization
    void Start () {
        movementValue = new Vector3(0, 0, 0.01f);
        optionValue = "";
        
    }
	
	// Update is called once per frame
	void Update () {
        
        ConstantMover(movementValue, optionValue);
        ChangeColor();
        
    }
/*
    void MoveHandler()
    {
        
    }*/
    void ChangeColor()
    {
        if (text.text.Contains("red"))
        {

            selectedPrimitive.GetComponent<Renderer>().material.color = Color.red;
        }
        if (text.text.Contains("blue"))
        {
            selectedPrimitive.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (text.text.Contains("yellow"))
        {
            selectedPrimitive.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (text.text.Contains("green"))
        {
            selectedPrimitive.GetComponent<Renderer>().material.color = Color.green;
        }
        if (text.text.Contains("black"))
        {
            selectedPrimitive.GetComponent<Renderer>().material.color = Color.black;
        }
        if (text.text.Contains("white"))
        {
            selectedPrimitive.GetComponent<Renderer>().material.color = Color.white;
        }
       
        if (text.text.Contains("play"))
        {
          
            Debug.Log("ANIMATION");
            abstractGeometry.GetComponent<Animation>().Play();
            
        }
        if (text.text.Contains("reverse"))
        {

            Debug.Log("ANIMATION");

            abstractGeometry.GetComponent<Animation>().Rewind();


        }

    }
    void ConstantMover(Vector3 value, string option) 
    {
        if(option == "translate")
        {
            Debug.Log("Gehe hier rein");
            selectedPrimitive.transform.Translate(value);
        }
        else if (option == "rotate")
        {
            Debug.Log("hier gehe ich aber rein");
            selectedPrimitive.transform.Rotate(value);
        }
    }
}
