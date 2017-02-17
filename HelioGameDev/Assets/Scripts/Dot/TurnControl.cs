using System;
using UnityEngine;

public class TurnControl : MonoBehaviour
{

    public static Action<string, ColorState.Colors> SendCurrentPlayer;
    void Start()
    {
        SendCurrentPlayer($"The current player is {ColorState.currentPlayer}.",
                                ColorState.currentPlayer);
    }
    void OnEnable()
    {
        DragDot.StartNewTurn += Start;
    }

}
