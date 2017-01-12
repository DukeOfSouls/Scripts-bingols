using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FoodScript : MonoBehaviour
{
    public GameObject confirm;
    public int meatCount, waterCount;
    public TextMesh meatAmount, waterAmount, buyText;
    private string item;

    void Start ()
    {
        meatCount = 1;
        waterCount = 1;
        InfoScript.info.coins = 50;
    }

    void Update ()
    {
        meatAmount.text = meatCount.ToString();
        waterAmount.text = waterCount.ToString();
    }

    public void Yes ()
    {
        if (item == "meat" && meatCount <= InfoScript.info.coins && InfoScript.info.foodCount <= 100)
        {
             confirm.SetActive(false);
             InfoScript.info.coins -= meatCount;
             InfoScript.info.foodCount += meatCount;
             InfoScript.info.Save();
        }

        else if (item == "meat" && meatCount > InfoScript.info.coins)
        {
            buyText.text = "You don't have\nenough coins.";

        }

        else if (item == "meat" && InfoScript.info.foodCount >= 100)
        {
           buyText.text = "You have too \nmuch food.";
        }

        if (item == "drink" && waterCount <= InfoScript.info.coins && InfoScript.info.drinkCount <= 100)
        {
                confirm.SetActive(false);
                InfoScript.info.coins -= waterCount;
                InfoScript.info.drinkCount += waterCount;
                InfoScript.info.Save();
        }

        else if (item == "drink" && waterCount > InfoScript.info.coins)
        {
            buyText.text = "You don't have\nenough coins.";

        }

        else if (item == "drink" && InfoScript.info.drinkCount >= 100)
        {
            buyText.text = "You have too \nmuch food.";
        }
    }

    public void No ()
    {
        confirm.SetActive(false);
       
    }

    public void IncreaseMeat ()
    {
        if (meatCount <= 99) meatCount++;
    }

    public void DecreaseMeat ()
    {
        if (meatCount >= 2) meatCount--;
    }

    public void IncreaseWater()
    {
        if (waterCount <= 99) waterCount++;
    }

    public void DecreaseWater()
    {
        if (waterCount >= 2) waterCount--;
    }

    public void Food()
    {
        confirm.SetActive(true);
        item = "meat";
        buyText.text = "Do you want to \nbuy this item?";
    }

    public void Drink()
    {
        confirm.SetActive(true);
        item = "drink";
        buyText.text = "Do you want to \nbuy this item?";
    }

}
