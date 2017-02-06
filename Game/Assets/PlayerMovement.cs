using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	public float jumpForce;

	private Rigidbody2D MyRigidBody;

	// Use this for initialization
	void Start () {
		MyRigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		MyRigidBody.velocity = new Vector2 (moveSpeed, MyRigidBody.velocity.y);

		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) )
		{
			MyRigidBody.velocity = new Vector2 (MyRigidBody.velocity.x, jumpForce);
		}
	}
}
