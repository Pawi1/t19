<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>zadanie 2</title>
</head>
<body>
    <form action="" method="post">
        <label for="liczba">Podaj liczbe: </label>
        <input type="number" name="liczba" id="liczba">
        <button type="submit">Czy pierwsza</button>
    </form>
    <p id="output">
        <?php 
            function CzyPierwsza($liczba) : bool {
             if($liczba > 1)
             {
                for($i = 2;$i < $liczba; $i++)
                {
                    if($liczba % $i == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
            return 0;
            }
            if(CzyPierwsza($_POST["liczba"]))
                echo "Liczba: ".$_POST["liczba"]." jest pierwsza";
            else
                echo "Liczba: ".$_POST["liczba"]." nie jest pierwsza";
        ?>
    </p>
</body>
</html>