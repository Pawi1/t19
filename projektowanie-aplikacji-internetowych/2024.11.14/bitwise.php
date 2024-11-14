<?php

$zmienna1 = 1; 
$zmienna2 = 2;

$zmienna1 ^= $zmienna2;
$zmienna2 ^= $zmienna1;
$zmienna1 ^= $zmienna2;
echo($zmienna1);
echo "<br>";
echo($zmienna2);
?>
