 public var myCube : Transform;
 public var lineWidth : float = 20;
 static var inputPosA : Vector3 = Vector3.zero;
 public var posA : int[] = [0, 5, 13, 17, 12];
 static var inputPosB : Vector3 = new Vector3(-2,0,0);
 public var posB : int[] = [5, 13, 17, 12, 10]; 
 static var length : int = 5;
 
 function Start() 
 {
 	 for(var i:int = 0;i < length; i++)
     {
     	 inputPosA.x +=20;
     	 inputPosB.x +=20;
     	 inputPosA.y = posA[i];
     	 inputPosB.y = posB[i];
         DrawALine();
     }
}
 
 function DrawALine() 
 {
     var posC : Vector3 = ( ( inputPosB - inputPosA ) * 0.5 ) + inputPosA; 
     var lengthC : float = ( inputPosB - inputPosA ).magnitude; 
     Debug.Log(lengthC);
     var sineC : float = ( inputPosB.y - inputPosA.y ) / lengthC; 
     Debug.Log(sineC);
     var angleC : float = Mathf.Asin( sineC ) * Mathf.Rad2Deg; 
     if (inputPosB.x < inputPosA.x) {angleC = 0 - angleC;} 
 
     Debug.Log( "inputPosA" + inputPosA + " : inputPosB" + inputPosB + " : posC" + posC + " : lengthC " + lengthC + " : sineC " + sineC + " : angleC " + angleC );
 
     var myLine : Transform = Instantiate( myCube, posC, Quaternion.identity ); 
     myLine.localScale = Vector3(lengthC, lineWidth, lineWidth); 
     myLine.rotation = Quaternion.Euler(0, 0, angleC);
 }