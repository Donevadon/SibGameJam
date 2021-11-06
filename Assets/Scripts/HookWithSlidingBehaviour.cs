using UnityEngine;

public class HookWithSlidingBehaviour : MoveBehaviour
{
    [SerializeField] private float wallJumpTime = 0.12f;
    [SerializeField] private float wallSlideSpeed = 0.3f;
    [SerializeField] private float wallDistance = 0.5f;
    [SerializeField] private LayerMask WallForJump;
    private float jumpTime;

    public override void Move(float axisMove)
    {
        base.Move(axisMove);
        bool isLeft = axisMove < 0;
        Hook(isLeft ? wallDistance * -1 : wallDistance, axisMove);
    }

    private void Hook(float distance, float axisMove)
    {
        var WallCheckHit = CreateRaycast(distance);
        var isWallSliding = WallSliding(axisMove, WallCheckHit);
        if (isWallSliding)
        {
            SlidingDown();
        }
    }

    private RaycastHit2D CreateRaycast(float distance) => Physics2D.Raycast(transform.position, new Vector2(distance, 0), wallDistance, WallForJump);

    private bool WallSliding(float axisMove, RaycastHit2D WallCheckHit)
    {
        bool isWallSliding = true;
        if (WallCheckHit && axisMove != 0)
        {
            isWallSliding = true;
            jumpTime = Time.time + wallJumpTime;
        }
        else if (jumpTime < Time.time)
        {
            isWallSliding = false;
        }
        return isWallSliding;
    }

    private void SlidingDown() => Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, Mathf.Clamp(Rigidbody2D.velocity.y, -1 * wallSlideSpeed, float.MaxValue));

}