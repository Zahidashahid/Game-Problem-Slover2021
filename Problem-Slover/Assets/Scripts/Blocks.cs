using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public void MoveForward(Transform t)
    {
        t.position = t.position + new Vector3(0f, 10f, 0f);
    } 
    public void MoveBack(Transform t)
    {
        t.position = t.position - new Vector3(0f, 10f, 0f);
    }
    public void RightMove(Transform t)
    {
        t.position = t.position + new Vector3(10f, 0f, 0f);
    }
    public void leftMove(Transform t)
    {
        t.position = t.position - new Vector3(10f, 0f, 0f);
    }
    public void TurnLeft(Transform t)
    {
        t.Rotate(Vector3.forward, 90 );
    }
    public void TurnRight(Transform t)
    {
        t.Rotate(Vector3.back, 90 );
    }
    public void LoopFunction()
    {
        for (int i =0; i < 5;i++)
        {
            //Call Function 
        }
    }
}
