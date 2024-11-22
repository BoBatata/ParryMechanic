using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    private StateMachine _sm;

    private void Awake()
    {
        _sm = new StateMachine();
        _sm._CurState = new CombatIdleState(gameObject, _sm);
    }

    private void Start()
    {
    }

    private void Update()
    {
        _sm._CurState.Update();
    }

    void FixedUpdate()
    {
        _sm._CurState.FixedUpdate();
    }
}
