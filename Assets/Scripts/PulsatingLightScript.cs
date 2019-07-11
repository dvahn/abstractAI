using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsatingLightScript : MonoBehaviour
{
    public Light light;
    bool higher = true;
    bool lower = false;

    // Start is called before the first frame update
    void Start()
    {
        light.intensity = 2;    
    }

    // Update is called once per frame
    void Update()
    {
        if(light.intensity <= 1)
        {
            lower = false;
            higher = true;          
        }
        else if(light.intensity >= 3)
        {
            higher = false;
            lower = true;
        }

        if (higher)
        {
            light.intensity += 0.01f;
        }
        else if (lower)
        {
            light.intensity -= 0.01f;
        }       
    }
}
