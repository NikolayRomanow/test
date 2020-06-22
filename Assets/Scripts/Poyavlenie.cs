using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poyavlenie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Target, Victorine, CanvasPizza;// StartButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Target.activeInHierarchy==true)
        {
            CanvasPizza.SetActive(false);
           // StartButton.SetActive(true);
        }
        if (Target.activeInHierarchy == false)
        {
            CanvasPizza.SetActive(true);
            //Victorine.SetActive(false);
        }
    }
}
