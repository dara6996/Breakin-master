using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
	public float score;
	public int numBricks;
	public int lives;
	public int totalBricks;


	public static GameManagerScript S;

    // Start is called before the first frame update
    void Awake()
    {
    	S = this;
    }

    void Start()
    {
    	numBricks = 0;
    	lives = 3;
    	score = 0;
        DontDestroyOnLoad(this);
    }


    public void AddBrick()
    {
    	numBricks++;
    	if(numBricks >= totalBricks)
    	{
    		//You Win
    		BrickLayerScript.S.LayBricks(5,6);
    	}
    	Debug.Log(numBricks);
    }

    public void DecreaseLives()
    {
    	lives--;
    	if(lives < 0)
    	{
    		//GameOver
    		SceneManager.LoadScene("GameOver");
    	}
    	Debug.Log(lives);
    }

    public void Scorer(float scoreTooAdd)
    {
    	score += scoreTooAdd;
    	Debug.Log("Score : " + score );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToTotalBrick()
    {
    	totalBricks++;
    }
}
