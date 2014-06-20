//http://www.youtube.com/watch?v=DgpHOTuUJ58
// do something with the object when you click on it with mouseclick
// attach to the object you want to click on
// adds pushing force to the object. Must contain rigid body.

using UnityEngine;
using System.Collections;

public class mouseClick : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown(){
		rigidbody.AddForce(-transform.forward * 500);
		rigidbody.useGravity = true;
		Debug.Log("clicked on it");
	}
}
