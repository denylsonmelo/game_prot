using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(Animator))]
public class PlayerAnimator : MonoBehaviour
{
	private Rigidbody2D _rigidBody;
	private PlayerController _controller;
	private Animator _animator;
	private static readonly int _Move = Animator.StringToHash("walking");
	private static readonly int _JumpState = Animator.StringToHash("JumpState");
	private static readonly int _IsJumping = Animator.StringToHash("IsJumping");
	//private static readonly int WallGrabbing = Animator.StringToHash("WallGrabbing");
	//private static readonly int IsDashing = Animator.StringToHash("IsDashing");

	private void Start()
	{
		_animator = GetComponentInChildren<Animator>();
		_controller = GetComponent<PlayerController>();
		_rigidBody = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		// Idle & Running animation
		_animator.SetFloat(_Move, Mathf.Abs(_rigidBody.linearVelocity.x));

		_animator.SetBool("idle", false);

		// Jump state (handles transitions to falling/jumping)
		float verticalVelocity = _rigidBody.linearVelocity.y;
		_animator.SetFloat(_JumpState, verticalVelocity);

		// Jump animation
		if (!_controller.isGrounded && !_controller.actuallyWallGrabbing)
		{
			_animator.SetBool(_IsJumping, true);
		}
		else
		{
			_animator.SetBool(_IsJumping, false);
		}

		if (!_controller.isGrounded && _controller.actuallyWallGrabbing)
		{
			//_animator.SetBool(WallGrabbing, true);
		}
		else
		{
			//_animator.SetBool(WallGrabbing, false);
		}

		// dash animation
		//_animator.SetBool(IsDashing, _controller.isDashing);
	}
}

