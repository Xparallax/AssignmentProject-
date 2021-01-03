using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
    //set the player position at -0.04,4.81,1.47
    //-0.04=x,4.81=y,1.47=z
    //Vector3 Vector3(float x,float y,float z)
    }

    // Update is called once per frame
    void Update()
    {
    //Translate(float x,float y,float z)
    //(-1 * fps,0,0) * fps e.g (-1 * 300 fps,0,0)
    //(-1 * sec,0,0) = (-1 * Time.deltaTime,0,0)
    //1m/s
    //-1 * Time.deltaTime = -1m/s (movement to the left)
    //1 * Time.deltaTime = 1m/s (movement to the right)
    //to move the player to the left 1m/s (-1 * Time.deltaTime)
    //speed * Time.deltaTime
    //if we press right arrow move the player to the right
    if (Input.GetKey(KeyCode.RightArrow))
    {
    if (Input.GetKey(KeyCode.UpArrow))
        {
            print("up arrow key is held down");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            print("down arrow key is held down");
}
