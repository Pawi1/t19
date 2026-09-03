<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>zadanie 1</title>
</head>
<body>
    <form action="" method="get">
        <label for="tekst">Podaj tekst: </label>
        <input type="text" name="tekst" id="tekst">
        <button type="submit">Przetwórz</button>
    </form>
    <p id="output">
        <?php 
            $tekst = $_GET["tekst"];
            echo $tekst
        ?>
    </p>
</body>
</html>