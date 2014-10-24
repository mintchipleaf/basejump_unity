using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public GameObject player;
	public float score;
	Text text;
	float startpos;
	float playerpos;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		score = 0;
		startpos = player.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		playerpos = player.transform.position.y;
		if (playerpos > 0){
			
		}
	
		score = Mathf.Round(startpos - playerpos);
		text.text = "m\n" + score;	
	}
}
