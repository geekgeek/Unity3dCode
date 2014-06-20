using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Moves the object two a direction and rotates it also
// 1 = rotation
// 2 = location
public class NewBehaviourScript : MonoBehaviour {

//1Rotation
	public float rotationSpeed = 3; 
//2Forward
	public float forwardSpeed = 3; 
	
	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {
//1Rotation
	transform.Rotate(0,rotationSpeed,0,0);
//2Forward
	transform.Translate(forwardSpeed * Time.deltaTime,0,0); 
	}
}
