using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnitude : MonoBehaviour
{	
	
	float x;
	float y;
	float z;
	
	float x2;
	float y2;
	float z2;
	
	float x3;
	float y3;
	float z3;
	
	[HideInInspector]public float distance;
	
	[HideInInspector] public float magnitude;
	
	public GameObject punto2;
	
	
	
	

	
	
    // Start is called before the first frame update
    void Start()
    {
	    Prepare();
    }
    
	// Update is called once per frame
	void Update()
	{
		GetMagnitude();
		Normalize();
		GetDistance();
		
		DebugUnityValues();
		
		Vector3 vector = new Vector3(x,y,z);
		
		
		x = gameObject.transform.position.x;
		y = gameObject.transform.position.y;
		z = gameObject.transform.position.z;
		
		x2 = punto2.transform.position.x;
		y2 = punto2.transform.position.y;
		z2 = punto2.transform.position.z;
	}
    
	void GetMagnitude()
	{
		magnitude = Mathf.Sqrt((x*x) + (y*y) + (z*z));
		//Debug.Log("MyMagnitude is" + magnitude);
		
	}
	
	void Normalize()
	{
		Vector3 normalizedVector = new Vector3((x / magnitude) , ( y/ magnitude) , (z / magnitude));
		//Debug.Log("MyNormalized Vector is " + normalizedVector);
	}

	void DebugUnityValues()
	{
		//Debug.Log("Unity Magnitude is " + gameObject.transform.position.magnitude);
		//Debug.Log("Unity Normalized Vector is" + gameObject.transform.position.normalized);
		Debug.Log("Unity distance is" + Vector3.Distance(gameObject.transform.position, punto2.transform.position));
		Debug.Log("Unity Cross is" + Vector3.Cross(gameObject.transform.position, punto2.transform.position));
		
	}
	
	void GetDistance()
	{
		Vector3 vector1 = new Vector3 (x, y, z);
		Vector3 vector2 = new Vector3 (x2, y2, z2);
		
		Vector3 combinedVector = vector1 - vector2;
		x3 = combinedVector.x;
		y3 = combinedVector.y;
		z3 = combinedVector.z;
		
		distance = Mathf.Sqrt((x3 * x3 ) + (y3 * y3 ) + (z3 * z3));
		Debug.Log("MyDistance is" + distance);
	}
   
    
	void Prepare()
	{
		Application.targetFrameRate = 60;
		
		
	}
    
	
	
	
}
