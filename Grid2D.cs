using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Grid2D : MonoBehaviour
{
public GameObject squarePrefab; // Assign your square sprite in the
// inspector
public int gridWidth = 5;
public int gridHeight = 5;
public float padding = 1.3f; // Space between sprites
void Start()
{
SpawnGrid();
}
void SpawnGrid()
{
for (int x = 0; x < gridWidth; x++)
{
for (int y = 0; y < gridHeight; y++)
{
// Calculate position for each sprite in the grid
Vector2 spawnPosition = new Vector2(x * padding, y * padding);
// Instantiate the sprite at the calculated position
Instantiate(squarePrefab, spawnPosition, Quaternion.identity,
transform);
}
}
}
}