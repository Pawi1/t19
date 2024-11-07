<!DOCTYPE html>
<html lang="pl-PL">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lekcja 2</title>
</head>
<body>
    <form action="index.php" method="get">
        Twoje imie: <input type="text" name="imie" required><br>
        Twoje nazwisko: <input type="text" name="nazwisko" required><br>
        <input type="submit" name="form" value="Wyślij">
    </form>
    <form action="index.php" method="get">
        <input type="submit" value="Reset">
    </form>
<?php if(isset($_GET["form"]))
         printf("Hej %s %s, Witaj na mojej stronie!",$_GET["imie"],$_GET["nazwisko"]);?>
</body>
</html>