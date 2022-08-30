using UnityEngine;

public class WIN : MonoBehaviour
{
    private Object _explosion;

    private void Start()
    {
        _explosion = Resources.Load("Explosion");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameObject explosionRef = (GameObject)Instantiate(_explosion);
            explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Destroy(collision.gameObject);
            PlayerManager.isGameWin = true;
        }
    }

}
