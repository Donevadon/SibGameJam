using System;
using UnityEngine;
public class PlayerController : MonoBehaviour, ISetBehaviour<IMovement>, ISetBehaviour<IJump>
{
    [SerializeField] private Transform groundCheck;
    private readonly float groundRadius = 0.1f;
    private IJump _jump;
    private IMovement _movement;


    public void Awake()
    {
        _movement = GetComponent<IMovement>();
        _jump = GetComponent<IJump>();

        var rb = GetComponent<Rigidbody2D>();
        _jump.Rigidbody2D = rb;
        _movement.Rigidbody2D = rb;
    }


    public void Update()
    {
        JumpControll();
        MoveControll();
    }

    private void JumpControll()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jump.Jump(IsGrounded(_jump.LayerMask));
        }
    }
    public bool IsGrounded(LayerMask layerMask) => Physics2D.OverlapCircle(groundCheck.position, groundRadius, layerMask);

    private void MoveControll()
    {
        var axis = Input.GetAxis("Horizontal");
        if (axis != 0)
            _movement.Move(axis);
        else
            _movement.Stop();
    }


    IJump ISetBehaviour<IJump>.SetBehaviour(IJump jump)
    {
        IJump oldJump = _jump;
        _jump = jump;
        return oldJump;
    }


    IMovement ISetBehaviour<IMovement>.SetBehaviour(IMovement movement)
    {
        IMovement oldMovement = _movement;
        _movement = movement;
        return oldMovement;
    }

    //Скольжение - меньше высота и пониже скорость
    //Наклон - стал ниже

}