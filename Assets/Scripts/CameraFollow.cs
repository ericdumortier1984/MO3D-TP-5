using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Jugador
    public Vector2 minPosition; // Limite minimo (izquierda y abajo)
    public Vector2 maxPosition; // Limite maximo (derecha y arriba)
    public float smoothTime = 0.2f;

    private Vector3 velocity = Vector3.zero;

	private void LateUpdate()
	{
        if (target != null)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z); // Definimos posicion deseada basada en el jugador

            // Aplicamos limites de la camara
            targetPosition.x = Mathf.Clamp(target.position.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime); // Movemos la camara suavemente
        }
	}
}
