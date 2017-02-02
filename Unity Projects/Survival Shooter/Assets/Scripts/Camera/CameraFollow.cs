using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f;   // initial value is 5

	Vector3 offset;

	void Start()
	{
		offset = transform.position - target.position;
	}

	// follows a physics update. If we just did update, the timing of following would be different.
	void FixedUpdate()
	{
		Vector3 targetCamPos = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
	}
}
