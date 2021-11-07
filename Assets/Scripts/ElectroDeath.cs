using UnityEngine;

public class ElectroDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<IDeath>(out var death))
        {
            death.Die();
        }
    }
}
