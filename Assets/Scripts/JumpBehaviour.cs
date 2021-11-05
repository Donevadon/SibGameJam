using UnityEngine;

public class JumpBehaviour : MonoBehaviour, IJump
{
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private float jumpHght = 180f;
    private Rigidbody2D _rigidBody;

    public LayerMask LayerMask => whatIsGround;

    public Rigidbody2D Rigidbody2D { set => _rigidBody = value; }

    public void Jump(bool isGrounded)
    {
        if (isGrounded)
        {
            _rigidBody.AddForce(new Vector2(0, jumpHght));
        }
    }

}