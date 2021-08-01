using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class PlayerController : MonoBehaviour
    {
        public float controlXSpeed = 10f;
        public float controlYSpeed = 10f;
        public Camera cam;
        public GameObject bulletPrefab;
        public Transform firePoint;
        public Animator animator;

        private float shipBoundaryRadius = 0.1f;
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

            Vector3 pos = transform.position;

            pos.y += yThrow * controlYSpeed * Time.deltaTime;
            pos.x += xThrow * controlXSpeed * Time.deltaTime;

            if (pos.y + shipBoundaryRadius > cam.orthographicSize)
            {
                pos.y = cam.orthographicSize - shipBoundaryRadius;
            }
            if (pos.y - shipBoundaryRadius < -cam.orthographicSize)
            {
                pos.y = -cam.orthographicSize + shipBoundaryRadius;
            }

            float screenRatio = (float)Screen.width / (float)Screen.height;
            float widthOrtho = cam.orthographicSize * screenRatio;

            if (pos.x + shipBoundaryRadius > widthOrtho)
            {
                pos.x = widthOrtho - shipBoundaryRadius;
            }
            if (pos.x - shipBoundaryRadius < -widthOrtho)
            {
                pos.x = -widthOrtho + shipBoundaryRadius;
            }

            animator.SetFloat("positionY", yThrow);

            transform.position = pos;
        }
    }
}
