// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using UnityEngine;

public class Program : MonoBehaviour
{
    public float speed = 5f;
    void update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontal, 0, 0) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}

