using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
	private Transform target;
	[SerializeField]
	private float smoothSpeed = 0.125f;
	public Vector3 offset;
	[Header("Camera bounds")]
	public Vector3 minCamerabounds;
	public Vector3 maxCamerabounds;

	private void Start()
	{
		if (target == null)
		{
			target = GameObject.FindGameObjectWithTag("Player").transform;
		}
	}

	private void FixedUpdate()
	{
		Vector3 desiredPosition = target.localPosition + offset;
		var localPosition = transform.localPosition;
		Vector3 smoothedPosition = Vector3.Lerp(localPosition, desiredPosition, smoothSpeed);
		localPosition = smoothedPosition;

		// clamp camera's position between min and max
		localPosition = new Vector3(
			Mathf.Clamp(localPosition.x, minCamerabounds.x, maxCamerabounds.x),
			Mathf.Clamp(localPosition.y, minCamerabounds.y, maxCamerabounds.y),
			Mathf.Clamp(localPosition.z, minCamerabounds.z, maxCamerabounds.z)
			);
		transform.localPosition = localPosition;
	}

	public void SetTarget(Transform targetToSet)
	{
		target = targetToSet;
	}
}

