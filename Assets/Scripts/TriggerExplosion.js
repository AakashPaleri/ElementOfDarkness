#pragma strict

var flame : GameObject;
var ls:UnityEngine.SceneManagement.SceneManager;

function Start () {
	flame.SetActive(false);
}

function OnTriggerEnter() {
 	flame.SetActive(true);
 	yield WaitForSeconds(1);
 	ls.LoadScene("Game Over"); 


}

function OnTriggerExit(){
 	flame.SetActive(false);
 }