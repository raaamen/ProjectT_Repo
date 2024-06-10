using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    private PlayerInput plrInput;

    [SerializeField]
    private Transform gunPivotPoint;
    [SerializeField]
    private GameObject playerGun;

    //Input Vectors
    [SerializeField]
    private Vector2 _move;
    [SerializeField]
    private Vector2 _look;
    [SerializeField]
    private bool _shoot;
    [SerializeField]
    private bool _dodgeroll;

    private Rigidbody rb;
    
    [SerializeField]
    private float speed = 0.1f;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        plrInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }


    void OnMove(InputAction.CallbackContext context){
        _move = context.ReadValue<Vector2>();

    }

    void MovePlayer(){
        Vector3 moveDirection = new Vector3(_move.x, 0.0f, _move.y).normalized;
        rb.MovePosition(transform.position += (moveDirection*Time.deltaTime*speed));
    }

    void OnLook(InputAction.CallbackContext context){
        _look = context.ReadValue<Vector2>();
    }

    void OnShoot(InputAction.CallbackContext context){
        _shoot = context.ReadValue<bool>();
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
