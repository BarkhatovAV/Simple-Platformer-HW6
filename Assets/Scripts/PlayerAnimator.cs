using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void AnimateWalkingToRight(bool isWalkRight)
    {
        _animator.SetBool("Walk Right", isWalkRight);
    }

    public void AnimateWalkingToLeft(bool isWalkLeft)
    {
        _animator.SetBool("Walk Left", isWalkLeft);
    }
}
