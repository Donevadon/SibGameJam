using UnityEngine;

public interface ISetBehaviour<T>
{
    bool IsGrounded(LayerMask layerMask);
    T SetBehaviour(T jump);
}
