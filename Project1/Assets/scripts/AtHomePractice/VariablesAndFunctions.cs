using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    private int myInt = 7;
    
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    int MultiplyByTwo(int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }
}

// unity tutorial - variables and functions