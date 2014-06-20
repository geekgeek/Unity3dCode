// http://www.youtube.com/watch?v=WG_zoE5sZE4
// Use a slider for rotation speed

using UnityEngine;
using System.Collections;

public class rotationSlider : MonoBehaviour {
//Rotation slider range
	[Range(-10,10)]
	public int rotationSpeed = 3; 
	
	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {
//1Rotation
	transform.Rotate(0,rotationSpeed,0,0);
	}
}