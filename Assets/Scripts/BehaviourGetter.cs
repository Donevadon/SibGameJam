using UnityEngine;

public class BehaviourGetter<K> : MonoBehaviour where K : IRigidbody2DSetter
{
    K oldBehaviour;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Rigidbody2D>(out var rigidbody2D) &&
            collision.gameObject.TryGetComponent<ISetBehaviour<K>>(out var jumper))
        {
            var behaviour = GetComponent<K>();
            behaviour.Rigidbody2D = rigidbody2D;
            oldBehaviour = jumper.SetBehaviour(behaviour);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Rigidbody2D>(out var rigidbody2D) &&
            collision.gameObject.TryGetComponent<ISetBehaviour<K>>(out var jumper))
        {
            jumper.SetBehaviour(oldBehaviour);
        }
    }
}
