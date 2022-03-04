using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charmove : MonoBehaviour
{
	private float speed = 2.0f;
	public GameObject character;

	void Update()
	{

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.back * speed * Time.deltaTime;
		}
		//if (Input.GetKey(KeyCode.D))
		//{
		//	transform.Rotate(Vector3.up * Time.deltaTime);
		//}
		//if (Input.GetKey(KeyCode.A))
		//{
		//	transform.Rotate(Vector3.down * Time.deltaTime);
		//}
	}
}
