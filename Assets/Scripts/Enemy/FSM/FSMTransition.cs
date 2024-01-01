using System;

[Serializable]
    public class FSMTransition
    {
    public FSMDecision Decision; // 플레이어가 범위안에 해당할시 공격옵션 -> True or Flase
    public string TrueState; // CurrentState -> AttackState
    public string FalseState; // CurrentState -> PatrolState
    }
