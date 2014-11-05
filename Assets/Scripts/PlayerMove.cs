using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

	public float speed = new float();
	public float boost = new float();
	public Slider slider;

	private Vector2 movement = new Vector2();
	private Vector2 movementY = new Vector2();

	private Vector2 speedval = new Vector2();

	// Use this for initialization
	void Start () {
		speedval.x = speed;
	}
	
	// Update is called once per frame
	void Update () {
		int inputX = 0;
		int inputY = 0;
	
		if (Input.GetKey ("up") || Input.GetKey("space")){
			inputY = 1;
			slider.value -= .007f;
			movement.y = rigidbody2D.velocity.y + boost;
		}
		else {
			movement.y = rigidbody2D.velocity.y - 0.1f;
		}
		if (Input.GetKey ("left")){
			inputX = -1;
			slider.value -= .001f;
		}
		if (Input.GetKey ("right")){
			inputX = 1;
			slider.value -= .001f;
		}

		movement.x = (speedval.x * inputX);

		if (rigidbody2D.velocity.y > -5){ 
			movement.y = -5; 
		}
	}

	void FixedUpdate () {
		//rigidbody2D.velocity = movementX;

	https://www.dropbox.com/s/4dpqe5p6sc68bft/Screenshot%202014-09-24%2021.43.25.png?dl=0
			rigidbody2D.velocity = movement;
	}
	void OnGUI() {
		GUI.Label(new Rect(10, 10, 100, 20), movement.y.ToString());
	}
}
