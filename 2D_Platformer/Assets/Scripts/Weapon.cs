using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    private Animation anim;

    string currentState;
    const string SHOOT_ANIM = ("Muzzle Flash_Clip");

    private void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            ChangeAnimationState(SHOOT_ANIM);
        }


    }


    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }

    private void ChangeAnimationState(string newState)
    {
        if (newState == currentState)
        {
            return;
        }
        anim.Play(newState);
        currentState = newState;

    }

    bool IsAnimationPlaying(Animator animator, string stateName)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName(stateName) &&
            animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
