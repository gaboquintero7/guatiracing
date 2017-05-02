using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roteLlantas : MonoBehaviour {

	// grados que se va a rotar 
	public int angleX;
	public int angleY;

	public void Update () {	
		if (Input.GetKeyDown(KeyCode.W)){
			transform.Rotate (Vector3.right, angleX);
		}

		if (Input.GetKeyDown(KeyCode.S)){
			transform.Rotate (Vector3.left, angleX * (-1));
		}

		if (Input.GetKeyDown(KeyCode.A)){
			transform.Rotate (Vector3.up, angleX);
		}

		if (Input.GetKeyDown(KeyCode.D)){
			transform.Rotate (Vector3.up, angleX * (-1));
		}

	}
}