//http://www.youtube.com/watch?v=YvA1O7MYs_w
// Changes the color of the object attached to the script when pressing space

using UnityEngine;
using System.Collections;

public class gameObjectChangeColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Space)) 
		{
			gameObject.renderer.material.color = Color.green;
		}
		
	if (Input.GetKeyUp(KeyCode.Space)) 
		{
			gameObject.renderer.material.color = Color.yellow;
		}
		
		
	}
}
