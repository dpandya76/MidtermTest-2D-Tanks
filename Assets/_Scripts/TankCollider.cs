using UnityEngine;
using System.Collections;

public class TankCollider : MonoBehaviour {


    public GameController gameController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {

        //if (other.gameObject.CompareTag(""))
        //{
        //    
        //    this.gameController.ScoreValue += 1;
        //    //Debug.Log(" Collision");
        //}

        if (other.gameObject.CompareTag("Enemy"))
        {
            
            this.gameController.LivesValue -= 1;
            Debug.Log("Tank 1Collision");
            
        }
        
        




    }


}
