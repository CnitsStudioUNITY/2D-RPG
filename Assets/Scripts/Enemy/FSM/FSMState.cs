using System;
using UnityEditor.Build;
using UnityEngine.UIElements;

[Serializable]
public class FSMState // AttackState
{
    public string ID;
    public FSMAction[] Actions; // 이동 모션 l 공격 모션
    public FSMTransition[] Transitions;

    public void UpdateState(EnemyBrain enemyBrain)
    {
        ExecuteActions();
        ExecuteTransitions(enemyBrain);
    }
    private void ExecuteActions()
    {
        for (int i = 0; i < Actions.Length; i++)
        {
            Actions[i].Act();
        }
    }

    private void ExecuteTransitions(EnemyBrain enemyBrain)
    {
        if (Transitions == null || Transitions.Length <= 0) return;
        for (int i = 0; i < Transitions.Length; i++)
        {
            bool value = Transitions[i].Decision.Decide();
            if (value)
            {
                enemyBrain.ChangeState(Transitions[i].TrueState);
            }
            else
            {
                enemyBrain.ChangeState(Transitions[i].FalseState);
            }
        }

    }
}