using UnityEngine;
using System.Collections;

public class Run : MonoBehaviour {

	public float moveSpeed = 10f;
	//public bool dead = false;

	void Update () {
		if (!Dest.dead) {
			transform.Translate (Vector2.right * moveSpeed * Time.deltaTime);
		}
	}

	/*void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name == "Box 1")
		{
			//Debug.Log("gayab :P");
			dead = true;
		}
	}*/
}
