using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public Animator Animator;
    public void OnAttack(InputValue value)
    {
        Animator.SetBool("isAttacking", true);
    }

    public void FinishAttacking()
    {
        Animator.SetBool("isAttacking", false);
    }
}
