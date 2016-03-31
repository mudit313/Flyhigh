using UnityEngine;
using System.Collections;

public class Firemove : MonoBehaviour {

	public float moveSpeedx = 10f;
	public float moveSpeedy = 10f;
	//public bool dead = false;
	
	void Update () {
		if (!Dest.dead) {
			transform.Translate (Vector2.right * moveSpeedx * Time.deltaTime);
			transform.Translate (Vector2.up * moveSpeedy * Time.deltaTime);
		}
	}

	void OnCollisionEnter2D ()
	{
		//if (col.gameObject.name == "New Game Object") {
			moveSpeedy = -moveSpeedy;
		//Debug.Log("Hi");
		//}
	}
}
