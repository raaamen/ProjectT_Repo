using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTransitionScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    Transform pt;

    [SerializeField] GameObject door1Trigger;
    [SerializeField] Transform door1Point;

    [SerializeField] GameObject door2Trigger;
    [SerializeField] Transform door2Point;

    DoorPoint1Script dp1;
    DoorPoint2Script dp2;


    // Start is called before the first frame update
    void Start()
    {
        dp1 = door1Trigger.GetComponent<DoorPoint1Script>();
        dp2 = door2Trigger.GetComponent<DoorPoint2Script>();

        //pt = player.transform;
        pt = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (dp1.onDoor1Point)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("ACTIVATE TRANSITION");
                TransitionPlayerToDoor2();
            }
        }

        if (dp2.onDoor2Point)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("ACTIVATE TRANSITION");
                TransitionPlayerToDoor1();
            }
        }

    }

    void TransitionPlayerToDoor2()
    {
        pt.position = new Vector3(door2Point.position.x, door2Point.position.y, door2Point.position.z);
    }

    void TransitionPlayerToDoor1()
    {
        pt.position = new Vector3(door1Point.position.x, door1Point.position.y, door1Point.position.z);
    }
}
