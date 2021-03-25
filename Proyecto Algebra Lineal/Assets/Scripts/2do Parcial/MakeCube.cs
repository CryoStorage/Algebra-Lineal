using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCube : MonoBehaviour
{
	Mesh mesh;
	MeshRenderer rend;
	MeshFilter filter;
	public Material mat;
	
	Vector3[] vertex;
	int [] triangles;
	
    // Start is called before the first frame update
    void Start()
    {
	    Build();
    }
    
	void Build()
	{
		filter = gameObject.AddComponent<MeshFilter>();
		rend = gameObject.AddComponent<MeshRenderer>();
		rend.material = mat;		
		GetComponent<MeshFilter>().mesh = mesh;
		vertex = new[]
		{
			new	Vector3(0,0,0), 
			new	Vector3(0,1,0),
			new	Vector3(1,0,0),
			new Vector3(1,1,0),
			
			new Vector3(0,1,1),
			new Vector3(1,1,1),
			new Vector3(0,0,1),
			
			new Vector3(1,0,1)

				
		};
		
		filter.mesh.vertices = vertex;
		
		triangles = new[]
		{
			// Front
			0,1,2,
			1,3,2,
			// Top
			1,4,5,
			5,3,1,
			// Left
			0,4,1,
			0,6,4,
			// Right
			2,3,5,
			5,7,2,
			// Bottom
			2,7,0,
			7,6,0,
			// Back
			7,5,4,
			7,4,6
			
			
		};
		
		filter.mesh.triangles = triangles;
		
		
	}


	
}
