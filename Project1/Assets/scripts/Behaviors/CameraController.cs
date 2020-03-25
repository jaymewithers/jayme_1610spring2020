using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    private Camera cameraObj;
    void Start()
    {
        cameraObj = GetComponent<Camera>();
        offset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

// some help from unity learn