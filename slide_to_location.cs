using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Goes to a location on the map
public class NewBehaviourScript : MonoBehaviour {

//2Forward
	public float forwardSpeed = 3; 
	
	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {
//2Forward
	transform.Translate(forwardSpeed * Time.deltaTime,0,0); 
	}
}
