using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody m_rb;
    [SerializeField] private InputAction m_thrust;
    [SerializeField] private InputAction m_rotation;
    
    [SerializeField] private float m_thrustSpeed;
    [SerializeField] private float m_rotationSpeed;

    private void OnEnable()
    {
        m_thrust.Enable();
        m_rotation.Enable();
    }

    private void FixedUpdate()
    {
        PlayerThrust();
        PlayerRotation();
    }
    
    private void PlayerThrust()
    {
        if (m_thrust.IsPressed())
        {
            m_rb.AddRelativeForce(Vector3.up * m_thrustSpeed * Time.fixedDeltaTime);
        }
    }
    
    private void PlayerRotation()
    {
        if (m_rotation.IsPressed())
        {
            float rotationInput = m_rotation.ReadValue<float>();
            if (rotationInput != 0)
            {
                transform.Rotate(0f, 0f, -rotationInput * m_rotationSpeed * Time.fixedDeltaTime); 
            }
            
            Debug.Log(rotationInput);
        }
    }
}
