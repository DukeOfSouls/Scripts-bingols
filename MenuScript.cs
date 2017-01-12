using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour 
{
	public GameObject backdrop;
	public GameObject loading;
    public GameObject load;

	public Transform target1, target2, menu;
	private float speed = 3f;
	public bool active;
	private int counter;

	void Start()
	{
        StartCoroutine(Save());
        active = false;
        load.SetActive(false);
        backdrop.SetActive(false);
		loading.SetActive(false);	
	}

    IEnumerator Save ()
    {
        InfoScript.info.Save();
        Debug.Log("im saving");
        yield return new WaitForSeconds(3f);
        StartCoroutine(Save());
    }
	void FixedUpdate ()
	{
		if(active == true) 
		{
			menu.transform.position = Vector3.MoveTowards(menu.transform.position, target1.transform.position, speed * Time.deltaTime);
			counter++;
		}

		if(active == false) 
		{
			menu.transform.position = Vector3.MoveTowards(menu.transform.position, target2.transform.position, speed * Time.deltaTime);
		}

		if(counter > 100 || active == false)
		{
			active = false;
			counter = 0;
		}
	}

	public void Bars ()
	{
		active = !active;
		if(active == true) Invoke ("Up", 3f);
	}

	public void ThrowgameRetry()
	{
		StartCoroutine(LoadingScreenThrowgameRetry());
	}
	
	IEnumerator LoadingScreenThrowgameRetry()
	{
        load.SetActive(true);
		backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(8);
		
		
		yield return null;
	}

	public void RPSgameRetry()
	{
		StartCoroutine(LoadingScreenRPSgameRetry());
	}
	
	IEnumerator LoadingScreenRPSgameRetry()
	{
        load.SetActive(true);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(9);
		
		
		yield return null;
	}

	public void BingogameRetry()
	{
		StartCoroutine(LoadingScreenBingogameRetry());
	}
	
	IEnumerator LoadingScreenBingogameRetry()
	{
        load.SetActive(true);
        backdrop.SetActive(true);
		loading.SetActive(true);

		AsyncOperation async = Application.LoadLevelAsync(6);

		yield return null;
	}
             

	public void MemorygameRetry()
	{
		StartCoroutine(LoadingScreenMemorygameRetry());
	}
	
	IEnumerator LoadingScreenMemorygameRetry()
	{
        load.SetActive(true);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(7);
		
		
		yield return null;
	}

	public void Sleep()
	{
		StartCoroutine(LoadingScreenSleep());
	}
	
	IEnumerator LoadingScreenSleep()
	{
        load.SetActive(true);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(1);
		
		
		yield return null;
	}

	public void Food()
	{
		StartCoroutine(LoadingScreenFood());
	}
	
	IEnumerator LoadingScreenFood()
	{
        load.SetActive(true);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(2);
		
		
		yield return null;
	}

	public void Home()
	{
		StartCoroutine(LoadingScreenHome());
	}
	
	IEnumerator LoadingScreenHome()
	{
        load.SetActive(true);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(3);
		
		
		yield return null;
	}
	
	public void Game ()
	{
		StartCoroutine(LoadingScreenGame());
	}
	
	IEnumerator LoadingScreenGame()
	{
        load.SetActive(true);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(4);
		
		
		yield return null;
	}

	public void Shop()
	{
		StartCoroutine(LoadingScreenShop());
	}
	
	IEnumerator LoadingScreenShop()
	{
        load.SetActive(true);
        backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(5);

		yield return null;
	}

    public void MiniGames()
    {
        StartCoroutine(LoadingScreenMiniGames());
    }

    IEnumerator LoadingScreenMiniGames()
    {
        load.SetActive(true);
        backdrop.SetActive(true);
        loading.SetActive(true);

        AsyncOperation async = Application.LoadLevelAsync(10);

        yield return null;
    }

    public void FOOD()
    {
        StartCoroutine(LoadingScreenFOOD());
    }

    IEnumerator LoadingScreenFOOD()
    {
        load.SetActive(true);
        backdrop.SetActive(true);
        loading.SetActive(true);

        AsyncOperation async = Application.LoadLevelAsync(11);

        yield return null;
    }

    public void Clothing ()
    {
        StartCoroutine(LoadingScreenClothing());
    }

    IEnumerator LoadingScreenClothing()
    {
        load.SetActive(true);
        backdrop.SetActive(true);
        loading.SetActive(true);

        AsyncOperation async = Application.LoadLevelAsync(12);

        yield return null;
    }

    public void Accessories ()
    {
        StartCoroutine(LoadingScreenAccessories());
    }

    IEnumerator LoadingScreenAccessories()
    {
        load.SetActive(true);
        backdrop.SetActive(true);
        loading.SetActive(true);

        AsyncOperation async = Application.LoadLevelAsync(13);

        yield return null;
    }

    public void BingoMenu()
    {
        StartCoroutine(LoadingScreenBingoMenu());
    }

    IEnumerator LoadingScreenBingoMenu()
    {
        load.SetActive(true);
        backdrop.SetActive(true);
        loading.SetActive(true);

        AsyncOperation async = Application.LoadLevelAsync(15);

        yield return null;
    }

    public void MemoryMenu()
    {
        StartCoroutine(LoadingScreenMemoryMenu());
    }

    IEnumerator LoadingScreenMemoryMenu()
    {
        load.SetActive(true);
        backdrop.SetActive(true);
        loading.SetActive(true);

        AsyncOperation async = Application.LoadLevelAsync(16);

        yield return null;
    }

    public void ThrowMenu()
    {
        StartCoroutine(LoadingScreenThrowMenu());
    }

    IEnumerator LoadingScreenThrowMenu()
    {
        load.SetActive(true);
        backdrop.SetActive(true);
        loading.SetActive(true);

        AsyncOperation async = Application.LoadLevelAsync(17);

        yield return null;
    }

    public void RPSmenu ()
    {
        StartCoroutine(LoadingScreenRPSmenu());
    }

    IEnumerator LoadingScreenRPSmenu()
    {
        load.SetActive(true);
        backdrop.SetActive(true);
        loading.SetActive(true);

        AsyncOperation async = Application.LoadLevelAsync(18);

        yield return null;
    }

    public void Exit()
	{
		Application.Quit();
	}

    void OnApplicationQuit()
    {
        InfoScript.info.Save();
    }

}