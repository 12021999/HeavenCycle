using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	void Start () {
	
	}	

	public GameObject Camera;
	float speed = 0.1f;
	
	void Movimentation()
	{
		if(Input.GetKey("right"))
		{
			speed += 0.001f;
			transform.position += new Vector3(speed,0,0);
		}
		if(Input.GetKeyUp("right"))
		{
			speed = 0.1f;
		}
		if(Input.GetKey("left"))
		{
			transform.position += new Vector3(speed,0,0);
			//rigidbody2D.velocity = new Vector3(0,0,0);
		}
		if(transform.position.x > 300)
		{
			transform.position = new Vector3(-5,1.4f,0);
		}
	}
	
	void CameraPosition()
	{
		Camera.transform.position = new Vector3(transform.position.x + 1,transform.position.y + 1,Camera.transform.position.z);
	}
	
	void Update () 
	{
		print(speed);
		CameraPosition();
		Movimentation();
	}
}
