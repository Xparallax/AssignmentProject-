using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject player; 

    private Vector3 offset;
    
    //use this for inisalization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
