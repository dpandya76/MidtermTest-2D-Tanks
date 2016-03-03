using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private int _scoreValue;
    private int _livesValue;


    // PUBLIC INSTANCE VARIABLES
    public int tankCount=4;
	public GameObject tank;
	
	

    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {

            this._scoreValue = value;
            if (this._scoreValue >= 10)
            {
                //this._endGame();
            }
            else {
                //this.ScoreLabel.text = "Score:" + this._scoreValue;

            }
        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
                this._GenerateTanks();
            }
            else
            {
                this.LivesLabel.text = "Lives:" + this._livesValue;
            }

        }
    }

    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public PlayerController Player;

    // Use this for initialization
    void Start()
    {
        this._initialize();
        this._GenerateTanks();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 5;
        this.GameOverLabel.enabled = false;
    }


    // generate Clouds
    private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}


    private void _endGame()
    {
       
       
        
            this.GameOverLabel.enabled = true;
            


        
        
        
            

        
        this.Player.gameObject.SetActive(false);
        //this.map.gameObject.SetActive(false);
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        
        //this.HighScoreLabel.enabled = true;
        //this.RestartButton.gameObject.SetActive(true);

    }
}
