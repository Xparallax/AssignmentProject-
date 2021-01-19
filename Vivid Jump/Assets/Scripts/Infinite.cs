using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if the position of the platform on the y axis is smaller than -6
        if(transform.position.x < -15)
        {
            //change the position to 6 on the y axis
            transform.position = new Vector3(0,6,0);
        }
    }
}
