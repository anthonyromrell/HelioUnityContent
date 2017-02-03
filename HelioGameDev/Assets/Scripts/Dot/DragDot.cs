using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDot : MonoBehaviour
{

    public static Action<int, string> UpdateScore;
    public int dotValue = 5;
    public string dotName;

    Vector3 offset;
    bool stopDrag;
    Vector3 newPosition;

    void OnTriggerEnter()
    {
        stopDrag = true;
    }
    void OnMouseDown()
    {
        offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        newPosition = transform.position;
        SnapToThis.SendPosition += SetPosition;
    }

    private void SetPosition(Vector3 _position)
    {
        newPosition = _position;
    }

    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
    }

    void OnMouseUp()
    {
        SnapToThis.SendPosition -= SetPosition;
        transform.position = newPosition;
        if (stopDrag)
        {
            Invoke("StopDrag", 0.1f);
            UpdateScore(dotValue, dotName);
        }
    }

    void StopDrag()
    {
        GetComponent<SphereCollider>().enabled = false;
    }

}
