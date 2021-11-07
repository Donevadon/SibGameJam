using System;
using UnityEngine;

public class PlayerController : MonoBehaviour, ISetBehaviour<IMovement>, ISetBehaviour<IJump>, IDeath
{
    [SerializeField] private Transform groundCheck;
    public event Action Deaded;
    private readonly float groundRadius = 0.1f;
    private IJump _defaultJump;
    private IJump _jump;
    private IMovement _defaulMovement;
    private IMovement _movement;

    public void Awake()
    {
        _defaulMovement = GetComponent<IMovement>();
        _defaultJump = GetComponent<IJump>();

        var rb = GetComponent<Rigidbody2D>();
        _defaultJump.Rigidbody2D = rb;
        _defaulMovement.Rigidbody2D = rb;
    }

    private void Start()
    {
        ResetBehaviours();
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


    public void ResetBehaviours()
    {
        ResetJump();
        ResetMovement();
    }

    private void ResetMovement()
    {
        _movement = _defaulMovement;
    }

    private void ResetJump()
    {
        _jump = _defaultJump;
    }

    public void Die()
    {
        //TODO: Сделать смерть
        if (Deaded != null)
        {
            Deaded();
        }
    }

    //Скольжение - меньше высота и пониже скорость
    //Наклон - стал ниже

}