using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {

	public float speed = 2.0f;

	public GameObject camera;

	void Start ()
	{
	}

	void Update () {

		if (Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate (0, 3f, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate (0, -3f, 0);
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			transform.position += Vector3.back* speed * Time.deltaTime;
		}
	}
}