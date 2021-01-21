using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour 
{
    public Text Best;
    public int best = 0;
    public Text Score;
    public int score = 0;
    public int currentStage = 0;
    
    public static GameManager singleton;
    // Start is called before the first frame update
    void Awake()
    {
        if(singleton == null) 
        singleton = this;
        else if(singleton != this){}
        //Destroy(gameObject);
    
    }
    
    void Update() {
        singleton = this;
    }

    public void NextLevel()
    {
        currentStage++;
        //FindObjectOfType <BallControl>().ResetBall();
        //FindObjectOfType <Movement>().LoadStage(currentStage);
        Debug.Log("Next level called");
    }
    public void RestartLevel()
    {
        Debug.Log("Game Over");
        Score.text="Score : 0" ;
        Best.text ="Best : "+best;
        score = 0;
        //FindObjectOfType<BallControl>().ResetBall();
        //FindObjectOfType<Movement>().LoadStage(currentStage);
    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        Score.text="Score : " + score;
        if(score > best){
            best = score;
            Best.text= "Best : " + best;
            
        }
    }
}
