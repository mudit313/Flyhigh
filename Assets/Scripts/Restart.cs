using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	//private int k = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Dest.dead == true) {  
			Application.LoadLevel (0);
			Dest.dead = false;
		}
	}
}
