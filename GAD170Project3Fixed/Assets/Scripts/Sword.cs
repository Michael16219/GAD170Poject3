using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, Weapon
{
    public float weaponDamage = 10f;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PerformAttack()
    {
        animator.SetTrigger("Base_Attack");
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
            PerformAttack();
    }
}
