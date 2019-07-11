using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeHandlerScript : MonoBehaviour
{
    public Text text;
    public GameObject abstractGeometry;
    public GameObject[] crystals;
    public Light pointLight;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
        AnimationHandler();
    }

    void ChangeColor()
    {
        if (text.text.Contains("orange"))
        {
            pointLight.color = new Color(1, 0.5361991f, 0.4485294f);

        }
        if (text.text.Contains("rose"))
        {
            pointLight.color = new Color(0.9803922f, 0.6470588f, 0.7333333f);
        }
        if (text.text.Contains("green"))
        {
            pointLight.color = new Color(0.5816431f, 1, 0.4485294f);
        }
        if (text.text.Contains("ocean"))
        {
            pointLight.color = new Color(0.4191176f, 0.7160129f, 1);
        }
    }

    void AnimationHandler()
    {
        if (text.text.Contains("play"))
        {
            Debug.Log("ANIMATION");
            abstractGeometry.GetComponent<Animation>().Play();
        }
        if (text.text.Contains("reverse"))
        {
            Debug.Log("ANIMATION REVERSED");
            abstractGeometry.GetComponent<Animation>().Rewind();

        }
    }
}