using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireContro : MonoBehaviour
{
    private Rigidbody m_tireRigidBody;

    private Vector3 m_inputAxis = Vector3.zero;

    public float tireAcceleration = 1.0f;

    void Start()
    {
        m_tireRigidBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
       
        m_inputAxis.Set(Input.GetAxis("Horizontal")* tireAcceleration, 0, Input.GetAxis("Vertical") * tireAcceleration);
        m_tireRigidBody.AddForce(m_inputAxis);
        
    }
}
