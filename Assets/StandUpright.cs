using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandUpright : MonoBehaviour {
    public GameObject planetYouStandOn;
	
	void FixedUpdate () {
        StandUp();
	}

    private void StandUp()
    {
        //Vector3 direction = planetYouStandOn.transform.position - transform.position;
        //Quaternion toRotation = Quaternion.FromToRotation(-transform.up, direction);
        //transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, 1 * Time.time);

        transform.LookAt(planetYouStandOn.transform.position);
        transform.Rotate(new Vector3(-1.0f, 0, 0), 90);
    }
}
