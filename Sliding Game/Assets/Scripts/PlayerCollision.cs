using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;
	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.collider.tag=="barrier"){
			movement.enabled=false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
