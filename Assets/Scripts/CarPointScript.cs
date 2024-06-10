using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPointScript : MonoBehaviour
{
    public bool onCarPoint;

    // Start is called before the first frame update
    void Start()
    {
        onCarPoint = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER IN CAR AREA");
            onCarPoint = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER OUT OF CAR AREA");
            onCarPoint = false;
        }
    }
}
