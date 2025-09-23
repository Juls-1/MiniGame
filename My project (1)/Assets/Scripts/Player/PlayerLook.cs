using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerLook : MonoBehaviour


{
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 20f;
    public float ySensitivity = 20f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //calcula la rotacion de la camara para ver arriba y abajo
        xRotation -= (mouseY*Time.deltaTime)*ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //aplica la rotacion a la camara y al jugador
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //rota el jugador para ver a los lados
        transform.Rotate(Vector3.up * (mouseX*Time.deltaTime)*xSensitivity);
    }


}
