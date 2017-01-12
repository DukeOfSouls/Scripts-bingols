using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BingoScript : MonoBehaviour 
{
	List<int> numberList = new List<int>();

	int pressedHash = Animator.StringToHash("pressed");
	int activeHash = Animator.StringToHash("active");

	private GameObject[] Balls;
	private GameObject currentBall;
	private int index2;
	private int lastIndex2 = -1;
	private bool loop;
	public GameObject B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13, B14, B15;

	public DetectScript DS;
	public DetectScript2 DS2;

	public Animator Shaker;
	public Animator smoke;
	public TextMesh Number;
	public MeshRenderer NumberMesh;
	public Transform background;
	public SpriteRenderer smokeSprite;
	public SpriteRenderer bolSprite;

	private int randomNumber;
	public int nextNumber;
	public int numberCount;
	private int index;
	public int bingoCounter;

	public bool on;
	private bool spin;

	void  Start ()
	{
		Balls = GameObject.FindGameObjectsWithTag("balls");
		index2 = Random.Range (0, Balls.Length);
		currentBall = Balls[index2];
		lastIndex2 = index2;

		NumberMesh.enabled = false;
		spin = false;
		on = true;

		for (int i = 1; i < 76; i++)
		{
			numberList.Add(i);
		}

		B1.SetActive(false);
		B2.SetActive(false);
		B3.SetActive(false);
		B4.SetActive(false);
		B5.SetActive(false);
		B6.SetActive(false);
		B7.SetActive(false);
		B8.SetActive(false);
		B9.SetActive(false);
		B10.SetActive(false);
		B11.SetActive(false);
		B12.SetActive(false);
		B13.SetActive(false);
		B14.SetActive(false);
		B15.SetActive(false);
	}

	void Update ()
	{
		if(loop == true)
		{
			Invoke ("Ball", 0f);
			loop = false;

		}

		Number.text = "" + nextNumber;

		if(spin == true) background.transform.Rotate(new Vector3(0f, 0f, -1f));

		if(on == true)
		{
			Shaker.SetTrigger (pressedHash);
			spin = true;
			on = false;
			Invoke ("Spin", 1.8f);
		}
	}

	void Spin ()
	{
		smokeSprite.enabled = true;
		smoke.SetBool (activeHash, true);

		Invoke ("Reset", 2f);
		Invoke ("Smoke", 1f);
		Invoke ("Spawn", 0.5f);

		randomNumber = Random.Range (0, numberList.Count);
		
		nextNumber = numberList [randomNumber];

		
		numberList.RemoveAt( randomNumber );

		numberCount++;

		DS.Bingo();
		DS2.Bingo();

		
		spin = false;
	
	}

	void Reset ()
	{
		smokeSprite.enabled = true;
		smoke.SetBool (activeHash, true);
		Invoke ("Reset2", 1f);
		Invoke ("Spawn2", 0.5f);

	}

	void Reset2 ()
	{

		smokeSprite.enabled = false;
		smoke.SetBool (activeHash, false);
		on = true;
	}

	void Smoke ()
	{
		smokeSprite.enabled = false;
		smoke.SetBool (activeHash, false);
	}

	void Spawn ()
	{
		loop = true;
	}

	void Spawn2 ()
	{
		B1.SetActive(false);
		B2.SetActive(false);
		B3.SetActive(false);
		B4.SetActive(false);
		B5.SetActive(false);
		B6.SetActive(false);
		B7.SetActive(false);
		B8.SetActive(false);
		B9.SetActive(false);
		B10.SetActive(false);
		B11.SetActive(false);
		B12.SetActive(false);
		B13.SetActive(false);
		B14.SetActive(false);
		B15.SetActive(false);
		NumberMesh.enabled = false;
	}
	
	void Ball () 
	{
		do 
		{
			index2 = Random.Range(0, Balls.Length);
		}
		while(index2 == lastIndex2);
		lastIndex2 = index2;
		
		switch (index2)
		{
		case 0:
			B1.SetActive(true);
			B1.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );

			break;
			
		case 1:
			B2.SetActive(true);
			B2.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;
			
		case 2:
			B3.SetActive(true);
			B3.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;
			
		case 3:
			B4.SetActive(true);
			B4.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 4:
			B5.SetActive(true);
			B5.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 5:
			B6.SetActive(true);
			B6.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 6:
			B7.SetActive(true);
			B7.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 7:
			B8.SetActive(true);
			B8.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 8:
			B9.SetActive(true);
			B9.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 9:
			B10.SetActive(true);
			B10.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 10:
			B11.SetActive(true);
			B11.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 11:
			B12.SetActive(true);
			B12.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 12:
			B13.SetActive(true);
			B13.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 13:
			B14.SetActive(true);
			B14.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;

		case 14:
			B15.SetActive(true);
			B15.GetComponent<SpriteRenderer>().material.color = new Color( Random.value, Random.value, Random.value );
			break;	
		}

		NumberMesh.enabled = true;
	}












}