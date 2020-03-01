using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerMovementTest
{
	// A Test behaves as an ordinary method
	[Test]
	public void UpdateTest()
	{
		Vector2 movement = new Vector2(0, 0);
		float xAxis = 1;
		float yAxis = 2;
		
		PlayerMovement playerMovement = new PlayerMovement();
		playerMovement.updateMovement(ref movement, xAxis, yAxis);

		// apply what the updateMovement() should do to this test variable
		Vector2 movementTestVar = new Vector2(0, 0);
		movementTestVar.x = xAxis;
		movementTestVar.y = yAxis;

		// assert that the test variable and the variable that used the method are the same
		Assert.AreEqual(movementTestVar, movement);
	}

	[Test]
	public void ApplyMovementTest() 
	{
		Vector2 position = new Vector2(0, 0);
		Vector2 movement = new Vector2(1, 2);
		float moveSpeed = 5f;

		PlayerMovement playerMovement = new PlayerMovement();
		Vector2 newPosition = playerMovement.updatePosition(position, movement, moveSpeed);
		
		// apply what the updatePosition() should to to this test variable
		Vector2 newPositionTestVar = position + movement * moveSpeed * Time.fixedDeltaTime;

		// assert that the test variable and the variable that used the method are the same
		Assert.AreEqual(newPositionTestVar, newPosition);
	}

}
