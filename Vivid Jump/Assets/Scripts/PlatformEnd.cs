using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformEnd : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) 
    {
            GameManager.singleton.NextLevel(3);
    }
}
