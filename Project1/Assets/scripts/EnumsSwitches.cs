using System;
using UnityEngine;
using UnityEngine.Events;

public class EnumsSwitches : MonoBehaviour
{
    public UnityEvent idleEvent, walkEvent, runEvent, jumpEvent;
    public UnityEvent startingEvent, playingEvent, inStoreEvent, pausingEvent, endingEvent;
    
    public enum GameStates
    {
        Starting, 
        Playing,
        InStore,
        Pausing,
        Ending,
    }

    public GameStates currentGameStates;

    public enum PlayerStates
    {
        Idle,
        Walk,
        Run,
        Jump
    }

    public PlayerStates currentPlayerStates;

    public void ChangeStateToPlaying ()
    {
        currentGameStates = GameStates.Playing;
    }
    public void ChangeStateToPausing ()
    {
        currentGameStates = GameStates.Pausing;
    }
    public void ChangeStateToInStore ()
    {
        currentGameStates = GameStates.InStore;
    }

    void Update()
    {
        switch (currentPlayerStates)
        {
            case PlayerStates.Idle:
                idleEvent.Invoke();
                break;
            case PlayerStates.Walk:
                walkEvent.Invoke();
                break;
            case PlayerStates.Run:
                runEvent.Invoke();
                break;
            case PlayerStates.Jump:
                jumpEvent.Invoke();
                break;
            default:
                print("I am any.");
                break;
        }

        switch (currentGameStates)
        {
            case GameStates.Starting:
                startingEvent.Invoke();
                break;
            case GameStates.Playing:
                playingEvent.Invoke();
                break;
            case GameStates.InStore:
                inStoreEvent.Invoke();
                break;
            case GameStates.Pausing:
                pausingEvent.Invoke();
                break;
            case GameStates.Ending:
                endingEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
