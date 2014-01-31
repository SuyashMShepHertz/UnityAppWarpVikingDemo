using UnityEngine;
using System.Collections;

public class ServerSmooth : MonoBehaviour {
	
	private Vector3 position;
	private bool started = false;
	
	public void SetTransform(Vector3 pos)
	{
		started = true;
		position = pos;
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(started == true)
		{
			transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime);
		}
	}
}
