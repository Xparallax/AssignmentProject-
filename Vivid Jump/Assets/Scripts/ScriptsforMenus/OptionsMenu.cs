using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

}
