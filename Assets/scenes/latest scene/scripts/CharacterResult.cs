using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class CharacterResult : MonoBehaviour {

    public Sprite ch1;
    public Sprite ch2;
    public Sprite ch3;
    public Sprite ch4;
    public Sprite ch5;
    public Sprite ch6;
    public GameObject spawnPointHighest;
    public GameObject spawnPointLowest;

    private int resultChar;

    public int GetTheHighest(int[] allScores, int highestInt)
    {
        highestInt = allScores.Max();
        Debug.Log(highestInt);
        

        if (allScores[0] == highestInt)
        {
            Debug.Log("character one has the most points");
            spawnPointHighest.GetComponent<Image>().sprite = ch1;
            spawnPointHighest.SetActive(true);
            //ch1.transform.position = spawnPointHighest.transform.position;
            //ch1.SetActive(true);
            resultChar = 1;
        }

        if (allScores[1] == highestInt)
        {
            Debug.Log("character two has the most points");
            //ch2.transform.position = spawnPointHighest.transform.position;
            //ch2.SetActive(true);
            spawnPointHighest.GetComponent<Image>().sprite = ch2;
            spawnPointHighest.SetActive(true);
            resultChar = 2;
        }

        if (allScores[2] == highestInt)
        {
            Debug.Log("character three has the most points");
            //ch3.transform.position = spawnPointHighest.transform.position;
            // ch3.SetActive(true);
            spawnPointHighest.GetComponent<Image>().sprite = ch3;
            spawnPointHighest.SetActive(true);
            resultChar = 3;
        }

        if (allScores[3] == highestInt)
        {
            Debug.Log("character four has the most points");
            //ch3.SetActive(true);
            spawnPointHighest.GetComponent<Image>().sprite = ch4;
            spawnPointHighest.SetActive(true);
            resultChar = 4;
        }

        if (allScores[4] == highestInt)
        {
            Debug.Log("character five has the most points");
            //ch3.SetActive(true);
            spawnPointHighest.GetComponent<Image>().sprite = ch5;
            spawnPointHighest.SetActive(true);
            resultChar = 5;
        }

        if (allScores[5] == highestInt)
        {
            Debug.Log("character six has the most points");
            //ch3.SetActive(true);
            spawnPointHighest.GetComponent<Image>().sprite = ch6;
            spawnPointHighest.SetActive(true);
            resultChar = 6; 
        }

        return highestInt;
    }

    public int GetTheLowest(int[] allScores, int lowestInt)
    {
        lowestInt = allScores.Min();
        Debug.Log(lowestInt);


        if (allScores[0] == lowestInt)
        {
            Debug.Log("character one has the most points");
            //ch1.SetActive(true);
            spawnPointLowest.GetComponent<Image>().sprite = ch1;
            spawnPointLowest.SetActive(true);
            resultChar = 1;
        }

        if (allScores[1] == lowestInt)
        {
            Debug.Log("character two has the most points");
            //ch2.SetActive(true);
            spawnPointLowest.GetComponent<Image>().sprite = ch2;
            spawnPointLowest.SetActive(true);
            resultChar = 2;
        }

        if (allScores[2] == lowestInt)
        {
            Debug.Log("character three has the most points");
            //ch3.SetActive(true);
            spawnPointLowest.GetComponent<Image>().sprite = ch3;
            spawnPointLowest.SetActive(true);
            resultChar = 3;
        }

        if (allScores[3] == lowestInt)
        {
            Debug.Log("character four has the most points");
            //ch3.SetActive(true);
            spawnPointLowest.GetComponent<Image>().sprite = ch4;
            spawnPointLowest.SetActive(true);
            resultChar = 4;
        }

        if (allScores[4] == lowestInt)
        {
            Debug.Log("character five has the most points");
            //ch3.SetActive(true);
            spawnPointLowest.GetComponent<Image>().sprite = ch5;
            spawnPointLowest.SetActive(true);
            resultChar = 5;
        }

        if (allScores[5] == lowestInt)
        {
            Debug.Log("character six has the most points");
            //ch3.SetActive(true);
            spawnPointLowest.GetComponent<Image>().sprite = ch6;
            spawnPointLowest.SetActive(true);
            resultChar = 6;
        }

        return lowestInt;
    }
}
