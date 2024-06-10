using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player")]

    private PlayerInput plrInput;

    [Tooltip("Pivot point of the gun.")]
    [SerializeField]
    private Transform gunPivotPoint;
    [Tooltip("Gun game obj")]
    [SerializeField]
    private GameObject playerGun;

    //Input Vectors
    [SerializeField]
    private Vector2 _move;
    [SerializeField]
    private Vector2 _look;
    
    [SerializeField]
    private bool _dodgeroll;
    
    //Is mouse movement above this threshold?
    [SerializeField]
    private float _threshold = 0.01f;

    private Rigidbody rb;
    
    [SerializeField]
    private float speed = 0.1f;

    [SerializeField]
    private float sensitivity;
    
    private Vector2 pivotAngle;
    [SerializeField]
    private float minY = -89.0f;
    [SerializeField]
    private float maxY = 89.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        plrInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
        RotateGun();
    }


    public void OnMove(InputValue value){
        _move = value.Get<Vector2>();

    }

    void MovePlayer(){
        Vector3 moveDirection = new Vector3(_move.x, 0.0f, _move.y).normalized;
        rb.MovePosition(transform.position += (moveDirection*Time.deltaTime*speed));
    }

    public void OnLook(InputValue value){
        _look = value.Get<Vector2>();

    }

    void RotateGun(){
        if (_look.sqrMagnitude < _threshold){
            return;
        }
        pivotAngle += _look*sensitivity*Time.deltaTime;
        //pivotAngle.x = Mathf.Clamp(pivotAngle.x, minY, maxY);
        if (pivotAngle.y < -360f) pivotAngle.y += 360f;
        if (pivotAngle.y > 360f) pivotAngle.y -= 360f;
        gunPivotPoint.localRotation = Quaternion.Euler(pivotAngle.y, pivotAngle.x, 0f);
    }


    void OnDodgeRoll(InputAction.CallbackContext context){
        _dodgeroll = context.ReadValue<bool>();
    }

    public void SetMovementActive(bool val){
        switch(val){
            case true:
                plrInput.ActivateInput();
                break;
            case false:
                plrInput.DeactivateInput();
                break;
        }
    }

}
