using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 _offset;

    void Start()
    {
        transform.position = target.position + _offset;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + _offset;
        transform.LookAt(target);


    }
}
