using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotationScript : MonoBehaviour
{
    public Transform pivotPoint;
    public float rotateSpeed;
    float pivotAngle;

    // Update is called once per frame
    void Update()
    {
        RotatePivotPointX();
        //RotatePivotPointY();
    }

    void RotatePivotPointX()
    {
        pivotAngle += Input.GetAxis("Mouse X") * rotateSpeed * -Time.deltaTime;
        //pivotAngle = Mathf.Clamp(pivotAngle, 0, 180);
        pivotPoint.localRotation = Quaternion.AngleAxis(pivotAngle, Vector3.down);
    }

    void RotatePivotPointY() 
    {
        pivotAngle += Input.GetAxis("Mouse Y") * rotateSpeed * -Time.deltaTime;
        //pivotAngle = Mathf.Clamp(pivotAngle, -10, 180);
        pivotPoint.localRotation = Quaternion.AngleAxis(pivotAngle, Vector3.right);
    }
}
