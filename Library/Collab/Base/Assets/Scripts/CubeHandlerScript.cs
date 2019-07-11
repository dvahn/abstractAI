using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeHandlerScript : MonoBehaviour {

    public Text text;
    public GameObject cube;
    public GameObject capsule;
    public GameObject cylinder;
    public GameObject sphere;
    private GameObject selectedPrimitive;
    private Color currentColor;
    private Vector3 movementValue;
    private Vector3 currentPosition;
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
        selectedPrimitive = cube;
        sphere.transform.localScale = new Vector3(0, 0, 0);
        capsule.transform.localScale = new Vector3(0, 0, 0);
        cylinder.transform.localScale = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        //Ray rechts
        ray1 = new Ray(new Vector3(550.6f, 0f, -300f), new Vector3(0, 0, 500f));
        //Ray links
        ray2 = new Ray(new Vector3(250.6f, 0f, -300f), new Vector3(0, 0, 500f));
        //Ray oben
        ray3 = new Ray(new Vector3(250.6f, 0, -300f), new Vector3(500f, 0, 0));
        //Ray unten
        ray4 = new Ray(new Vector3(550.6f, 0, -300f), new Vector3(500f, 0, 0));
        Debug.DrawRay(ray1.origin, ray1.direction * 1000, Color.green, 10, false);
        Debug.DrawRay(ray2.origin, ray2.direction * 1000, Color.blue, 10, false);
        Debug.DrawRay(ray3.origin, ray2.direction * 1000, Color.yellow, 10, false);
        Debug.DrawRay(ray4.origin, ray2.direction * 1000, Color.red, 10, false);
        ConstantMover(movementValue, optionValue);
        ChangeColor();
        MoveHandler();
        SelectPrimitive();

    }

    void SelectPrimitive()
    {
        if(text.text.Contains("geometry one"))
        {
            selectedPrimitive.transform.localScale = new Vector3(0,0,0);
            currentPosition = selectedPrimitive.transform.position;
            selectedPrimitive = cube;
            selectedPrimitive.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            selectedPrimitive.transform.position = currentPosition;
            selectedPrimitive.GetComponent<Renderer>().material.color = currentColor;
        }
        else if (text.text.Contains("geometry three"))
        {
            selectedPrimitive.transform.localScale = new Vector3(0, 0, 0);
            currentPosition = selectedPrimitive.transform.position;
            selectedPrimitive = sphere;
            selectedPrimitive.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            selectedPrimitive.transform.position = currentPosition;
            selectedPrimitive.GetComponent<Renderer>().material.color = currentColor;
        }
        else if (text.text.Contains("geometry five"))
        {
            selectedPrimitive.transform.localScale = new Vector3(0, 0, 0);
            currentPosition = selectedPrimitive.transform.position;
            selectedPrimitive = capsule;
            selectedPrimitive.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            selectedPrimitive.transform.position = currentPosition;
            selectedPrimitive.GetComponent<Renderer>().material.color = currentColor;
        }
        else if (text.text.Contains("geometry six"))
        {
            Debug.Log("Gehe hier rein");
            selectedPrimitive.transform.localScale = new Vector3(0, 0, 0);
            currentPosition = selectedPrimitive.transform.position;
            selectedPrimitive = cylinder;
            selectedPrimitive.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            selectedPrimitive.transform.position = currentPosition;
            selectedPrimitive.GetComponent<Renderer>().material.color = currentColor;
        }
    }

    void MoveHandler()
    {
        if (text.text.Contains("move right"))
        {
            if (Physics.Raycast(ray1, out hit1, 1000))
            {
                if (hit1.transform.name == this.transform.name)
                {
                    Debug.Log("Not moving");
                    selectedPrimitive.transform.Rotate(0, 0, 0);
                    movementValue = new Vector3(0, 0, 0);
                    optionValue = "translate";
                }
            }
            else
            {
                Debug.Log("Moving right");
                selectedPrimitive.transform.Rotate(0, 0, 0);
                movementValue = new Vector3(0.001f, 0, 0);
                optionValue = "translate";
            }
        }
        if (text.text.Contains("move up"))
        {
            if (Physics.Raycast(ray2, out hit1, 1000))
            {
                if (hit1.transform.name == this.transform.name)
                {
                    Debug.Log("Not moving");
                    selectedPrimitive.transform.Rotate(0, 0, 0);
                    movementValue =new Vector3(0, 0, 0);
                    optionValue = "translate";
                }
            }
            else 
            {
                Debug.Log("Moving up");
                selectedPrimitive.transform.Rotate(0, 0, 0);
                movementValue = new Vector3(0, 0, 0.001f);
                optionValue = "translate";
            }
        }
        if (text.text.Contains("move left"))
        {
            if (Physics.Raycast(ray3, out hit1, 1000))
            {
                if (hit1.transform.name == this.transform.name)
                {
                    Debug.Log("Not moving");
                    selectedPrimitive.transform.Rotate(0, 0, 0);
                    movementValue = new Vector3(0, 0, 0);
                    optionValue = "translate";
                }
            }
            else
            {
                Debug.Log("Moving left");
                selectedPrimitive.transform.Rotate(0, 0, 0);
                movementValue = new Vector3(-0.001f, 0, 0);
                optionValue = "translate";
            }
        }
        if (text.text.Contains("move down"))
        {
            if (Physics.Raycast(ray4, out hit1, 1000))
            {
                if (hit1.transform.name == this.transform.name)
                {
                    Debug.Log("Not moving");
                    selectedPrimitive.transform.Rotate(0, 0, 0);
                    movementValue = new Vector3(0, 0, 0);
                    optionValue = "translate";
                }
            }
            else
            {
                Debug.Log("Moving down");
                selectedPrimitive.transform.Rotate(0, 0, 0);
                movementValue = new Vector3(0, 0, -0.001f);
                optionValue = "translate";
            }
        }
        if (text.text.Contains("stop"))
        {
            movementValue = new Vector3(0, 0, 0);
            optionValue = "translate";
        }
        if (text.text.Contains("rotate"))
        {
            if(selectedPrimitive == cube)
            {
                selectedPrimitive.transform.Rotate(0, 0, 0);
                movementValue = new Vector3(0, 50 * Time.deltaTime, 0);
                optionValue = "rotate";
            }
            else if(selectedPrimitive == cylinder || selectedPrimitive == capsule)  
            {
                selectedPrimitive.transform.Rotate(0, 0, 0);
                movementValue = new Vector3(50 * Time.deltaTime, 0, 0);
                optionValue = "rotate";
            }
        }

    }
    void ChangeColor()
    {
        if (text.text.Contains("red"))
        {
            currentColor = Color.red;
            selectedPrimitive.GetComponent<Renderer>().material.color = currentColor;
        }
        if (text.text.Contains("blue"))
        {
            currentColor = Color.blue;
            selectedPrimitive.GetComponent<Renderer>().material.color = currentColor;
        }
        if (text.text.Contains("yellow"))
        {
            currentColor = Color.yellow;
            selectedPrimitive.GetComponent<Renderer>().material.color = currentColor;
        }
        if (text.text.Contains("green"))
        {
            currentColor = Color.green;
            selectedPrimitive.GetComponent<Renderer>().material.color = currentColor;
        }
        if (text.text.Contains("black"))
        {
            currentColor = Color.black;
            selectedPrimitive.GetComponent<Renderer>().material.color = currentColor;
        }
        if (text.text.Contains("white"))
        {
            currentColor = Color.white;
            selectedPrimitive.GetComponent<Renderer>().material.color = currentColor;
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
