using UnityEngine;
using UnityEngine.Events;

public class EventPractice : MonoBehaviour
{

    public UnityEvent uEventOne;
    
    void Start()
    {
     uEventOne.Invoke();   
    }
}
