using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour 
{
    public Text Best;
    public int best = 0;
    public Text Score;
    public int score = 0;
    public int currentStage = 1;
    
    
    public static GameManager singleton;
    // Start is called before the first frame update
    void Awake()
    {
        if(singleton == null) 
        singleton = this;
        else if(singleton != this){}
        

        best = PlayerPrefs.GetInt("Highscore");
    
    }
    
    void Update() {
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
        Best.text ="Best : "+best;
        score = 0;
        
    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        Score.text="Score : " + score;
        if(score > best)
        {
            best = score;
            Best.text= "Best : " + best;
            //PlayerPrefs.SetInt("Highscore", score);
        }
    }
}
