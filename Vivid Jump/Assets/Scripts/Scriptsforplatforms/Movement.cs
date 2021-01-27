using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * _speed * Time.deltaTime);
            Debug.Log("right arrow key is held down");
        }

    
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * _speed * Time.deltaTime);
            Debug.Log("left arrow key is held down");
            
        }
    }
}


