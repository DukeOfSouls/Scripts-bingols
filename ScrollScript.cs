using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour
{
    [SerializeField] bool moveUp, moveDown;
    public float speed;

	void Start ()
    {
        moveUp = false;
        moveDown = false;
	}
	
	void FixedUpdate ()
    {
        if (moveUp == true) transform.position += Vector3.up * Time.deltaTime * speed;
        if (moveDown == true) transform.position += Vector3.down * Time.deltaTime * speed;
    }

    public void UpArrowDown()
    {
        moveUp = true;
    }

    public void UpArrowUp()
    {
        moveUp = false;
    }

    public void DownArrowDown()
    {
        moveDown = true;
    }

    public void DownArrowUp ()
    {
        moveDown = false;
    }
}
