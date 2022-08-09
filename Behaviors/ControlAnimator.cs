using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MapValuesToAnimation : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();    
    }

    public void updateAnimation(string anim)
    {
        _animator.SetBool(anim, true);
    }
}
