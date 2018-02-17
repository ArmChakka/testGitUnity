using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {

	float rotationX;
	float rotationY;
	float rotationZ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rotationX += Time.deltaTime * 100;
		rotationY += Time.deltaTime * 400;
		rotationZ += Time.deltaTime * 250;
		transform.rotation = Quaternion.Euler (rotationX, rotationY, 0);
	}
}
