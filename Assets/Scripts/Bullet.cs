using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ParticleSystem explosionPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision coll)
    {
        ParticleSystem fire = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        fire.Play();

        Destroy(gameObject);
    }
}
