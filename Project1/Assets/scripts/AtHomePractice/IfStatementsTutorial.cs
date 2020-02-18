using UnityEngine;

namespace AtHomePractice
{
    public class IfStatementsTutorial : MonoBehaviour
    {
        public float hotChocolateTemperature = 85.0f;
        public float hotLimitTemperature = 70.0f;
        public float coldLimitTemperature = 40.0f;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                TemperatureTest();

            hotChocolateTemperature -= Time.deltaTime * 5f;
        }

        void TemperatureTest()
        {
            if (hotChocolateTemperature > hotLimitTemperature)
            {
                print("This hot chocolate is TOO hot!");
            }
            else if (hotChocolateTemperature < coldLimitTemperature)
            {
                print("This hot chocolate is too cold. It's like chocolate milk.");
            }
            else
            {
                print("This hot chocolate is just right.");
            }
        }
    }
}

// unity tutorial - if statements