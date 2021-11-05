using UnityEngine;

public class HookWithSlidingBehaviour : MonoBehaviour, IMovement
{
    [SerializeField] private float wallJumpTime = 0.2f;
    [SerializeField] private float wallSlideSpeed = 0.3f;
    [SerializeField] private float wallDistance = 0.5f;
    [SerializeField] private bool isWallSliding = false;
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
        Hook(isLeft, axisMove);
    }

    private void Flip(bool isLeft)
    {
        _spriteRenderer.flipX = isLeft;
    }

    private void Hook(bool isLeft, float axisMove)
    {
        RaycastHit2D WallCheckHit;
        WallCheckHit = CreateRaycast(isLeft);

        if (WallCheckHit && axisMove != 0)
        {
            isWallSliding = true;
            jumpTime = Time.time + wallJumpTime;
        }
        else if (jumpTime < Time.time)
        {
            isWallSliding = false;
        }

        if (isWallSliding)  //Скольжение вниз
        {
            Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, Mathf.Clamp(Rigidbody2D.velocity.y, -1 * wallSlideSpeed, float.MaxValue));
        }

        //Прыжок
        //if (isWallSliding && Input.GetButtonDown("Jump"))
        //{
        //    _rigidBody.AddForce(new Vector2(0, jumpHght));
        //}
    }

    private RaycastHit2D CreateRaycast(bool isLeft)
    {
        RaycastHit2D WallCheckHit;
        if (isLeft)
        {
            WallCheckHit = Physics2D.Raycast(transform.position, new Vector2(-wallDistance, 0), wallDistance, WallForJump);
            Debug.DrawRay(Rigidbody2D.transform.position, new Vector2(wallDistance, 0), Color.blue);
        }
        else
        {
            WallCheckHit = Physics2D.Raycast(transform.position, new Vector2(wallDistance, 0), wallDistance, WallForJump);
            Debug.DrawRay(Rigidbody2D.transform.position, new Vector2(wallDistance, 0), Color.blue);
        }
        return WallCheckHit;
    }

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