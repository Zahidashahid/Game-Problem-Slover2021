using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public void MoveForward(Transform t)
    {
        Debug.Log("t.rotation.z   "+ t.rotation.z);
        if (t.rotation.z == 0f)
        {
            Debug.Log("Upward");
            t.position = t.position + new Vector3(0f, 10f, 0f);
        }
        else if (t.rotation.z == 1f)
        {
            Debug.Log("Downward");
            t.position = t.position + new Vector3(0f, -10f, 0f);
        }
        else if (t.rotation.z == 0.7071068f)
        {
            t.position = t.position + new Vector3(-10f, 0f, 0f);
        }
        else if (t.rotation.z == -0.7071068f)
        {
            t.position = t.position + new Vector3(10f, 0f, 0f);
        }
        
            
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
