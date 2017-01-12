using UnityEngine;
using System.Collections;

public class BeamScript : MonoBehaviour 
{
	public Transform T1, T2;
	public float speed;
	public bool t1, t2;

	void Start ()
	{
		t1 = false;
		t2 = false;
	}

	void Update () 
	{
		if(transform.position == T1.position)
		{
			t2 = false;
			t1 = true;
		}

		if(t1 == true)
		{
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T2.position, step);
		}

		if(transform.position == T2.position) 
		{
			t1 = false;
			t2 = true;
		}

		if(t2 == true)
		{
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T1.position, step);
		}
	

	}
}
