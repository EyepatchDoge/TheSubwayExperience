using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float horizontalSpeed = 1f;
    public float verticalSpeed = 1f;

    public Transform playerTranform;

    private float xRotation = 0.0f;
    private float yRotation = 0.0f;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        //cam.transform.localPosition = playerTranform.localPosition;

        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        //to flip the way it looks
        float mouseY = (Input.GetAxis("Mouse Y") * verticalSpeed) * -1;

        yRotation += mouseX;
        xRotation += mouseY;

        xRotation = Mathf.Clamp(xRotation, -90, 90);

        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
        playerTranform.eulerAngles = new Vector3(0, yRotation, 0);
    }
}
