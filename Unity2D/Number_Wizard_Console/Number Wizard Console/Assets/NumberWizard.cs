using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
        int max = 1000;
        int min = 1;
        int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard, yo");
        Debug.Log("Pick a number, any number");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than "+ guess);
        Debug.Log("Push Up if higher, Push Down if lower, Push Enter if Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = guess;
                NextGuess();
            }

        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = guess;
                NextGuess();
            }

        //Detect when the Enter key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("We got it!");
                StartGame();
            }
    }
    void NextGuess()
    {
                guess = (max + min)/ 2;
                Debug.Log("Is your number is higher or lower than "+ guess+"?");
    }
}
