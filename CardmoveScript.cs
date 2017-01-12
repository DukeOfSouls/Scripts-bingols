using UnityEngine;
using System.Collections;

public class CardmoveScript : MonoBehaviour 
{
	Vector3 startPos = new Vector3 (2.77f, -4.87f, 11.68f);
	Vector3 endPos = new Vector3 (2.77f, 1.77f, 11.68f);

	public Transform cardTarget;
	public float speed;
	private bool open = false;

	void Update ()
	{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, cardTarget.position, step);

		if(open == false) cardTarget.transform.position = startPos;
		if(open == true) cardTarget.transform.position = endPos;
	}

	public void Red ()
	{
		open =! open;
	}

	public void Yellow ()
	{
		open =! open;
	}

	public void Green ()
	{
		open =! open;
	}

	public void Blue ()
	{
		open =! open;
	}





}
