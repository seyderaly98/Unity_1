using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEvents : MonoBehaviour
{
    Character character;
    public GameObject target;
    Character characterTarget;

    void Start()
    {
        character = GetComponentInParent<Character>();
        characterTarget = target.GetComponent<Character>();
    }

    void ShootEnd()
    {
        character.SetState(Character.State.Idle);
    }

    void AttackEnd()
    {
        character.SetState(Character.State.RunningFromEnemy);
    }

    void DeathTarget()
    {
        if (!characterTarget.death)
        {
            characterTarget.animator.SetTrigger("DeathTarget");
            characterTarget.death = true;
        }
    }
}
