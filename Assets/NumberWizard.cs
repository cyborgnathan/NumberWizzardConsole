using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// all if statments should be set up with {}

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {

        //int max = 1000; Moved to class to allow use of the 
        //int min = 1;
        //int guess = 0;


        Debug.Log("Hellow and welcome to the number wizard\r\n"
                  + "Pick a number, any number\n\r" +
                   "as long as it is no highest than: " + max +
                   "\n\rand is no Lower than this: " + min +
                   "\n\rTell me is your number is higher or lower then "+ guess +
                   "\n\rPush it Up for a hgher number, push it Down for a lower,\n\r Push Enter once I have guessed your number correctly!");
        max++;
       

        //print("pick a number\r\n" +   This is here because it is a differnt way of dispaying to the console
        //    "The highest number is 1000\r\n" +
        //    "The Lowest number is 1\r\n"); I comment out code I do not remove it
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))// this activates when the up arrow is pressed down for the fist time
        {
           
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("is it higher or lower than: ");
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))// this activates when the Down arrow is pressed down for the fist time
        {
            
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("is it higher or lower than: ");
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))// this activates when the Enter/Return is pressed down for the fist time
        {
            Debug.Log("We found your number: " + guess);
        }

    }
}
