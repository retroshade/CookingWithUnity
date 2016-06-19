using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour {
	public float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//This moves object left or right based on input
		transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;	
			//GetAxis smooths the stopping of the object; GetAxisRaw immediately stops object upon release;

	}
}
