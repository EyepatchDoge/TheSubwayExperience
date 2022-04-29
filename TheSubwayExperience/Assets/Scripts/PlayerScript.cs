using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    #region references

    public int movementSpeed;
    CharacterController cc;
    private Vector3 playerVelocity;
    public float jumpHeight = 1.0f;
    private float gravityValue => Physics.gravity.y;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        //if the player is still moving down while grounded, than stop y movement
        if (cc.isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0;
        }

        Move();
        Jump();

        playerVelocity.y += gravityValue * Time.deltaTime;
        cc.Move(playerVelocity * Time.deltaTime);

    }

    public void Move()
    {
        float vert = Input.GetAxis("Vertical") * movementSpeed;
        float hort = Input.GetAxis("Horizontal") * movementSpeed;

        cc.Move((transform.right * hort + transform.forward * vert) * Time.deltaTime);

    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && cc.isGrounded)
        {

            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
    }
}
