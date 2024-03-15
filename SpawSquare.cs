using System.Collections;
using UnityEngine;
public class SpawnSquare : MonoBehaviour
{
public GameObject squarePrefab;
public float spawnInterval = 2.0f;
void Start()
{
squarePrefab.transform.position = new Vector2(100, 100);
StartCoroutine(SpawnAndDestroy());
}
IEnumerator SpawnAndDestroy()
{
while (true)
{
// Spawn a square at a random position within the camera's view
Vector2 spawnPosition = new Vector2(Random.Range(-8.0f, 8.0f),
Random.Range(-4.0f, 4.0f));
GameObject square = Instantiate(squarePrefab, spawnPosition,
Quaternion.identity);
// Wait for the specified interval, then destroy the square
yield return new WaitForSeconds(spawnInterval);
Destroy(square);
}
}
}