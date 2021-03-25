using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
	public GameObject Punto2;
	
	Vector3 pos1;
	Vector3 pos2;
	
	Vector3 crossed;
	
	public Vector3 cross (Vector3 a, Vector3 b)
	{
		crossed = new Vector3(0,0,0);
		
		crossed.x = ((a.y * b.z) - (a.z * b.y));
		crossed.y = ((a.z * b.x) - (a.x * b.z));
		crossed.z = ((a.x * b.y) - (a.y * b.x));
			
		return crossed;
	}
	
	void Start()
	{
		
		
	}
	
	void Update()
	{
		UpdateVectors();
		//CrossVector1();
		Debug.Log("My Cross is " + cross(pos1, pos2));
		Debug.Log("Unity Cross is :" + Vector3.Cross(pos1,pos2));

		
		
	}
	
	void CrossVector1()
	{
		float crossX = ((pos1.y * pos2.z) - (pos1.z * pos2.y));
		
		float crossY = ((pos1.z * pos2.x) - (pos1.x * pos2.z));
			
		float crossZ = ((pos1.x * pos2.y) - (pos1.y * pos2.x));
		
		Vector3 CrossedVector = new Vector3(crossX,crossY,crossZ);
		
		Debug.Log("My Cross is" + CrossedVector);
		
		
		
	}
	

	
	void UpdateVectors()
	{
		pos1 = (gameObject.transform.position);
		pos2 = Punto2.transform.position;
		
	}
	
	
}
