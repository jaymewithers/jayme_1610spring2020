using UnityEngine;

namespace AtHomePractice
{
    public class Conversation : MonoBehaviour
    {
        public int intelligence = 5;

        public void Start()
        {
            switch (intelligence)
            {
                case 5:
                    print("Top of the morning to you, good sir.");
                    break;
                case 4:
                    print("Hello! How are you?");
                    break;
                case 3:
                    print("Hey pal. What's up?");
                    break;
                case 2:
                    print("Sup loser.");
                    break;
                case 1:
                    print("Blah bloo ulg blib.");
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;
            }
        }
    }
}

// unity tutorial - switch statements