<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="index.php" method="get">
        Liczba 1: <input type="text" name="liczba1" require> <br>
        Liczba 2: <input type="text" name="liczba2" require> <br>
        Liczba 3: <input type="text" name="liczba3" require> <br>
        <input type="submit" name="submit" value="Wyślij">
    </form>    
    <?php if(isset($_GET["submit"])){
        $a = $_GET["liczba1"];
        $b = $_GET["liczba2"];
        $c = $_GET["liczba3"];
        $delta = $b*$b-4*$a*$c;
        print "a = $a, b = $b, c = $c"; 
        print "<br>";
        if ($delta < 0)
            print "Równanie nie ma pierwiastków rzeczywistych";
        elseif ($delta == 0)
            echo "Równanie ma jeden pierwiastek rzeczywisty: ",$b/(2*$a);
        else
            echo "Równanie ma dwa pierwiastki rzeczywiste: ",(-$b-sqrt($delta))/(2*$a)," i ",(-$b+sqrt($delta))/(2*$a);
        }?>

</body>
</html>