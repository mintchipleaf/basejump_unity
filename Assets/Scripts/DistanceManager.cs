using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DistanceManager : MonoBehaviour {

	public GameObject player;
	public float distance;

	Text text;
	float startpos;
	float playerpos;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text>();
		distance = 0;
		startpos = player.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		playerpos = player.transform.position.y;
		if (playerpos > 0){
			
		}
	
		distance = Mathf.Round(startpos - playerpos);
		text.text = "m\n" + distance;	
	}
}
