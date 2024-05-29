using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofPointScript : MonoBehaviour
{
    public bool onRoofPoint;

    // Start is called before the first frame update
    void Start()
    {
        onRoofPoint = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER IN ROOF AREA");
            onRoofPoint = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER OUT OF ROOF AREA");
            onRoofPoint = false;
        }
    }
}
