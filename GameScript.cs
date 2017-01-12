using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameScript : MonoBehaviour 
{
	public GameObject backdrop;
	public GameObject loading;
    public GameObject load;

    public Image game, leftArrow, rightArrow;
	public Sprite bingoSP, memorySP, throwSP, rpsSP, leftSP, rightSP;
	public Sprite memoryLocked, throwLocked, rpsLocked;
	private bool bingoON, memoryON, throwON, rpsON;

	void Start () 
	{
		Invoke ("Begin", 0.55f);
		leftArrow.sprite = leftSP;
		rightArrow.sprite = rightSP;
		bingoON = true;
		memoryON = false;
		throwON = false;
		rpsON = false;
	}

	void Begin ()
	{
		game.enabled = true;
		leftArrow.enabled = true;
		rightArrow.enabled = true;
	}

	void Update () 
	{
		if(bingoON == true) game.sprite = bingoSP;
		if(memoryON == true && InfoScript.info.Memory == false) game.sprite = memoryLocked;
        if(memoryON == true && InfoScript.info.Memory == true) game.sprite = memorySP;
        if(throwON == true && InfoScript.info.Throw == false) game.sprite = throwLocked;
        if(throwON == true && InfoScript.info.Throw == true) game.sprite = throwSP;
        if(rpsON == true && InfoScript.info.Rps == false) game.sprite = rpsLocked;
        if(rpsON == true && InfoScript.info.Rps == true) game.sprite = rpsSP;
    }

	public void GameSelect ()
	{
		if(bingoON == true)
		{
			StartCoroutine(LoadingScreenBingoMenu());
		}

		if(memoryON == true && InfoScript.info.Memory == true)
		{
			StartCoroutine(LoadingScreenMemoryMenu());
		}

		if(throwON == true && InfoScript.info.Throw == true)
		{
			StartCoroutine(LoadingScreenThrowMenu());
		}

		if(rpsON == true && InfoScript.info.Rps == true)
		{
			StartCoroutine(LoadingScreenRPSmenu());
		}
	}

	IEnumerator LoadingScreenBingoMenu()
	{
        load.SetActive(false);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(14);
		
		yield return null;
	}

	IEnumerator LoadingScreenMemoryMenu()
	{
        load.SetActive(false);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(15);
		
		
		yield return null;
	}
	
	IEnumerator LoadingScreenThrowMenu()
	{
        load.SetActive(false);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(16);
		
		
		yield return null;
	}

	IEnumerator LoadingScreenRPSmenu()
	{
        load.SetActive(false);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(17);
		
		
		yield return null;
	}

	public void right ()
	{
		if(game.sprite == bingoSP)
		{
			bingoON = false;
			memoryON = true;
			throwON = false;
			rpsON = false;
		}

		if(game.sprite == memorySP || game.sprite == memoryLocked)
		{
			bingoON = false;
			memoryON = false;
			throwON = true;
			rpsON = false;
		}

		if(game.sprite == throwSP || game.sprite == throwLocked)
		{
			bingoON = false;
			memoryON = false;
			throwON = false;
			rpsON = true;
		}

		if(game.sprite == rpsSP || game.sprite == rpsLocked)
		{
			bingoON = true;
			memoryON = false;
			throwON = false;
			rpsON = false;
		}
	}

	public void Left ()
	{
		if(game.sprite == bingoSP)
		{
			bingoON = false;
			memoryON = false;
			throwON = false;
			rpsON = true;
		}
		
		if(game.sprite == rpsSP || game.sprite == rpsLocked)
		{
			bingoON = false;
			memoryON = false;
			throwON = true;
			rpsON = false;
		}
		
		if(game.sprite == throwSP || game.sprite == throwLocked)
		{
			bingoON = false;
			memoryON = true;
			throwON = false;
			rpsON = false;
		}
		
		if(game.sprite == memorySP || game.sprite == memoryLocked)
		{
			bingoON = true;
			memoryON = false;
			throwON = false;
			rpsON = false;
		}
	}

}
