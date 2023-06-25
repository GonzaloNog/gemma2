using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public GameObject collision;
    public int NumberOfJumps = 2;
    private int _jumpCounter = 0;
    private Rigidbody _rigidbody;
    public float JumpSpeed;
    private bool _jump;
    public bool _isGrounded = false;
    float distToGround;


    // Start is called before the first frame update
    void Start()
    {
        distToGround = GetComponent<Collider>().bounds.extents.y;
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_jump = false)
        {
            _jumpCounter = 0;
        }
        
        if (CanJump())
        {
            _jump = true;
            Jump();
        }
            
    }

    bool CanJump()
    {

        return Input.GetKeyDown(KeyCode.Space) ;
    }

    

    void Jump()
    {
        if (_jump && (_isGrounded || _jumpCounter < NumberOfJumps))
        {
            _jumpCounter++;
            _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, JumpSpeed, _rigidbody.velocity.z);
        }
        
       
    }


  
    private void OnCollisionEnter(Collision collider)
    {
        print("hey");
        _jumpCounter = 0;
        _jump = true;

    }

}
