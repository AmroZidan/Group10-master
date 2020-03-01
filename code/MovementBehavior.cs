using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
	public float moveSpeed = 5f;
	public Rigidbody2D rb;
	Vector2 movement;

	PlayerMovement playerMovement;

	private void Awake() {
		playerMovement = new PlayerMovement();
	}
	// Update is called once per frame
	void Update()
	{
		//Input
		playerMovement.updateMovement(ref movement, Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}

	void FixedUpdate()
	{
		//Moevement 
		rb.MovePosition(playerMovement.updatePosition(rb.position, movement, moveSpeed));
	}
}