using UnityEngine;
public class CharacterController : MonoBehaviour
{
public float moveSpeed = 5f;
public float jumpForce = 5f;
private Rigidbody2D rb;
void Start()
{
rb = GetComponent<Rigidbody2D>();
}
void Update()
{
Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
transform.position += movement * Time.deltaTime * moveSpeed;
if (Input.GetKeyDown(KeyCode.Space))
{
rb.AddForce(new Vector3(0f, jumpForce), ForceMode2D.Impulse);
}
}
}