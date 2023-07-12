using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AnimationPLayer))]

public class AnimationPLayer : MonoBehaviour
{
    private Animator _animator;
    private int runHash;
    private int idleHash;
    private int jumpHash;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        runHash = Animator.StringToHash("Run");
        idleHash = Animator.StringToHash("Idle");
        jumpHash = Animator.StringToHash("Jump");

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            _animator.SetTrigger(runHash);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            _animator.SetTrigger(jumpHash);
        }
        else
        {
            _animator.SetTrigger(idleHash);
        }
    }
}
