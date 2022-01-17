using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class AnimationDestroy : MonoBehaviour
    {
        [SerializeField] Animator animator;

        void OnEnable()
        {
            animator.Play("explosion");
            Destroy(gameObject, animator.GetCurrentAnimatorStateInfo(0).length);
        }
    }
}
