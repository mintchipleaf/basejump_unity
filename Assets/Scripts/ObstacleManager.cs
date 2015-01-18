using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstacleManager : MonoBehaviour {

	public bool canMakeObstacles;
	public float unitsBetweenObstacles;
	
	private float lastObstacleY;
	private float screenBottom;
	private List<GameObject> obstacles;

	void Awake () {
		canMakeObstacles = true;
		
		//Pretend the last obstacle was at screen bottom (So first obstacle spawns below it)
		lastObstacleY = Camera.main.ViewportToWorldPoint(new Vector3(0,0,1)).y;
	}

	// Update is called once per frame
	void Update () {
		if(canMakeObstacles)
			RollForObstacle();
		//ObstacleCleanup();
	}

	/// <summary>
	/// Checks if it's time to place an obstacle
	/// </summary>
	void RollForObstacle(){
		screenBottom = Camera.main.ViewportToWorldPoint(new Vector3(0,0,1)).y;
		if(screenBottom < lastObstacleY - unitsBetweenObstacles){
			MakeObstacle();
		}
	}

	void MakeObstacle(){
		GameObject obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
		obstacle.transform.position = new Vector3(0, screenBottom - obstacle.renderer.bounds.extents.y - 1, 0);
		lastObstacleY = obstacle.transform.position.y;
	}
}
