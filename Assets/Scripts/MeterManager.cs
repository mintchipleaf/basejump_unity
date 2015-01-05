using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MeterManager : MonoBehaviour {
	
	public Slider slider;

	// Use this for initialization
	void Awake () {
		slider.value = 1;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
