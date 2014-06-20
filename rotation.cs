using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// rotates something on the map
public class NewBehaviourScript : MonoBehaviour {

//1Rotation
	public float rotationSpeed = 3; 
	
	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {
//1Rotation
	transform.Rotate(0,rotationSpeed,0,0);
	}
}
