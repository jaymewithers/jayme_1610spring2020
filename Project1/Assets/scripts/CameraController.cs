using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{

    private Camera cameraObj;
    void Start()
    {
        cameraObj = GetComponent<Camera>();
        cameraObj.backgroundColor = Color.yellow;
        cameraObj.fieldOfView = 70f;
    }
}
