using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleBehavior : MonoBehaviour
{
    public ParticleSystem particleObj;
    public bool particlePlay = false;

    private void Start()
    {
        particleObj = GetComponent<ParticleSystem>();
        particleObj.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        particleObj.Play();
        particlePlay = true;
    }
}