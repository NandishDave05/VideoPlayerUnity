using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public Canvas canvas1;
    
    public bool action1;


    // Start is called before the first frame update
    void Start()
    {
        canvas1.enabled = action1;
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
 
}