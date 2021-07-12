using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    Animator animator;
    AnimatorClipInfo[] currentClipInfo;
    string clipName;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        animator.Play("explosion-animation");
    }

    void Update()
    {
        currentClipInfo = this.animator.GetCurrentAnimatorClipInfo(0);

        if (currentClipInfo[0].clip.name == "Done")
        {
            Destroy(gameObject);
        }
    }
}
