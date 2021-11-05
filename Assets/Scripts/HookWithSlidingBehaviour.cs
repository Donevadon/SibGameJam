using UnityEngine;

public class HookWithSlidingBehaviour : MonoBehaviour, IMovement
{
    [SerializeField] private float wallJumpTime = 0.2f;
    [SerializeField] private float wallSlideSpeed = 0.3f;
    [SerializeField] private float wallDistance = 0.5f;
    [SerializeField] private LayerMask WallForJump;
    private float jumpTime;
    private bool hookingCapability = false;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidBody2D;
    public Rigidbody2D Rigidbody2D
    {
        private get => _rigidBody2D; set
        {
            _rigidBody2D = value;
            _spriteRenderer = value.GetComponent<SpriteRenderer>();
        }
    }


    public void Move(float axisMove)
    {
        //Если персонаж повернут к стене, по Х не двигается (чтобы если отвернулся, то мог отлипнуть от стены)
        bool isLeft = axisMove < 0;
        Flip(isLeft);
        Hook(isLeft ? wallDistance * -1 : wallDistance, axisMove);
    }

    private void Flip(bool isLeft)
    {
        _spriteRenderer.flipX = isLeft;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerController>(out var playerController))
        {
            hookingCapability = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerController>(out var playerController))
        {
            hookingCapability = false;
        }
    }


    public void Stop()
    {
        //TODO: Дописать стоп в цеплянии
    }
}