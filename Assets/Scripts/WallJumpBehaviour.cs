using UnityEngine;

public class WallJumpBehaviour : MonoBehaviour, IJump
{
    [SerializeField] private float wallJumpTime = 0.2f;
    [SerializeField] private float wallSlideSpeed = 0.3f;
    [SerializeField] private float wallDistance = 0.5f;
    [SerializeField] private bool isWallSliding = false;
    [SerializeField] private LayerMask WallForJump;
    [SerializeField] private float jumpHght = 180f;


    private Rigidbody2D _rigidBody;
    private RaycastHit2D WallCheckHit;
    private float jumpTime;

    private bool isFacingRight = true;

    public LayerMask LayerMask => WallForJump;

    public Rigidbody2D Rigidbody2D { set => _rigidBody = value; }

    public void Update()
    {
        Jump(true);
    }
    public void Jump(bool isGrounded)
    {
        ////Надо переписать
        //isFacingRight = !(Input.GetAxis("Horizontal") < 0);

        ////Wall Jump   -----НЕ РАБОТАЕТ НОРМАЛЬНО ----
        //if (isFacingRight)                                                      //Если персонаж повернут вправо
        //{                                                                       //WallCheckHit - перемененная, определяющая, есть ли рядом стена
        //    WallCheckHit = Physics2D.Raycast(transform.position,                //С помощью Raycast бросается "луч" из координат персонажа
        //                                    new Vector2(wallDistance, 0),       //в горизонтальном направлении
        //                                    wallDistance,                       //на максимальное расстояние WallDistance
        //                                    WallForJump);                       //с фильтром для обнаружения только коллайдеров на слое WallForJump
        //}
        //else                                                                    //Если персонаж повернут влево
        //{                                                                       //то же самое, но в противоположную сторону
        //    WallCheckHit = Physics2D.Raycast(transform.position,
        //                                    new Vector2(-wallDistance, 0),
        //                                    wallDistance,
        //                                    WallForJump);
        //}

        //if (WallCheckHit && !isGrounded && Input.GetAxis("Horizontal") != 0)    //Если рядом стена, персонаж в воздухе и движется по горизонтали
        //{                                                                       //
        //    isWallSliding = true;                                               //Персонаж "скользит"
        //    jumpTime = Time.time + wallJumpTime;                                //Время прыжка = текущее время с запуска приложения + время для прыжка от стены
        //}                                                                       //
        //else if (jumpTime < Time.time)                                          //Иначе если время прыжка меньше текущего (истекло)
        //{                                                                       //
        //    isWallSliding = false;                                              //Персонаж "не скользит"
        //}                                                                       //

        //if (isWallSliding)                                                      //Если персонаж "скользит", его скорость по вертикали
        //{                                                                       //не ниже wallSlideSpeed и не выше float.MaxValue
        //    _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, Mathf.Clamp(_rigidBody.velocity.y, -1 * wallSlideSpeed, float.MaxValue));
        //}
        //if (isWallSliding && Input.GetButtonDown("Jump"))                       //Если персонаж "скользит" и нажимается клавиша прыжка
        //{                                                                       //
        //    _rigidBody.AddForce(new Vector2(0, jumpHght));                       //Придаем силу по вертикали
        //}
    }
}
