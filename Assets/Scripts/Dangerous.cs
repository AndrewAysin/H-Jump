using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dangerous : MonoBehaviour
{
    public Text Text;
    private Object _playerExplosion;

    private void Start()
    {
        _playerExplosion = Resources.Load("PlayerExplosion");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameObject explosionRef2 = (GameObject)Instantiate(_playerExplosion);
            explosionRef2.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Destroy(collision.gameObject);
            PlayerManager.isGameOver = true;
        }
        
    }
}
