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
        _movement.Rigidbody2D = GetComponent<Rigidbody2D>();
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


    void ISetBehaviour<IJump>.SetBehaviour(IJump jump)
    {
        _jump = jump;
    }


    void ISetBehaviour<IMovement>.SetBehaviour(IMovement movement)
    {
        _movement = movement;
    }

    //Скольжение - меньше высота и пониже скорость
    //Наклон - стал ниже

}