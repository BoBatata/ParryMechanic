using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChassingState : State
{
    //private CharacterMotor _charMotor;
    //private CatchParticipant _catchParticipant;
    //private CatchParticipant[] _catchParticipants;

    public ChassingState(GameObject go, StateMachine sm) : base(go, sm)
    {
    }

    //public override void Enter()
    //{
    //    base.Enter();
    //    _charMotor = _go.GetComponent<CharacterMotor>();
    //    _catchParticipant = _go.GetComponent<CatchParticipant>();
    //    _catchParticipants = GameObject.FindObjectsOfType<CatchParticipant>();
    //}

    //public override void FixedUpdate()
    //{
    //    base.FixedUpdate();
    //    Vector3 closestRunnerPos = GetClosestRunnerPos();
    //    Vector3 runDir = (closestRunnerPos - _go.transform.position).normalized;
    //    _charMotor._moveDir = runDir;

    //    if (_catchParticipant._CatchRole == CatchParticipant.CatchRole.Runner)
    //        _sm._CurState = new FleeingState(_go, _sm);
    //}

    //private Vector3 GetClosestRunnerPos()
    //{
    //    CatchParticipant closestParticipant = null;
    //    float curMinDistance = 99999;
    //    for (int i = 0; i < _catchParticipants.Length; i++)
    //    {
    //        if (_catchParticipants[i] != this._catchParticipant)
    //        {
    //            float distance = Vector3.Distance(_go.transform.position, _catchParticipants[i].transform.position);
    //            if (distance < curMinDistance)
    //            {
    //                curMinDistance = distance;
    //                closestParticipant = _catchParticipants[i];
    //            }
    //        }
    //    }

    //    return closestParticipant.transform.position;
    //}
}
