using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
public class StatusScript : MonoBehaviour
{
   public static StatusScript status;

   public int energy;
   public int MaxEnergy = 5000;

   public int hunger = 200;
   public int thirst = 100;

   public int happyness = 20;

    DateTime currentDate;
    DateTime oldDate;

   public float energy2;
   public float hunger2;
   public float happyness2;

    public bool depressed = false, starving = false;

    void Awake()
    {
        if (status == null)
        {
            DontDestroyOnLoad(gameObject);
            status = this;
        }

        else if (status != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {

        //Store the current time when it starts
        currentDate = System.DateTime.Now;

        //Grab the old time from the player prefs as a long
        long temp = Convert.ToInt64(PlayerPrefs.GetString("sysString"));

        //Convert the old time from binary to a DataTime variable
        DateTime oldDate = DateTime.FromBinary(temp);
        print("oldDate: " + oldDate);

        //Use the Subtract method and store the result as a timespan variable
        TimeSpan difference = currentDate.Subtract(oldDate);
        print("Difference: " + difference);

        // if energy is bigger than max energy reset it to the max energy.
        if (energy > MaxEnergy)
        {
            energy = MaxEnergy;
        }

        hunger2 = Mathf.Round(1.0f * Convert.ToInt64(difference.TotalHours));
        hunger = PlayerPrefs.GetInt("hunger") - Mathf.RoundToInt(hunger2);

        Debug.Log(energy);


        // calculate the hunger lost between now and last time the player has launched the app. 
        hunger2 = Mathf.Round(2.0f * Convert.ToInt64(difference.TotalHours));
        hunger = PlayerPrefs.GetInt("hunger") - Mathf.RoundToInt(hunger2);

        Debug.Log(hunger);

        // happyness
        happyness2 = Mathf.Round(1.0f * Convert.ToInt64(difference.TotalHours));
        happyness = PlayerPrefs.GetInt("happyness") - Mathf.RoundToInt(happyness2);

        StartCoroutine(Seconds());
        StartCoroutine(Minutes());
        StartCoroutine(Hours());
    }
    void OnApplicationQuit()
    {
        //Savee the current system time as a string in the player prefs class
        PlayerPrefs.SetString("sysString", System.DateTime.Now.ToBinary().ToString());
        PlayerPrefs.SetInt("Energy", energy);
        PlayerPrefs.SetInt("hunger", hunger);
        PlayerPrefs.SetInt("happyness", happyness);
        Debug.Log("Exit Energy: " + energy + " hunger: " + hunger + " happyness: " + happyness);
        print("Saving this date to prefs: " + System.DateTime.Now);
    }
    // Update is called once per frame
    void Update()
    { 

    }

    IEnumerator Seconds()
    {
        yield return new WaitForSeconds(1f);
        StartCoroutine(Seconds());
    }

    IEnumerator Minutes()
    {
        yield return new WaitForSeconds(60f);
        energy--;

        StartCoroutine(Minutes());
    }

    IEnumerator Hours()
    {
        yield return new WaitForSeconds(3600f);
        hunger -= 2;
        happyness--;
        StartCoroutine(Hours());
    }
}