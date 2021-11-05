using UnityEngine;

public interface IJump : IRigidbody2DSetter
{
    LayerMask LayerMask { get; }
    void Jump(bool isGrounded);
}