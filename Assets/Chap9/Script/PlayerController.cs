using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody playerRigidbody;
    public float speed = 8f;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //if(Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //}
        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    playerRigidbody.AddForce(0f, 0f, -speed);
        //}
        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}

        //����� ������ �Է°��� ���� �� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է� ���� �̵� �ӷ��� ���� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vec3 �ӵ��� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        //RigidBody�� �Ҵ�
        playerRigidbody.velocity = newVelocity;

    }

    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();

        gameManager.EndGame();
    }
}