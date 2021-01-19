using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDown : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        //check if the position of the y axis is smaller than -15
        if(transform.position.x < -15)
    {
            //change the position to 15 on the y axis
            transform.position = new Vector3(0,15,0);
        }
    }
}
