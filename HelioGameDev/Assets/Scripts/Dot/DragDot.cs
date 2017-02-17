using System;
using UnityEngine;

public class DragDot : MonoBehaviour
{

    public static Action<DragDot> UpdateScore;
    public static Action StartNewTurn;
    public int dotValue = 5;
    public ColorState.Colors dotColor;
    public ColorState.Colors nextPlayer;

    Vector3 offset;
    bool stopDrag;
    bool turn;
    Vector3 newPosition;

    void Start()
    {
        TurnControl.SendCurrentPlayer += SetTurn;
    }

//refactor
    private void SetTurn(string _s, ColorState.Colors obj)
    {
        if (obj == dotColor)
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
                ColorState.currentPlayer = nextPlayer;
                StartNewTurn();
                UpdateScore(this);
            }
        }
    }
  
    void StopDrag()
    {
        GetComponent<SphereCollider>().enabled = false;
    }

}
