using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctiins : MonoBehaviour
{
    //Create a variable of type intager
    int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Iam going to run myInt thru my function to multiply it by two
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int MultiplyByTwo(int number)
    {
        //creating a variable to store my results
        int results;
        //multiplying the passed parameter by 2
        results = number * 2;

        //Returning the results
        return results;
    }
}
