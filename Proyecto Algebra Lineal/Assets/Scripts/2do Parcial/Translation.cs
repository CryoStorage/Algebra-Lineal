using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation : MonoBehaviour
{
	[SerializeField]private GameObject cube;
	[SerializeField]private Vector3 toMove;
	
	void Update()
	{
		CheckInput();
		
	}
	
	void CheckInput()
	{		
		if (Input.GetKeyDown("r"))
		{
			cube.transform.position = Translate(cube.transform.position, toMove);
		}
		
	}

	void Move()
	{
		cube.transform.position += toMove;
		
	}
	
	Vector3 Translate(Vector3 pos, Vector3 delta)
	{
		float x = (pos.x * 1) + (pos.x * 0) + (pos.x * 0) + (1 * delta.x);
		float y = (pos.y * 0) + (pos.y * 1) + (pos.y * 0) + (1 * delta.y);
		float z = (pos.z * 0) + (pos.z * 0) + (pos.z * 1) + (1 * delta.z);
		
		return new Vector3(x,y,z);
	}
	
}
