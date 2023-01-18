using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float Force = 20f;
    [SerializeField]
    private float speed = 1.0f;

    private CharacterController _characterController;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {

        _rigidbody = GetComponent<Rigidbody>();
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void  FixedUpdate()
    {
        //Vector3 movement = Vector3.zero;
        //float horInput = Input.GetAxis("Horizontal");
        //float verInput = Input.GetAxis("Vertical");

        //_rigidbody.AddForce(horInput * Force * Time.deltaTime, 0, verInput * Force * Time.deltaTime, ForceMode.VelocityChange);


    }
}
