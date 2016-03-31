using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float jetpackForce = 75.0f;
	public Object bullet;
	//private bool dead = false;

	void Update () 
	{
		bool jetpackActive = Input.GetButton("Fire1");

		jetpackActive = jetpackActive && !(Dest.dead);
		
		if (jetpackActive)
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jetpackForce));
		}

		if (Gun.gun) {
			if(Input.GetButtonDown("Fire2"))
			{
				Object bulletx = Instantiate(bullet, new Vector3(transform.position.x,transform.position.y,0f), Quaternion.identity);
			}
		}

		if (transform.position.x - Gun.startx >= 40)
			Gun.gun = false;

		/*if (dead) {
			Destroy(gameObject);
		}*/
	}

	/*void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name == "Box 1")
		{
			dead = true;
		}
	} */
}
