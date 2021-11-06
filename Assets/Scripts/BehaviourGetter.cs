using UnityEngine;

public class BehaviourGetter<K> : MonoBehaviour where K : IRigidbody2DSetter
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enter(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Enter(collider.gameObject);
    }

    protected virtual void Enter(GameObject gObj)
    {
        if (TryGetComponents(gObj.gameObject, out var setter, out var rigidbody2D))
        {
            SetBehaviour(setter, rigidbody2D);
        }
    }

    protected void SetBehaviour(ISetBehaviour<K> setter, Rigidbody2D rigidbody2D)
    {
        var behaviour = GetComponent<K>();
        behaviour.Rigidbody2D = rigidbody2D;
        setter.SetBehaviour(behaviour);
    }


    private void OnTriggerExit2D(Collider2D collider)
    {
        Exit(collider.gameObject);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Exit(collision.gameObject);
    }

    protected virtual void Exit(GameObject gObj)
    {
        if (TryGetComponents(gObj.gameObject, out var setter, out var rigidbody2D))
        {
            setter.ResetBehaviours();
        }
    }

    protected bool TryGetComponents(GameObject collision, out ISetBehaviour<K> setter, out Rigidbody2D rigidbody2D)
    {
        setter = null;
        return collision.gameObject.TryGetComponent(out rigidbody2D) &&
                    collision.gameObject.TryGetComponent(out setter);
    }
}