using UnityEngine;

public interface ISetBehaviour<T>
{
    bool IsGrounded(LayerMask layerMask);
    void SetBehaviour(T jump);
}
