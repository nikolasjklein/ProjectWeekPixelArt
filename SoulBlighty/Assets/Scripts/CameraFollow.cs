using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target;
	Camera myCam;

	void Start ()
	{
		myCam = GetComponent<Camera> ();
	}

	void Update ()
	{
		myCam.orthographicSize = (Screen.height / 250f) / 16f;

		if (target)
		{
			transform.position = Vector3.Lerp (transform.position, target.position, 0.07f) + new Vector3(0, 0, -5);
		}
	}
}
