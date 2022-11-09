using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public string[] theAnswers;
    public bool isCorrect = false;
    // Start is called before the first frame update
    void Start()
    {
        theAnswers = new string[] { "African Gavial", "Akonting" };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeAnswers()
        {
        if (isCorrect)
            {
            Debug.Log("Correct");
            }
        else
            {
            Debug.Log("Wrong");
            }
        }
}
