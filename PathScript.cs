using UnityEngine;
using System.Collections;

public class PathScript : MonoBehaviour 
{
	public Transform T1, T2, T3, T4, T5, T6, T7, T8, T9, T10;
	public float speed;
	public bool t1, t2, t3, t4, t5, t6, t7, t8, t9, t10;

	void Update() 
	{
		if(transform.position == T1.position) t1 = true;
		if(transform.position == T2.position) t2 = true;
		if(transform.position == T3.position) t3 = true;
		if(transform.position == T4.position) t4 = true;
		if(transform.position == T5.position) t5 = true;
		if(transform.position == T6.position) t6 = true;
		if(transform.position == T7.position) t7 = true;
		if(transform.position == T8.position) t8 = true;
		if(transform.position == T9.position) t9 = true;
		if(transform.position == T10.position) t10 = true;

		if(t1 == true)
		{
			t10 = false;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T2.position, step);
		}

		if(t2 == true)
		{
			t1 = false;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T3.position, step);
		}

		if(t3 == true)
		{
			t2 = false;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T4.position, step);
		}

		if(t4 == true)
		{
			t3 = false;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T5.position, step);
		}

		if(t5 == true)
		{
			t4 = false;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T6.position, step);
		}

		if(t6 == true)
		{
			t5 = false;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T7.position, step);
		}

		if(t7 == true)
		{
			t6 = false;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T8.position, step);
		}

		if(t8 == true)
		{
			t7 = false;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T9.position, step);
		}

		if(t9 == true)
		{
			t8 = false;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T10.position, step);
		}

		if(t10 == true)
		{
			t9 = false;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, T1.position, step);
		}
	}


}
