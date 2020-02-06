using UnityEngine;

namespace AtHomePractice
{
    public class UsingInstantiateDestroy : MonoBehaviour
    {
        public void Update()
        {
            if (gameObject.name == "Bullet(Clone)")
            {
                Destroy(gameObject, 5);
            }
        }
    }
}

// unity tutorial - using instantiate. help from unity answers