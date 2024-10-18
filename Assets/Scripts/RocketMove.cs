using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RocketMove : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private readonly float SPEED = 5f; //속도

    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
       
    }

    public void ShootMove(float fuel, float FUELPERSHOOT)
    {
        if (fuel >= FUELPERSHOOT)
        {
            _rb2d.AddForce(Vector2.up * SPEED);
        }
        else
        {
            Debug.Log("연료 부족");
        }
    }

   
}
