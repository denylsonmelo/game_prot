using UnityEngine;

public class InputSystem : MonoBehaviour
{
	// input string caching
	static readonly string HorizontalInput = "Horizontal";
	static readonly string JumpInput = "Jump";
	static readonly string DashInput = "Dash";

	public static float HorizontalRaw()
	{
		//Debug.Log("HorizontalRaw: " + Input.GetAxisRaw(HorizontalInput));
		return Input.GetAxisRaw(HorizontalInput);
	}

	public static bool Jump()
	{
		//Debug.Log("Jump " + Input.GetButtonDown(JumpInput));
		return Input.GetButtonDown(JumpInput);
	}

	public static bool Dash()
	{
		return Input.GetButtonDown(DashInput);
	}

}

