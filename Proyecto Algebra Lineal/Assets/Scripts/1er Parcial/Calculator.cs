using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
	public float value1;
	
	public float value2;
	
	public bool add;
	
	public bool subtract;
	
	public bool multiply;
	
	public bool divide;
	
	
	
	
	[HideInInspector]
	public float result;
	
	
    // Start is called before the first frame update
    void Start()
	{
		Application.targetFrameRate = 60;
		Operate();
    }
    
	void Operate()
	{
		if (add == true)
		{
			Add();
			Debug.Log("Addition Result Is:" + result );
		}
		
		if (subtract ==  true)
		{
			Subtract();
			Debug.Log("Subtraction Result Is:" + result );
		}
		
		if (multiply ==  true)
		{
			Multiply();
			Debug.Log("Multiplication Result Is:" + result );
		}
		
		if (divide == true)
		{
			Divide();
			Debug.Log("Division Result Is:" + result );
		}
	
	}
	
	public void Add()
    {
	    result = value1 + value2;
    }
    
	public void Subtract()
	{
		result = value1 - value2;
		
	}
	
	public void Multiply()
	{
		result = value1 * value2;		
	}
	
	public void Divide()
	{
		result = value1 / value2;
	}
    
    
}
