using UnityEngine;
using System.Collections;

public class ButtonMovement : MonoBehaviour {

	private bool rightPressed = false;
	private bool leftPressed = false;
	private bool upPressed = false;
	private bool downPressed = false;

	public GameObject controlledObject;

	public void OnRightButtonPressed()
	{
		rightPressed = true;
	}

	public void OnRightButtonReleased()
	{
		rightPressed = false;
	}

	public void OnLeftButtonPressed()
	{
		leftPressed = true;
	}

	public void OnLeftButtonReleased()
	{
		leftPressed = false;
	}

	public void OnUpButtonPressed()
	{
		upPressed = true;
	}

	public void OnUpButtonReleased()
	{
		upPressed = false;
	}

	public void OnDownButtonPressed()
	{
		downPressed = true;
	}

	public void OnDownButtonReleased()
	{
		downPressed = false;
	}

	void Update()
	{
		if (leftPressed)
		{
			controlledObject.BroadcastMessage ("MoveLeft", SendMessageOptions.DontRequireReceiver);
		}
		if (rightPressed)
		{
			controlledObject.BroadcastMessage ("MoveRight", SendMessageOptions.DontRequireReceiver);
		}
		if (upPressed)
		{
			controlledObject.BroadcastMessage ("MoveUp", SendMessageOptions.DontRequireReceiver);
		}
		if (downPressed)
		{
			controlledObject.BroadcastMessage ("MoveDown", SendMessageOptions.DontRequireReceiver);
		}
	}
}
