using UnityEngine;
using System.Collections;

public class Slider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.MoveBy(gameObject, iTween.Hash("z", 2, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
