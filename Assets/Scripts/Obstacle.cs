using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float minSpeed = 50f;
    public float maxSpeed = 150f;

    public float minSize = 0.5f;
    public float maxSize = 2.0f;
    public float maxSpinSpeed = 10f;
    
    Rigidbody2D rb;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();

        float randomSicze = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSicze, randomSicze, 1);

        Vector2 rnadomDierction = Random.insideUnitCircle;
        float randomSpeed = Random.Range(minSpeed, maxSpeed) / randomSicze;

        rb.AddForce(rnadomDierction * randomSpeed);

        float randomTorque = Random.Range(-maxSpinSpeed,maxSpinSpeed);
        rb.AddTorque(randomTorque);
    }
    void Update()
    {

    }
}
