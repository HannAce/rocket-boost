using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private InputAction m_thrust;

    private void OnEnable()
    {
        m_thrust.Enable();
    }

    private void Update()
    {
        if (m_thrust.IsPressed())
        {
            Debug.Log("Thrust Pressed");
        }
    }
}
