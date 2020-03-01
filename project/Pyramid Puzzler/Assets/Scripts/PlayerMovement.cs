using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
	public void updateMovement(ref Vector2 movement, float xAxis, float yAxis) {
		movement.x = xAxis;
		movement.y = yAxis;
	}

	public Vector2 updatePosition(Vector2 position, Vector2 movement, float moveSpeed) {
		return position + movement * moveSpeed * Time.fixedDeltaTime;
	}
}
