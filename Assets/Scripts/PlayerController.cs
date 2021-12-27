using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject playerGameobject;
    [SerializeField] private Rigidbody playerRigidBody;
    [SerializeField] private float userForce;
    [SerializeField] private float playerHorizontalInput;
    [SerializeField] private float playerVerticalInput;


    
    // Start is called before the first frame update
    void Start()
    {

        playerRigidBody = playerGameobject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift)){
            playerRigidBody.maxAngularVelocity = 14;
                }
        else{
            playerRigidBody.maxAngularVelocity = 7;
        }
        playerHorizontalInput = Input.GetAxis("Horizontal");
        playerVerticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        playerRigidBody.AddTorque(Vector3.left.normalized * playerHorizontalInput * userForce * Time.deltaTime, ForceMode.Force);
        playerRigidBody.AddTorque(Vector3.back.normalized * playerVerticalInput * userForce * Time.deltaTime, ForceMode.Force);
    }
}
