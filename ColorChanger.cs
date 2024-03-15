using System.Collections.Generic;
using UnityEngine;
public class ColorChanger : MonoBehaviour
{
// List of colors
public List<Color> colors;
private int currentColorIndex = 0; //current color
void Update()
{
if (Input.GetMouseButtonDown(0)) //check for mouse click
{
Vector2 mousePosition =
Camera.main.ScreenToWorldPoint(Input.mousePosition);//get mouse position
RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero); //Cast
// ray from mouse position
if (hit.collider != null && hit.transform == this.transform) //check if ray
// hits square
{
// Change to the next color in the list
currentColorIndex = (currentColorIndex + 1) % colors.Count;
GetComponent<SpriteRenderer>().color = colors[currentColorIndex];
}
}
}
}
