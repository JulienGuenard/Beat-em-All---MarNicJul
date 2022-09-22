public enum EnemyIA_Behaviour
{
    AttackPlayer,
    Chill,
    Flee
}

public enum EnemyIA_MoveState
{
    Nothing,
    FollowPlayer,
    MoveRandomly,
    MoveToItem,
    Flee
}

public enum EnemyIA_NextAttack
{
    AttackGround,
    AttackAir,
    ThrowItem,
    ThrowPlayer
}


public enum AnimationState
{
    isAttacking,
    isMoving,
    isJumping,
    isIdle,
    isDead
}