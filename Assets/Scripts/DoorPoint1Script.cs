using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPoint1Script : MonoBehaviour
{
    public bool onDoor1Point;

    // Start is called before the first frame update
    void Start()
    {
        onDoor1Point = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER IN DOOR 1 AREA");
            onDoor1Point = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER OUT OF DOOR 1 AREA");
            onDoor1Point = false;
        }
    }
}
