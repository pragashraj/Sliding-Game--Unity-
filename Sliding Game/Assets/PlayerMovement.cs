using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	void FixedUpdate () {
		rb.AddForce(-1000*Time.deltaTime,0,0);

		if(Input.GetKey("d")){
			rb.AddForce(0,0,800*Time.deltaTime);
		}
		if(Input.GetKey("a")){
			rb.AddForce(0,0,-800*Time.deltaTime);
		}
	}
}
