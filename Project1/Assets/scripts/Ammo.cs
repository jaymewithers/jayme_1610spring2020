using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rigidbodyObj;
    void Start()
    {
        rigidbodyObj = GetComponent<Rigidbody>();
        rigidbodyObj.velocity = transform.forward * speed;
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        Destroy(gameObject);
    }
}