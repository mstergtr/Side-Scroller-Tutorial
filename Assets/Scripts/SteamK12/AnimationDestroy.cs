using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class AnimationDestroy : MonoBehaviour
    {
        public Animator animator;

        void OnEnable()
        {
            animator.Play("explosion");
            Destroy(gameObject, animator.GetCurrentAnimatorStateInfo(0).length);
        }
    }
}
