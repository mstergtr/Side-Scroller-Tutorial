using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5f;
        public GameObject bulletPrefab;
        public Transform firePoint;
        public Animator animator;
        private float xThrow, yThrow;

        void Update()
        {
            ProcessMovement();

            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            }
        }

        private void ProcessMovement()
        {
            xThrow = Input.GetAxis("Horizontal");
            yThrow = Input.GetAxis("Vertical");

            transform.Translate(Vector3.right * xThrow * speed * Time.deltaTime);
            transform.Translate(Vector3.up * yThrow * speed * Time.deltaTime);
            
            Vector3 pos = transform.position;

            animator.SetFloat("positionY", yThrow);
        }
    }
}
