using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour 
{
    public Text Score;
    public int score = 0;
    public int currentStage = 2;
    
    
    public static GameManager singleton;
    // Start is called before the first frame update
    void Awake()
    {
        if(singleton == null) 
        singleton = this;
        //else if(singleton != this);
    }
    
    void Update()
    {
        singleton = this;
    }

    public void NextLevel(int x)
    {
        //if player hits specific trigger player will be transported to the next level 
        SceneManager.LoadScene(x);
        
        //Debug.Log("Next level called");
    }
    public void RestartLevel()
    {
        Debug.Log("Game Over");
        Score.text="Score : 0" ;
        score = 0;
        
    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        Score.text="Score : " + score;
    }
}
