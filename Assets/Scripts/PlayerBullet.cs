using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 2.0f;
    public int damage = 1;

    void Update()
    {
        Vector3 bulletPos = transform.position;

        bulletPos = new Vector3(bulletPos.x + speed * Time.deltaTime, bulletPos.y, 0.0f);

        transform.position = bulletPos;

        if (bulletPos.x >= 4)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
