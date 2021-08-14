using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    [SerializeField] private float jumpForce = 10;
    [SerializeField] private float gravityMultiplier = 1;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMultiplier;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            jump(playerRB, jumpForce);
        }
    }

    void jump(Rigidbody playerRigidBody, float jumpForce)
    {
        playerRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
