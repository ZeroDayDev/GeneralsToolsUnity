using UnityEngine;

public class CameraShake : MonoBehaviour
{
    //Script creado por cseliteGTyZX(Kleyver De León), usalo para lo que quieras.
    //Script created by cseliteGTyZX(Kleyver De León), use this for you want.

    public static void ShakeCamera(float shakeForce, GameObject Camera)
    {
        //Here the temporal vector, influenced by a random value multiplied by the shakeforce.
        Vector2 tempVector = Random.insideUnitSphere * shakeForce;

        //Here the camera move in local, for simulate the shake.
        Camera.transform.localPosition = new Vector3(tempVector.x, tempVector.y, Camera.transform.position.z);
    }
}

