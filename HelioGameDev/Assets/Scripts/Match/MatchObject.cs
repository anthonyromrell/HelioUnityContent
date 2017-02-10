using System.Collections.Generic;
using UnityEngine;
using System;

public class MatchObject : MonoBehaviour
{
    public static Action SendWinner;
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

    // Update is called once per frame
    void AddToMatch(int _i, PlayerTurn.Players _s)
    {
        DragDot.UpdateScore -= AddToMatch;

        if (_s == PlayerTurn.Players.RED)
        {
            RedMatches.Add(_i);
            Win(RedMatches.Count);

        }
        else
        {
            GreenMatches.Add(_i);
            Win(GreenMatches.Count);
        }
    }

    void Win(int num)
    {
        if (num == 3)
            SendWinner();
    }
}
