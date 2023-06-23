using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI GuessText;
    int guess;





    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    private void NextGuess()
    {
        //guess = (max + min) / 2; <this version uses math.>
        guess = Random.Range(min, max + 1);
        GuessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        // remove + 1 for math versio
        min = guess + 1;
        NextGuess();
 

    }

    public void OnPressLower()
    {
        // remove - 1 for math version
        max = guess - 1;
        NextGuess();


    }




}
