using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalKeys
{
    public static readonly int FIRST_ATTACK_TRIGGER = Animator.StringToHash("FirstAttack");
    public static readonly int SECOND_ATTACK_TRIGGER = Animator.StringToHash("SecondAttack");
    public static readonly int THIRD_ATTACK_TRIGGER = Animator.StringToHash("ThirdAttack");
}
