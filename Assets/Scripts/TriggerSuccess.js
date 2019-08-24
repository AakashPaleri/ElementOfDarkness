#pragma strict

var flame : GameObject;
var ls:UnityEngine.SceneManagement.SceneManager;

function Start () {
	flame.SetActive(false);
}

function OnTriggerEnter() {
 	flame.SetActive(true);
 	ls.LoadScene("Success"); 

}

function OnTriggerExit(){
 	flame.SetActive(false);
 }