using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{

    public UnityEvent mouseDownEvent,
        mouseOverEvent,
        mouseExitEvent,
        mouseDragEvent,
        mouseUpButtonEvent,
        mouseEnterEvent,
        mouseUpEvent;

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }

    private void OnMouseDrag()
    {
        mouseDragEvent.Invoke();
    }

    private void OnMouseUpAsButton()
    {
        mouseUpButtonEvent.Invoke();
    }

    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }

    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
    }
}
