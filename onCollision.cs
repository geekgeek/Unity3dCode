//http://www.youtube.com/watch?v=bh9ArKrPY8w
// attach it to an object with rigidbody
// when object with rigidbody hits another object it displays "collision accured" and changes color to red
using UnityEngine;
using System.Collections;

public class onCollision : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter (Collision collision) {
		Debug.Log("collision accured");
		gameObject.renderer.material.color = Color.red;
	}
	
	
}
