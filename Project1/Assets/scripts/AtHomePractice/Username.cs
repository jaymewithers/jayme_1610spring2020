using UnityEngine;

namespace AtHomePractice
{
    public class Username : MonoBehaviour
    {
        public string firstName;
        public string lastName;
        private string userName;
        public GameObject player;

        private void OnMouseUp()
        {
            print(UserInfo());
            print(userName + " is your username.");
            player.name = userName;
        }

        string UserInfo()
        {
            userName = firstName + lastName + 2000;
            return firstName + " " + lastName + " are you ready to play?";
        }
    }
}

// anthony's github