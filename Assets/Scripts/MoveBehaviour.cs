using UnityEngine;

public class MoveBehaviour : MonoBehaviour, IMovement
{
    [SerializeField] private float moveSpeed = 10f;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody2D;

    public Rigidbody2D Rigidbody2D 
    {
        protected get => _rigidbody2D;
        set 
        {
            _rigidbody2D = value;
            value.TryGetComponent(out _spriteRenderer);
        } 
    }

    public virtual void Move(float axisMove)
    {
        Flip(axisMove < 0);
        Rigidbody2D.velocity = new Vector2(axisMove * moveSpeed, Rigidbody2D.velocity.y);
    }

    public void Stop()
    {
        if (Rigidbody2D.velocity.x != 0)
            Rigidbody2D.velocity = new Vector2(0, Rigidbody2D.velocity.y);
    }

    private void Flip(bool isLeft)
    {
        _spriteRenderer.flipX = isLeft;
    }
}
