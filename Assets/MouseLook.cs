using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseLook : MonoBehaviour
{
    	public float mouseSensitivity;
	public float upDownRange = 60f;

	private float vRot = 0;

	void Update () {

		
			float rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensitivity;
			transform.Rotate (0, rotLeftRight, 0,Space.Self);
	
			vRot -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
			vRot = Mathf.Clamp (vRot, -upDownRange, upDownRange);
			Camera.main.transform.localRotation = Quaternion.Euler (vRot, 0, 0);
		
	}
}