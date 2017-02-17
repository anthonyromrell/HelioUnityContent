using System.Collections.Generic;
using UnityEngine;
using System;

public class MatchObject : MonoBehaviour
{
    public static Action<string, ColorState.Colors> SendWinner;
    public List<int> RedMatches;
    public List<int> GreenMatches;

    void OnTriggerEnter()
    {
        DragDot.UpdateScore += AddToMatch;
    }

    void OnTriggerExit()
    {
        DragDot.UpdateScore -= AddToMatch;
    }

    void AddToMatch(DragDot _dot)
    {
        DragDot.UpdateScore -= AddToMatch;

        if (_dot.dotColor == ColorState.Colors.RED)
        {
            ChangeColor(RedMatches, _dot);
        }
        else
        {
            ChangeColor(GreenMatches, _dot);
        }
    }
    
    void ChangeColor (List<int> _list, DragDot _dot)
    {
        _list.Add(_dot.dotValue);
        if (_list.Count == 3){
            ColorState.currentPlayer = ColorState.Colors.NO;
            SendWinner($"{_dot.dotColor} is the winner!", ColorState.Colors.NO);
        }  
    }
}
