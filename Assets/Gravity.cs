using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
    public float gravity;
    public Rigidbody rigidbodyComponent;

	void FixedUpdate () {
        rigidbodyComponent.AddRelativeForce(0, -gravity, 0);
	}
}
