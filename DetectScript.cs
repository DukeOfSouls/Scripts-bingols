using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DetectScript : MonoBehaviour 
{
	public List<GameObject> buttonList = new List<GameObject>();
	List<int> numberList1 = new List<int>();
	List<int> numberList2 = new List<int>();
	List<int> numberList3 = new List<int>();
	List<int> numberList4 = new List<int>();
	List<int> numberList5 = new List<int>();

	public string findName;
	public BingoScript BS;
	public GameObject prefab, coin;
	private int randomNumber;
	public int nextNumber;
	public GameObject bingoCard;
	public bool bingo = true;
	
	void Start ()
	{
		for (int i = 1; i < 16; i++)
		{
			numberList1.Add(i);
		}

		for (int i = 16; i < 31; i++)
		{
			numberList2.Add(i);
		}

		for (int i = 31; i < 46; i++)
		{
			numberList3.Add(i);
		}

		for (int i = 46; i < 61; i++)
		{
			numberList4.Add(i);
		}

		for (int i = 61; i < 75; i++)
		{
			numberList5.Add(i);
		}

		for (int i = 0; i < 5; i++)
		{
			randomNumber = Random.Range (0, numberList1.Count);
			nextNumber = numberList1 [randomNumber];
			numberList1.RemoveAt( randomNumber );
			buttonList[i].GetComponent<TextMesh>().text = nextNumber.ToString();
		}

		for (int i = 5; i < 10; i++)
		{
			randomNumber = Random.Range (0, numberList2.Count);
			nextNumber = numberList2 [randomNumber];
			numberList2.RemoveAt( randomNumber );
			buttonList[i].GetComponent<TextMesh>().text = nextNumber.ToString();
		}

		for (int i = 10; i < 14; i++)
		{
			randomNumber = Random.Range (0, numberList3.Count);
			nextNumber = numberList3 [randomNumber];
			numberList3.RemoveAt( randomNumber );
			buttonList[i].GetComponent<TextMesh>().text = nextNumber.ToString();
		}

		for (int i = 14; i < 19; i++)
		{
			randomNumber = Random.Range (0, numberList4.Count);
			nextNumber = numberList4 [randomNumber];
			numberList4.RemoveAt( randomNumber );
			buttonList[i].GetComponent<TextMesh>().text = nextNumber.ToString();
		}

		for (int i = 19; i < 24; i++)
		{
			randomNumber = Random.Range (0, numberList5.Count);
			nextNumber = numberList5 [randomNumber];
			numberList5.RemoveAt( randomNumber );
			buttonList[i].GetComponent<TextMesh>().text = nextNumber.ToString();
		}


	}
	
	public void Bingo ()
	{ 
		for (int i = 0; i < buttonList.Count ; i++)
		{
			if(buttonList[i].GetComponent<TextMesh>().text == BS.nextNumber.ToString())
			{
				Instantiate(prefab, buttonList[i].transform.position - new Vector3 (0f, 0f, -2.1f), Quaternion.identity);
			}
		}

	}

	
}
