using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed = 5f;
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
	}
}
