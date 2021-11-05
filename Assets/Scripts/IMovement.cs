using UnityEngine;
public interface IMovement : IRigidbody2DSetter
{
    void Move(float axisMove);
    void Stop();
}
