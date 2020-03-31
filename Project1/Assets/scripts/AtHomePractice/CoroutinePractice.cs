using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace AtHomePractice
{
    public class CoroutinePractice : MonoBehaviour
    {
        public int countdown = 3;
        public float seconds = 1f;
        public IntData numberData;
        private WaitForSeconds waitObj;
        public UnityEvent startRaceEvent, duringRaceEvent, finishRaceEvent, postRaceEvent;
        
        IEnumerator Start()
        {
        waitObj = new WaitForSeconds(seconds);
        startRaceEvent.Invoke();
        while (countdown > 0)
        {
            numberData.value = countdown;
            yield return waitObj;
            duringRaceEvent.Invoke();
            countdown--;
        }
        yield return waitObj;
        finishRaceEvent.Invoke();
        yield return waitObj;
        postRaceEvent.Invoke();
        }
    }
}