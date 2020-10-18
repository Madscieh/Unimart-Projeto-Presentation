using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Transform ancoraCamera;

    // Update is called once per frame
    void Update()
    {
        // Presente
        // Banheiro
        if (ancoraCamera.position.x < 5f && ancoraCamera.position.x > -9f &&
            ancoraCamera.position.y < -10f && ancoraCamera.position.y > -22f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, -4.08f, -1.9f),
                Mathf.Clamp(ancoraCamera.position.y, -18.9f, -13.1f),
                transform.position.z);
        }
        // Deposito 1
        else if (ancoraCamera.position.x < 5f && ancoraCamera.position.x > -9f &&
                 ancoraCamera.position.y < 11f && ancoraCamera.position.y > -1f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, -4.14f, -1.9f),
                Mathf.Clamp(ancoraCamera.position.y, 2.06f, 7.93f),
                transform.position.z);
        }
        // Deposito 2
        else if (ancoraCamera.position.x < 10.5f && ancoraCamera.position.x > -1.5f &&
                 ancoraCamera.position.y < 32f && ancoraCamera.position.y > 18f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 3.69f, 5.23f),
                Mathf.Clamp(ancoraCamera.position.y, 23.08f, 28.98f),
                transform.position.z);
        }
        // Deposito 3
        else if (ancoraCamera.position.x < 37.47f && ancoraCamera.position.x > 24.4f &&
                 ancoraCamera.position.y < 31.84f && ancoraCamera.position.y > 18f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 29.69f, 32.26f),
                Mathf.Clamp(ancoraCamera.position.y, 23.09f, 28.94f),
                transform.position.z);
        }
        // Lounge
        else if (ancoraCamera.position.x < 48f && ancoraCamera.position.x > 34f &&
                 ancoraCamera.position.y < 13f && ancoraCamera.position.y > 1f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 40.7f, 43.26f),
                Mathf.Clamp(ancoraCamera.position.y, 4.07f, 9.94f),
                transform.position.z);
        }
        // Mercado
        else if (ancoraCamera.position.x < 27f && ancoraCamera.position.x > 11f &&
                 ancoraCamera.position.y < 11.8f && ancoraCamera.position.y > -9f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 17.77f, 20.31f),
                Mathf.Clamp(ancoraCamera.position.y, -5.93f, 8.96f),
                transform.position.z);
        }

        // 1920 - Doces
        // Jardim 1
        else if (ancoraCamera.position.x < 29f && ancoraCamera.position.x > 9f &&
                 ancoraCamera.position.y < 90f && ancoraCamera.position.y > 70f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 14.3f, 22.972f),
                Mathf.Clamp(ancoraCamera.position.y, 72.74f, 87.68f),
                transform.position.z);
        }
        // Doces 1
        else if (ancoraCamera.position.x < 0f && ancoraCamera.position.x > -20f &&
                 ancoraCamera.position.y < 90f && ancoraCamera.position.y > 70f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, -14.92f, -5.99f),
                Mathf.Clamp(ancoraCamera.position.y, 72.74f, 87.68f),
                transform.position.z);
        }
        // Doces 2
        else if (ancoraCamera.position.x < 0f && ancoraCamera.position.x > -20f &&
                 ancoraCamera.position.y < 120.68f && ancoraCamera.position.y > 70f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, -14.91f, -5.83f),
                Mathf.Clamp(ancoraCamera.position.y, 102.73f, 117.7f),
                transform.position.z);
        }
        // Doces 3
        else if (ancoraCamera.position.x < 29.14f && ancoraCamera.position.x > 8.06f &&
                 ancoraCamera.position.y < 120.68f && ancoraCamera.position.y > 102.7f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 14.07f, 23.2f),
                Mathf.Clamp(ancoraCamera.position.y, 105.65f, 117.7f),
                transform.position.z);
        }
        // Doces - Save
        else if (ancoraCamera.position.x < 54.19f && ancoraCamera.position.x > 33.06f &&
                 ancoraCamera.position.y < 120.68f && ancoraCamera.position.y > 102.88f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 39.12f, 49.11f),
                Mathf.Clamp(ancoraCamera.position.y, 107.7f, 117.65f),
                transform.position.z);
        }

        // Jardim 2
        else if (ancoraCamera.position.x < 49f && ancoraCamera.position.x > 33f &&
                 ancoraCamera.position.y < 95f && ancoraCamera.position.y > 77.7f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 39.25f, 43.96f),
                Mathf.Clamp(ancoraCamera.position.y, 80.74f, 91.68f),
                transform.position.z);
        }

        // 1950 - Comida
        // Banheiro
        else if (ancoraCamera.position.x < 92f && ancoraCamera.position.x > 77f &&
                 ancoraCamera.position.y < 68f && ancoraCamera.position.y > 55f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 82.42f, 85.05f),
                Mathf.Clamp(ancoraCamera.position.y, 58.74f, 64.69f),
                transform.position.z);
        }
        // Lounge
        else if (ancoraCamera.position.x < 91f && ancoraCamera.position.x > 77f &&
                 ancoraCamera.position.y < 88f && ancoraCamera.position.y > 77f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 82.45f, 85.02f),
                Mathf.Clamp(ancoraCamera.position.y, 79.81f, 85.63f),
                transform.position.z);
        }
        // Deposito
        else if (ancoraCamera.position.x < 97f && ancoraCamera.position.x > 85f &&
                 ancoraCamera.position.y < 109f && ancoraCamera.position.y > 96f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 90.38f, 92.02f),
                Mathf.Clamp(ancoraCamera.position.y, 100.81f, 106.66f),
                transform.position.z);
        }
        // Jardim
        else if (ancoraCamera.position.x < 135f && ancoraCamera.position.x > 118f &&
                 ancoraCamera.position.y < 96f && ancoraCamera.position.y > 79f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 125.31f, 129.92f),
                Mathf.Clamp(ancoraCamera.position.y, 82.71f, 93.72f),
                transform.position.z);
        }
        // Mercado
        else if (ancoraCamera.position.x < 112f && ancoraCamera.position.x > 97f &&
                 ancoraCamera.position.y < 89f && ancoraCamera.position.y > 68f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 104.38f, 107.05f),
                Mathf.Clamp(ancoraCamera.position.y, 71.74f, 88.67f),
                transform.position.z);
        }
        // Dungeon - Salgados
        // Labirinto
        else if (ancoraCamera.position.x < 175f && ancoraCamera.position.x > 131f &&
                 ancoraCamera.position.y < 51f && ancoraCamera.position.y > 37f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 136.62f, 168.19f),
                Mathf.Clamp(ancoraCamera.position.y, 40.01f, 47.95f),
                transform.position.z);
        }

        // Sala 1 - Pequena
        else if (ancoraCamera.position.x < 175f && ancoraCamera.position.x > 161f &&
                 ancoraCamera.position.y < 78f && ancoraCamera.position.y > 68f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 166.65f, 169.2f),
                Mathf.Clamp(ancoraCamera.position.y, 71f, 74.98f),
                transform.position.z);
        }
        // Sala 2 - Grande
        else if (ancoraCamera.position.x < 202f && ancoraCamera.position.x > 177f &&
                 ancoraCamera.position.y < 106f && ancoraCamera.position.y > 81f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 182.86f, 197.24f),
                Mathf.Clamp(ancoraCamera.position.y, 85.99f, 102.87f),
                transform.position.z);
        }
        // Sala 3 - Média
        else if (ancoraCamera.position.x < 226f && ancoraCamera.position.x > 207.5f &&
                 ancoraCamera.position.y < 66f && ancoraCamera.position.y > 52f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 213.6f, 221.2f),
                Mathf.Clamp(ancoraCamera.position.y, 55f, 63f),
                transform.position.z);
        }
        // Sala 4 - Média (SUL)
        else if (ancoraCamera.position.x < 198f && ancoraCamera.position.x > 179f &&
                 ancoraCamera.position.y < 28f && ancoraCamera.position.y > 12f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 184.5f, 193.3f),
                Mathf.Clamp(ancoraCamera.position.y, 15f, 22.95f),
                transform.position.z);
        }
        // Corredor
        else if (ancoraCamera.position.x < 192f && ancoraCamera.position.x > 185f &&
                 ancoraCamera.position.y < 74f && ancoraCamera.position.y > 34f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 188.7f, 189f),
                Mathf.Clamp(ancoraCamera.position.y, 37f, 71f),
                transform.position.z);
        }

        // Presente - Limpeza
        // Banheiro
        else if (ancoraCamera.position.x < 92f && ancoraCamera.position.x > 77f &&
         ancoraCamera.position.y < -10f && ancoraCamera.position.y > -22f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 82.4f, 85.13f),
                Mathf.Clamp(ancoraCamera.position.y, -18.93f, -13.05f),
                transform.position.z);
        }
        // Deposito 1
        else if (ancoraCamera.position.x < 92f && ancoraCamera.position.x > 77f &&
                 ancoraCamera.position.y < 11f && ancoraCamera.position.y > -1f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 82.49f, 85.11f),
                Mathf.Clamp(ancoraCamera.position.y, 2.06f, 7.97f),
                transform.position.z);
        }
        // Deposito 2
        else if (ancoraCamera.position.x < 97.3f && ancoraCamera.position.x > 85f &&
                 ancoraCamera.position.y < 32f && ancoraCamera.position.y > 19f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 90.51f, 92.12f),
                Mathf.Clamp(ancoraCamera.position.y, 23.05f, 28.93f),
                transform.position.z);
        }
        // Deposito 3
        else if (ancoraCamera.position.x < 124f && ancoraCamera.position.x > 111f &&
                 ancoraCamera.position.y < 31.9f && ancoraCamera.position.y > 18f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 116.5f, 119.12f),
                Mathf.Clamp(ancoraCamera.position.y, 23.06f, 28.97f),
                transform.position.z);
        }
        // Lounge
        else if (ancoraCamera.position.x < 135.34f && ancoraCamera.position.x > 121f &&
                 ancoraCamera.position.y < 12.9f && ancoraCamera.position.y > 0f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 127.45f, 130.15f),
                Mathf.Clamp(ancoraCamera.position.y, 4.04f, 9.97f),
                transform.position.z);
        }
        // Mercado
        else if (ancoraCamera.position.x < 113.5f && ancoraCamera.position.x > 98f &&
                 ancoraCamera.position.y < 12f && ancoraCamera.position.y > -9f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 104.49f, 107.16f),
                Mathf.Clamp(ancoraCamera.position.y, -5.97f, 8.94f),
                transform.position.z);
        }
    }
}
