
var texture1 : Texture2D;
var texture2 : Texture2D;

 
function Start() {
        changeTexture();
}
 
function Update () {
 
}
 
function changeTexture () {

for (i=1;i>0;i++) {
yield WaitForSeconds(0.3);

GetComponent.<Renderer>().material.mainTexture = texture1;

yield WaitForSeconds(0.3);

GetComponent.<Renderer>().material.mainTexture = texture2;
}
 
       
}