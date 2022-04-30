using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameLogic : MonoBehaviour
{
    public InputField inputField;
    public Text inputText;
    public int minValue;
    public int maxValue;
    public Button gameButton;
    private bool isGameWon = false;
    int x ;
    void Start()
    {
        ResetGame();
    }

    private void ResetGame()
    {
        if (isGameWon)
        {
            inputText.text = "You Won ! Now Select a Number between " + minValue + " and " + (maxValue - 1);
            isGameWon = false;
        }
        else
        {
            inputText.text = " Select a Number between " + minValue + " and " + (maxValue - 1);
        }
        inputField.text = "";
        int x = Randomn(minValue, maxValue);
        
    }

    
    void Update()
    {
        
    }

    public void OnButtonClick ()
    {
        string userInput = inputField.text;
        if (inputField.text != "")
        {
            int answer = int.Parse(userInput);
            if(answer == x)
            {
                inputText.text = "Correct!";
                // gameButton.interactable = false;
                isGameWon = true;
                ResetGame();
            }
            else if (answer < x)
            {
                inputText.text = "Try Higher!";
            }
            else if (answer > x)
            {
                inputText.text = "Try Lower!";
            }

        }
        else
        {
            inputText.text = "Enter the Number";
        }

    }

    private int Randomn (int min, int max)
    {
        x = Random.Range(min, max);
        return x;
    }
}
