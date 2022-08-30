using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(0, 15)]
    public float BounceSpeed;
    public Rigidbody Rigidbody;

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

}
