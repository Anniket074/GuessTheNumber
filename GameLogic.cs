using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameLogic : MonoBehaviour
{
    public InputField inputField;
    public Text inputText;
    int x ;
    // Start is called before the first frame update
    void Start()
    {
        inputText.text = "Select a Number between 0 and 20";
        int x = Randomn(0, 21);
    }

    // Update is called once per frame
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
