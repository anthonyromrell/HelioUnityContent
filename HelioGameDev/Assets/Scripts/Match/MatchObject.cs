using System.Collections.Generic;
using UnityEngine;

public class MatchObject : MonoBehaviour
{

    public List<string> RedMatches;
    public List<string> GreenMatches;

    void OnTriggerEnter()
    {
        DragDot.UpdateScore += AddToMatch;
    }

    void OnTriggerExit()
    {
        DragDot.UpdateScore -= AddToMatch;
    }

    // Update is called once per frame
    void AddToMatch(int _i, string _s)
    {
        DragDot.UpdateScore -= AddToMatch;

        if (_s == "Red")
        {
            RedMatches.Add(_s);
            Win(RedMatches.Count);

        }
        else
        {
            GreenMatches.Add(_s);
            Win(GreenMatches.Count);
        }
    }

    void Win(int num)
    {
        if (num == 3)
            print("Win");
    }
}
