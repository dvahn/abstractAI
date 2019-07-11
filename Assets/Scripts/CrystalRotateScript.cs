using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalRotateScript : MonoBehaviour
{
    public GameObject crystal1;
    public GameObject crystal2;
    public GameObject crystal3;
    public GameObject crystal4;
    public GameObject crystal5;
    public GameObject crystal6;
    public GameObject crystal7;
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        crystal1.transform.Rotate(1, 2, 3);
        crystal2.transform.Rotate(3, 2, 1);
        crystal3.transform.Rotate(1, 3, 2);
        crystal4.transform.Rotate(1, 1, 4);
        crystal5.transform.Rotate(3, 1, 1.5f);
        crystal6.transform.Rotate(1, 2, 1.7f);
        crystal7.transform.Rotate(2, 1, 2);
        sphere.transform.Rotate(0, 0.3f, 0);      
    }
}
