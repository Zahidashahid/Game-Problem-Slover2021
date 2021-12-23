using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public void MoveForward(Transform t)
    {
        t.position = t.position + new Vector3(0f, 5f, 0f);
    } 
    public void MoveBack(Transform t)
    {
        t.position = t.position - new Vector3(0f, 5f, 0f);
    }
    public void RightMove(Transform t)
    {
        t.position = t.position + new Vector3(5f, 0f, 0f);
    }
    public void leftMove(Transform t)
    {
        t.position = t.position - new Vector3(5f, 0f, 0f);
    }
}
