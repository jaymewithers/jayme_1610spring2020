using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public int intNumber;
    public float floatNumber;
    public string stringNumber;

    public UnityEvent triggeringEnterEvent;
    public UnityEvent triggeringExitEvent;
    public UnityEvent triggeringStayEvent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            triggeringEnterEvent.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody)
        {
            triggeringExitEvent.Invoke();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        triggeringStayEvent.Invoke();
    }
}
