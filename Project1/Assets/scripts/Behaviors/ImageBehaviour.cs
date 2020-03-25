using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    public FloatData dataObj;

    private void Start()
    {
        imageObj = GetComponent<Image>();
    }

    private void Update()
    {
        imageObj.fillAmount = dataObj.value;
    }
}