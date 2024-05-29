using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TransitionTriggerScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    Transform pt;

    [SerializeField] GameObject roofTrigger;
    [SerializeField] Transform roofPoint;

    [SerializeField] GameObject carTrigger;
    [SerializeField] Transform carPoint;
    
    CarPointScript cp;
    RoofPointScript rp;
    

    // Start is called before the first frame update
    void Start()
    {
        cp = carTrigger.GetComponent<CarPointScript>();
        rp = roofTrigger.GetComponent<RoofPointScript>();

        //pt = player.transform;
        pt = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (cp.onCarPoint)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("ACTIVATE TRANSITION");
                TransitionPlayerToRoof();
            }
        }

        if (rp.onRoofPoint)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("ACTIVATE TRANSITION");
                TransitionPlayerToCar();
            }
        }

    }

    void TransitionPlayerToRoof()
    {
        pt.position = new Vector3(roofPoint.position.x, roofPoint.position.y, roofPoint.position.z);
    }

    void TransitionPlayerToCar()
    {
        pt.position = new Vector3(carPoint.position.x, carPoint.position.y, carPoint.position.z);
    }
}
