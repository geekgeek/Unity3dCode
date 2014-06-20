// http://www.youtube.com/watch?v=m0fjrQkaES4
// Du har en fiende. Attach dette skriptet til fienden.
// Huk av boxen "is Trigger" på fienden
// Huk av boxen "is Trigger" på player
// restarter spillet når du kommer borte i fienden

using UnityEngine;
using System.Collections;

public class onTrigger : MonoBehaviour {

	// Use this for initialization //
void OnTriggerEnter(){
		Debug.Log("object entered the trigger");
		Application.LoadLevel (0); 
	}
}
