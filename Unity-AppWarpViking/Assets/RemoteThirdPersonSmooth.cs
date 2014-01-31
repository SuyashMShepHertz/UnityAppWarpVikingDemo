using UnityEngine;
using System.Collections;

public class RemoteThirdPersonSmooth : MonoBehaviour {
	
	private Vector3 position;
	//private Vector3 velocity;
	private Quaternion rotation;
	private bool started = false;
	
	public void SetTransform(Vector3 pos, Vector3 rot, Vector3 vel)
	{
		started = true;
		position = pos;
		//velocity = vel;
		rotation.eulerAngles = rot;
		
		rigidbody.velocity = vel;
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(started == true)
		{
			transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime);
			transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime);
		}
	}
}
