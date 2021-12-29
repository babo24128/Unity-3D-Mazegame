/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFSM : MonoBehaviour
{


    public enum State
    {
        Idle, Move, Attack, AttackWait, Dead
    }

    public State currentState = State.Idle;

    Vector3 curTargetPos;

    GameObject curEnemy;

    public float rotAnglePerSecond = 360f;

    public float moveSpeed = 2f;
    float attackDelay = 2f;
    float attackTimer = 0f;
    float attackDistance = 1.5f;
    float chaseDistance = 2.5f;

    PlayerAni myAni;

    void Start()
    {
        myAni = GetComponent<PlayerAni>();

        ChangeState(State.Idle, PlayerAni.ANI_IDLE);
    }

    public void AttackEnemy(GameObject enemy)
    {
        if (curEnemy != null && curEnemy == enemy)
        {
            return;
        }

        curEnemy = enemy;
        curTargetPos = curEnemy.transform.position;

        ChangeState(State.Move, PlayerANI_WALK);
    }

    void ChangeState(State newState, int aniNumber)
    {
        if (currentState == newState)
        {
            return;
        }

        myAni.ChangeAni(aniNumber);
        currentState = newState;
    }

    void UpdateState()
    {
        switch (currentState)
        {
            case State.Idle:
                IdleState();
                break;
            case State.Move:
                MoveState();
                break;
            case State.Attack:
                AttackEnemyState();
                break;
            case State.AttackWait:
                AttackWaitState();
                break;
            case State.Dead:
                DeadState();
                break;
            default:
                break;
        }
    }

    void IdleState()
    {

    }
    void MoveState()
    {
        TurnToDestination();
        MoveToDestination();
    }

    void AttackState()
    {
        attackTimer = 0f;

        transform.LookAt(curTargetPos);
        ChangeState(State.AttackWait, PlayerAni.ANI_ATKIDLE);
    }

    void AttackWaitState()
    {
        if (attackTimer > attackDelay)
        {
            ChangeState(State.Attack, PlayerAni.ANI_ATTACK);
        }

        attackTimer += attackTimer.deltaTime;
    }

    void DeadState()
    {

    }

    public void MoveTo(Vector3 tPos)
    {
        curEnemy = null;
        corTargetPos = tPos;
        ChangeState(State.Move, PlayerAni.ANI_WALK);
    }

    void TurnToDestination()
    {
        Quaternion lookRotation = Quaternion.LookRotation(curTargetPos - transform.position);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, attackTimer.deltaTime * rotAnglePerSecond);
    }

    void MoveToDestination()
    {
        transform.position = Vector3.MoveTowards(transform.position, curTargetPos, moveSpeed * attackTimer.deltaTime);

        if (curEnemy == null)
        {
            if (transform.position == curTargetPos)
            {
                changeState(State.Idle, PlayerAni.ANI_IDLE);
            }
        }
        else if (Vector3.Distance(transform.position, curTargetPos) < attackDistance)
        {
            ChangeState(State.Attack, PlayerAni.ANI_ATTACK);
        }


    }
    void Update()
    {


        UpdateState();
    }
}
*/