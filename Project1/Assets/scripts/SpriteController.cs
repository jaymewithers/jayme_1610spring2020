using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteController : MonoBehaviour
{
    private SpriteRenderer spriteObj;
    public Color spriteColor = Color.red;
    public Color offColor = Color.red;
    
    void Start()
    {
        spriteObj = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        spriteObj.color = spriteColor;
    }

    private void OnDisable()
    {
        spriteObj.color = offColor;
    }
}
