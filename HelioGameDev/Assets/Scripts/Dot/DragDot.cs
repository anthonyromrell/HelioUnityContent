using System;
using UnityEngine;

public class DragDot : MonoBehaviour
{

    public static Action<int, PlayerTurn.Players> UpdateScore;
    public static Action StartNewTurn;
    public int dotValue = 5;
    public PlayerTurn.Players dotName;
    public PlayerTurn.Players nextPlayer;

    Vector3 offset;
    bool stopDrag;
    bool turn;
    Vector3 newPosition;

    void Start()
    {
        TurnControl.SendCurrentPlayer += SetTurn;
    }

    private void SetTurn(PlayerTurn.Players obj)
    {
        print(obj);
        if (obj == dotName)
        {
            turn = true;
        }
        else
        {
            turn = false;
        }
    }

    void OnTriggerEnter()
    {
        stopDrag = true;
    }
    void OnMouseDown()
    {
        print(turn);
        if (turn)
        {
            offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            newPosition = transform.position;
            SnapToThis.SendPosition += SetPosition;
        }
    }

    private void SetPosition(Vector3 _position)
    {
        newPosition = _position;
    }

    void OnMouseDrag()
    {
        if (turn)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
        }
    }

    void OnMouseUp()
    {
        if (turn)
        {
            SnapToThis.SendPosition -= SetPosition;
            transform.position = newPosition;
            if (stopDrag)
            {
                Invoke("StopDrag", 0.1f);
                PlayerTurn.currentPlayer = nextPlayer;
                StartNewTurn();
                UpdateScore(dotValue, dotName);
            }
        }
    }

    void StopDrag()
    {
        GetComponent<SphereCollider>().enabled = false;
    }

}
