using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
public Button button1;
public Button button2;
public Button button3;
public Button button4;
public Button button5;
public Button button6;
public Button button7;
public Button button8;
public Button button9;
public int answer;
public Text answerTxt;
int targetNumber = 0;
void Start()
{
targetNumber = Random.Range(1, 9);
button1.onClick.AddListener(()=>ButtonInputBehaviour(1));
button2.onClick.AddListener(()=>ButtonInputBehaviour(2));
button3.onClick.AddListener(()=>ButtonInputBehaviour(3));
button4.onClick.AddListener(()=>ButtonInputBehaviour(4));
button5.onClick.AddListener(()=>ButtonInputBehaviour(5));
button6.onClick.AddListener(()=>ButtonInputBehaviour(6));
button7.onClick.AddListener(()=>ButtonInputBehaviour(7));
button8.onClick.AddListener(()=>ButtonInputBehaviour(8));
button9.onClick.AddListener(()=>ButtonInputBehaviour(9));
}
public void ButtonInputBehaviour(int answer)
{
targetNumber = Random.Range(1, 9);
if (answer == targetNumber)
{
answerTxt.text = "Congrats!!";
}
else
{
answerTxt.text = "Try again, Value was : "+targetNumber;
}
}
}