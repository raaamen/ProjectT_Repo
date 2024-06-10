using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPoint2Script : MonoBehaviour
{
    public bool onDoor2Point;

    // Start is called before the first frame update
    void Start()
    {
        onDoor2Point = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER IN DOOR 1 AREA");
            onDoor2Point = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER OUT OF DOOR 1 AREA");
            onDoor2Point = false;
        }
    }
}
