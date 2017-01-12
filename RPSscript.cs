using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RPSscript : MonoBehaviour 
{
    public WinScript2 WS2;
    public GameObject coins, coins2;
    public GameObject arrows, RetryMenu;
    public Sprite up, down;
    public Image upArrow, downArrow;

	public Transform background;
    public TextMesh result, coinCount, coinCount2;
	public MeshRenderer resultMesh;
	public Transform rockTR, paperTR, scissorsTR, rockTR2, paperTR2, scissorsTR2;
	public Transform rockEND, paperEND, scissorsEND, rock2END, paper2END, scissors2END;
	public Transform RT, PT, ST, RT2, PT2, ST2, target, target2;
	public float speed;
	public float speedEND;
	private bool rock, paper, scissors, rock2, paper2, scissors2;
    private bool invokeRock, invokePaper, invokeScissors;
    private bool moveRock, movePaper, moveScissors;
	private int index;
    private int count, oldCount;

	void Start () 
	{
        count = 1;
        coins2.SetActive(false);
        upArrow.sprite = up;
        downArrow.sprite = down;
		resultMesh.enabled = false;
		rock = false;
		paper = false;
		scissors = false;
        invokeRock = false;
        invokePaper = false;
        invokeScissors = false;
        moveRock = false;
        movePaper = false;
        moveScissors = false;
        

		index = Random.Range(1, 4);
	}

    public void UP ()
    {
        if (count <= 4) count++;
    }

    public void DOWN ()
    {
        if (count >= 2) count--;
    }

	void Switch ()
	{
		switch (index)
		{
		case 1:
			rock2END.transform.position = Vector3.MoveTowards(rock2END.transform.position, target2.position, speedEND * Time.deltaTime);
			rock2 = true;
			break;
			
		case 2:
			paper2END.transform.position = Vector3.MoveTowards(paper2END.transform.position, target2.position, speedEND * Time.deltaTime);
			paper2 = true;
			break;
			
		case 3:
			scissors2END.transform.position = Vector3.MoveTowards(scissors2END.transform.position, target2.position, speedEND * Time.deltaTime);
			scissors2 = true;
			break;
		}
    }

	void FixedUpdate () 
	{
        coinCount.text = count.ToString();

        if(invokeRock == true)
        {
            Debug.Log("banaan");
            Invoke("ROCK", 0.7f);
            invokeRock = false;
        }

        if (invokePaper == true)
        {
            
            Debug.Log("banaan");
            Invoke("PAPER", 0.7f);
            invokePaper = false;
        }

        if (invokeScissors == true)
        {
            
            Debug.Log("banaan");
            Invoke("SCISSORS", 0.7f);
            invokeScissors = false;
        }

        if (rock == true)
		{
			Invoke ("Switch", 0.69f);

			rockTR.transform.position = Vector3.MoveTowards(rockTR.transform.position, RT.position, speed * Time.deltaTime);
			paperTR.transform.position = Vector3.MoveTowards(paperTR.transform.position, PT.position, speed * Time.deltaTime);
			scissorsTR.transform.position = Vector3.MoveTowards(scissorsTR.transform.position, ST.position, speed * Time.deltaTime);
			rockTR2.transform.position = Vector3.MoveTowards(rockTR2.transform.position, RT2.position, speed * Time.deltaTime);
			paperTR2.transform.position = Vector3.MoveTowards(paperTR2.transform.position, PT2.position, speed * Time.deltaTime);
			scissorsTR2.transform.position = Vector3.MoveTowards(scissorsTR2.transform.position, ST2.position, speed * Time.deltaTime);
		}

		if(paper == true)
		{
			Invoke ("Switch", 0.69f);

			rockTR.transform.position = Vector3.MoveTowards(rockTR.transform.position, RT.position, speed * Time.deltaTime);
			paperTR.transform.position = Vector3.MoveTowards(paperTR.transform.position, PT.position, speed * Time.deltaTime);
			scissorsTR.transform.position = Vector3.MoveTowards(scissorsTR.transform.position, ST.position, speed * Time.deltaTime);
			rockTR2.transform.position = Vector3.MoveTowards(rockTR2.transform.position, RT2.position, speed * Time.deltaTime);
			paperTR2.transform.position = Vector3.MoveTowards(paperTR2.transform.position, PT2.position, speed * Time.deltaTime);
			scissorsTR2.transform.position = Vector3.MoveTowards(scissorsTR2.transform.position, ST2.position, speed * Time.deltaTime);
		}

		if(scissors == true)
		{
			Invoke ("Switch", 0.69f);

			rockTR.transform.position = Vector3.MoveTowards(rockTR.transform.position, RT.position, speed * Time.deltaTime);
			paperTR.transform.position = Vector3.MoveTowards(paperTR.transform.position, PT.position, speed * Time.deltaTime);
			scissorsTR.transform.position = Vector3.MoveTowards(scissorsTR.transform.position, ST.position, speed * Time.deltaTime);
			rockTR2.transform.position = Vector3.MoveTowards(rockTR2.transform.position, RT2.position, speed * Time.deltaTime);
			paperTR2.transform.position = Vector3.MoveTowards(paperTR2.transform.position, PT2.position, speed * Time.deltaTime);
			scissorsTR2.transform.position = Vector3.MoveTowards(scissorsTR2.transform.position, ST2.position, speed * Time.deltaTime);
		}

        if(moveRock == true) rockEND.transform.position = Vector3.MoveTowards(rockEND.transform.position, target.position, speedEND * Time.deltaTime);
        if(movePaper == true) paperEND.transform.position = Vector3.MoveTowards(paperEND.transform.position, target.position, speedEND * Time.deltaTime);
        if(moveScissors == true) scissorsEND.transform.position = Vector3.MoveTowards(scissorsEND.transform.position, target.position, speedEND * Time.deltaTime);
    }

	public void Rock ()
	{
        InfoScript.info.coins -= count;
		rock = true;
        invokeRock = true;
        coins.SetActive(false);
        arrows.SetActive(false);
    }

	void ROCK ()
	{
        Debug.Log("rock");

        moveRock = true;

        if(rock == true && rock2 == true) Invoke ("Draw", 0.5f);
		if(rock == true && paper2 == true) Invoke ("Lose", 0.5f);
		if(rock == true && scissors2 == true) Invoke ("Win", 0.5f);
    }

	public void Paper ()
	{
        InfoScript.info.coins -= count;
        paper = true;
        invokePaper = true;
        coins.SetActive(false);
        arrows.SetActive(false);
    }

	void PAPER ()
	{
        Debug.Log("paper");
        movePaper = true;

		if(paper == true && rock2 == true) Invoke ("Win", 0.5f);
		if(paper == true && paper2 == true) Invoke ("Draw", 0.5f);
		if(paper == true && scissors2 == true) Invoke ("Lose", 0.5f);
    }

	public void Scissors ()
	{
        InfoScript.info.coins -= count;
        scissors = true;
        invokeScissors = true;
        coins.SetActive(false);
        arrows.SetActive(false);
    }

	void SCISSORS ()
	{
        Debug.Log("scissors");
        moveScissors = true;

		if(scissors == true && rock2 == true) Invoke ("Lose", 0.5f);
		if(scissors == true && paper2 == true) Invoke ("Win", 0.5f);
		if(scissors == true && scissors2 == true) Invoke ("Draw", 0.5f);
    }

	void Win ()
	{
		result.text = "WIN";
		resultMesh.enabled = true;
		Invoke ("Replay", 1f);
        Invoke ("WIN", 0f);
        count = count * 2;
        coinCount2.text = "+" + count;
    }


	void Lose ()
	{
        result.text = "LOSE";
		resultMesh.enabled = true;
		Invoke ("Replay", 1f);
        oldCount = count;
        coinCount2.text = "-" + oldCount;
        count = 0;
	}

    void Draw ()
	{
        result.text = "DRAW";
		resultMesh.enabled = true;
		Invoke ("Replay", 1f);
        coinCount2.text = "+0";
	}

    void Replay ()
	{
        Debug.Log(count);
		background.transform.position = new Vector3 (1.7f, 2.13f, 2f);
		result.text = "";
        coins2.SetActive(true);
        RetryMenu.SetActive(true);

	}

    void WIN ()
    {
        WS2.enabled = true;
    }

}
