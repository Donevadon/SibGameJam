using System;
using System.Collections;
using UnityEngine;

public class BehaviourGetterTime<T> : BehaviourGetter<T> where T : IRigidbody2DSetter
{
    Coroutine coroutine;
    protected override void Exit(GameObject gObj)
    {
        if (TryGetComponents(gObj.gameObject, out var setter, out var rigidbody2D))
        {
            coroutine = StartCoroutine(Timing(2, () => setter.ResetBehaviours()));
        }
    }

    private IEnumerator Timing(int waitSeconds, Action action)
    {
        yield return new WaitForSeconds(waitSeconds);
        action();
    }

    protected override void Enter(GameObject gObj)
    {
        if (coroutine != null)
            StopCoroutine(coroutine);
        base.Enter(gObj);
    }
}