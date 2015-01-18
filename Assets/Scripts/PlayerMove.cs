using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

	public float speed = new float();
	public float boost = new float();
	public float gravity;
	public bool canMove;
	public Slider energyMeter;


	private Vector2 movement = new Vector2();
	private Vector2 movementY = new Vector2();

	private Vector2 speedval = new Vector2();

	// Use this for initialization
	void Start () {
		canMove = true;
		speedval.x = speed;
	}
	
	// Update is called once per frame
	void Update () {
		int inputX = 0;
		int inputY = 0;
	
		if(canMove){
			if (Input.GetKey ("up") || Input.GetKey("space")){
				inputY = 1;
				energyMeter.value -= .007f;
				movement.y = rigidbody2D.velocity.y + boost;
			}
			else {
				movement.y = rigidbody2D.velocity.y - gravity;
			}
			if (Input.GetKey ("left")){
				inputX = -1;
				energyMeter.value -= .001f;
			}
			if (Input.GetKey ("right")){
				inputX = 1;
				energyMeter.value -= .001f;
			}

			movement.x = (speedval.x * inputX);
		}

		if (rigidbody2D.velocity.y > -5){ 
			movement.y = -5; 
		}
	}

	void FixedUpdate () {
		//rigidbody2D.velocity = movementX;

			rigidbody2D.velocity = movement;
	}
}
