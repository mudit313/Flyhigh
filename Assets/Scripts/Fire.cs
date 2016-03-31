using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {
	public Transform ply;
	public Transform bird;
	public Object fire;
	private int k = 0;

	// Use this for initialization
	/*void Start () {
	
	}*/
	
	// Update is called once per frame
	void Update () {
		if(Dest.dead == false)
		{
			if (bird.position.x - ply.position.x <= 11 /*&& ply.position.x - transform.position.x >= 0*/ && k == 0) {
				Object firex = Instantiate(fire, new Vector3(bird.transform.position.x,bird.transform.position.y,0f), Quaternion.identity);
				k = 1;
			}
		}
	}
}
