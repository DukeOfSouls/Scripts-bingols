using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FeedScript : MonoBehaviour 
{
	int pressedHash = Animator.StringToHash("pressed");
	public Animator button;

    public MenuScript menuscript;
	public TextMesh count;
	public Transform spawn;
    public GameObject food, drink;
	public Image foodImage, drinkImage;
	public Sprite foodOnTexture, foodOffTexture, drinkOnTexture, drinkOffTexture;
	[SerializeField] bool foodOn, drinkOn;

	void Start () 
	{
		foodOn = false;
		drinkOn = false;
	}

	void Update () 
	{

        if(menuscript.active == true)
        {
            foodImage.raycastTarget = false;
            drinkImage.raycastTarget = false;
        }

        if (menuscript.active == false)
        {
            foodImage.raycastTarget = true;
            drinkImage.raycastTarget = true;
        }

        if (foodOn == true)
		{
			foodImage.sprite = foodOnTexture;
            count.text = InfoScript.info.foodCount.ToString();
		}

		else
		{
			foodImage.sprite = foodOffTexture;
		}

		if(drinkOn == true)
		{
			drinkImage.sprite = drinkOnTexture;
            count.text = InfoScript.info.drinkCount.ToString();
		}

		else
		{
			drinkImage.sprite = drinkOffTexture;
		}
	}

	public void Button ()
	{
		button.SetTrigger (pressedHash);

		if(foodOn == true && InfoScript.info.foodCount > 0)
		{
			Instantiate(food, spawn.transform.position, Quaternion.Euler(0f, 0f, -90f));
            InfoScript.info.foodCount -= 1;
		}

		if(drinkOn == true && InfoScript.info.drinkCount > 0)
		{
			Instantiate(drink, spawn.transform.position, Quaternion.identity);
            InfoScript.info.drinkCount -= 1;
        }
	}

	public void Food ()
	{
		foodOn = true;
		drinkOn = false;
	}

	public void Drink ()
	{
		drinkOn = true;
		foodOn = false;
	}

}
