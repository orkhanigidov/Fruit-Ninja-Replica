using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject fruitSlicedPrefab;
    private Rigidbody2D rb;
    public float startForce = 15f;

    [Range(0f, 10f)]
    public float minRotation;
    [Range(0f, 10f)]
    public float maxRotation;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
        rb.rotation = 45f;
    }

    private void FixedUpdate()
    {
        rb.rotation += Random.Range(minRotation, maxRotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Blade"))
        {
            //Vector3 direction = (collision.transform.position - transform.position).normalized;
            //Quaternion rotation = Quaternion.LookRotation(direction);
            GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, transform.rotation);
            Destroy(slicedFruit, 3f);
            Destroy(gameObject);
        }
    }
}
