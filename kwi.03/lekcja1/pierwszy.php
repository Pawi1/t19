<!DOCTYPE html>
<html>
<head>
   <style>
   .b{
       color: blue;
       font-weight: bold; 
     }
   .r{
       color: red;
       font-weight: bold;
     }
   .w{
       color: green;
       font-weight: bold; 
     }
   </style>
</head>
<body>
<?php
/*
 * echo
 * ('
 *  <body bgcolor="yellow">
 * <strong>Hello!</strong>
 * </body>
 *  '); 
 */ 
/* 
 * for ($i = 0; $i < 5; ++$i)
 * {
 * 	echo 'Hello! <br>';
 * }
 */
 print(var_dump($_GET));
 $bokA = $_GET["bokA"];
 $bokB = $_GET["bokB"];
?>
<div>A wynosi: <span class="b"><?=$bokA?></span></div>
<div>B wynosi: <span class="r"><?=$bokB?></span></div><br>
<div>Pole wynosi: <span class="w"><?=$bokA*$bokB?></span></div>
<div>Obwód wynosi: <span class="w"><?=$bokA*2+$bokB*2?></span></div>
</body>
</html>
