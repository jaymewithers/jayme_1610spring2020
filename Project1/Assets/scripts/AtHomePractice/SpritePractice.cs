using UnityEngine;

namespace AtHomePractice
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class SpritePractice : MonoBehaviour
    {
        private SpriteRenderer spriteObj;
        public Color spriteColor = Color.blue;
        void Start()
        {
            spriteObj = GetComponent<SpriteRenderer>();
            spriteObj.flipY = false;
        }

        private void OnCollisionEnter(Collision other)
        {
            spriteColor = Color.red;
            
            print("Danger.");

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                spriteObj.flipY = true;
            }
        }
    }
}