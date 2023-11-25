using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace JuegoDelColgado
{
    class YevheniiVoiotekhovych
    {
        static void Main()
        {
            /* Variables enteras*/

            int attempts = 0;
            int versionHanged = 1;
            int positionsCheker = 0;

            /* Variables booleanas*/

            bool errorSelectDifficulty = false;
            bool letterFound = false;
            bool stopGame = false;
            bool resetGame = false;

            /* Constantes con mensajes para el juego */

            const string MsgSelectDifficulty = "\nPor favor, escoge el nivel de dificultad:";
            const string MsgEasyDifficulty = "A - Facil";
            const string MsgNormalDifficulty = "B - Normal";
            const string MsgHardDifficulty = "C - Dificil";
            const string MsgExpertDifficulty = "D - Experto";
            const string MsgSelectInput = "Vuestra seleccion: ";
            const string MsgSelectedLevelDifficulty = "Has escogido nivel de dificultad ";
            const string MsgShowWordSelected = "Palabra a divinar: ";
            const string MsgLetterSelectedForGuess = "Introduzca la letra que desea comprobar: ";
            const string MsgWin = "Enhorabuena has ganado!";
            const string MsgLoose = "Has perdido :(";
            const string MsgWhatWordWas = "La palabra era: ";
            const string MsgRepeatGame = "Quiere volver a juegar?\nA - Si\nB - No\nVuestra seleccion: ";
            const string MsgErrorInput = "No existe esta opcion!\n";
            const string MsgByeUser = "Hasta la proxima!";

            /* Variables de tipo cadena para los mensajes del juego */

            string selectLevelDifficulty = "";
            string wordSelected = "";
            char resetGameChoose = ' ';

            /* Variables de tipo caracter */

            char letterSelectedForGuess = ' ';

            /* Variables de tipo cadena con mensajes para el juego */

            string msgErrorSelectDificulty = "No existe ninguna dificultad en: ";
            string msgAttempts = "Numero de intentos restantes: ";

            /* Variable de tipo matriz para almazenar el alfabeto */

            char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'W', 'W', 'X', 'Y', 'Z' };

            /* Versiones de los dibujos del ahorcado */

            const string hangedV1 = "\n+=======\n|\n|\n|\n|\n|\n+=========";
            const string hangedV2 = "\n+=======\n|      |\n|\n|\n|\n|\n+=========";
            const string hangedV3 = "\n+=======\n|      |\n|      O\n|\n|\n|\n+=========";
            const string hangedV4 = "\n+=======\n|      |\n|      O\n|      |\n|\n|\n+=========";
            const string hangedV5 = "\n+=======\n|      |\n|      O\n|     /|\n|\n|\n+=========";
            const string hangedV6 = "\n+=======\n|      |\n|      O\n|     /|\\\n|\n|\n+=========";
            const string hangedV7 = "\n+=======\n|      |\n|      O\n|     /|\\\n|     /\n|\n+=========";
            const string hangedV8 = "\n+=======\n|      |\n|      O\n|     /|\\\n|     / \\\n|\n+=========";

            /* Variable con palabras randoms */

            string randomWords = "perro gato ventana libro helado montana lapiz rana estrella arbol coche sol bicicleta mesa tigre silla elefante nube oceano reloj manzana telefono zapatos mariposa casa vela angel teclado chocolate arcoiris computadora flor puerta ojo pelota llama bufanda tren sombrero guitarra cama espejo cerdo cuaderno jardin llave naranja\r\nleon silla rueda nieve lapiz cuchillo television platano hoja silla cepillo caja elefante barco espejo globo reina selva estrella traje paleta puente avion lechuga uva cereza nube arbol oso zapato caracol puerta robot cinta brujula almohada huevo mani zorro juguete arco melon fruta yate pina\r\nmedusa lluvia linterna nadar acuario espejo rueda pajaro leon nido mesa cafe tren nube calcetin globo avion buho estrella libro rio puente selva pluma foco arbol cama tigre lapiz cuaderno casa reloj nieve puerta gato vino aro cerdo helado moto arco faro queso guitarra\r\nmartillo rana hoja piano silla foco diente gafas cerdo vela mono tigre paleta melon iguana queso vaca oveja aguila gorila arena barco espejo traje zanahoria ojo caja arbol cama llave naranja jugo uva platano casa nube rio sol flor guitarra techo pulpo arcoiris\r\nraton puente castillo dinosaurio huevo jet lagarto mariposa napalm orca pajaro quimica robot submarino trebol ukelele vampiro whisky yate zariguella abaco buho condor dalmata ebano futbol gargola habil indigo jirafa kilogramo lampara marmol nacar oceano parrafo quebec robalo solido trebol utero vater";

            /* MENU */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\n                                                                          \r\n  ,---.  ,--.  ,--. ,-----. ,------.  ,-----.  ,---.  ,------.   ,-----.  \r\n /  O  \\ |  '--'  |'  .-.  '|  .--. ''  .--./ /  O  \\ |  .-.  \\ '  .-.  ' \r\n|  .-.  ||  .--.  ||  | |  ||  '--'.'|  |    |  .-.  ||  |  \\  :|  | |  | \r\n|  | |  ||  |  |  |'  '-'  '|  |\\  \\ '  '--'\\|  | |  ||  '--'  /'  '-'  ' \r\n`--' `--'`--'  `--' `-----' `--' '--' `-----'`--' `--'`-------'  `-----'  \r\n                                                                          \r\n");
            Console.ResetColor();

            do
            {
                Console.WriteLine(MsgSelectDifficulty + "\n");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(MsgEasyDifficulty);
                Console.WriteLine(MsgNormalDifficulty);
                Console.WriteLine(MsgHardDifficulty);
                Console.WriteLine(MsgExpertDifficulty + "\n");
                Console.ResetColor();

                Console.Write(MsgSelectInput);
                selectLevelDifficulty = Console.ReadLine();

                if (selectLevelDifficulty != "a" && selectLevelDifficulty != "A" && selectLevelDifficulty != "b" && selectLevelDifficulty != "B" && selectLevelDifficulty != "c" && selectLevelDifficulty != "C" && selectLevelDifficulty != "d" && selectLevelDifficulty != "D")
                {
                    errorSelectDifficulty = true;

                    while (errorSelectDifficulty == true)
                    {
                        Console.WriteLine(msgErrorSelectDificulty + selectLevelDifficulty + "\n");
                        Console.Write(MsgSelectInput);
                        selectLevelDifficulty = Console.ReadLine();
                        if (selectLevelDifficulty == "a" || selectLevelDifficulty == "A" || selectLevelDifficulty == "b" || selectLevelDifficulty == "B" || selectLevelDifficulty == "c" || selectLevelDifficulty == "C" || selectLevelDifficulty == "d" || selectLevelDifficulty == "D")
                        {
                            errorSelectDifficulty = false;
                        }
                    }
                }

                Console.WriteLine(); // Salto de linea

                switch (selectLevelDifficulty)
                {
                    case "a":
                        Console.WriteLine(MsgSelectedLevelDifficulty + "facil!");
                        attempts = 7;
                        break;
                    case "A":
                        Console.WriteLine(MsgSelectedLevelDifficulty + "facil!");
                        attempts = 7;
                        break;
                    case "b":
                        Console.WriteLine(MsgSelectedLevelDifficulty + "normal!");
                        attempts = 5;
                        break;
                    case "B":
                        Console.WriteLine(MsgSelectedLevelDifficulty + "normal!");
                        attempts = 5;
                        break;
                    case "c":
                        Console.WriteLine(MsgSelectedLevelDifficulty + "dificil!");
                        attempts = 4;
                        break;
                    case "C":
                        Console.WriteLine(MsgSelectedLevelDifficulty + "dificil!");
                        attempts = 4;
                        break;
                    case "d":
                        Console.WriteLine(MsgSelectedLevelDifficulty + "experto!");
                        attempts = 3;
                        break;
                    case "D":
                        Console.WriteLine(MsgSelectedLevelDifficulty + "experto!");
                        attempts = 3;
                        break;
                }

                /* MAIN */

                string[] words = randomWords.Split(' ');
                Random random = new Random();
                int randomIndex = random.Next(0, words.Length);
                wordSelected = words[randomIndex];
                string[] wordSelectecdOculted = new string[wordSelected.Length];

                for (int i = 0; i < wordSelected.Length; i++)
                {
                    wordSelectecdOculted[i] += "_ ";
                }

                while (attempts > 0 && !stopGame)
                {
                    Console.WriteLine("\n" + msgAttempts + attempts + "\n");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        if (alphabet[i] == letterSelectedForGuess)
                        {
                            alphabet[i] = '-';
                        }
                        Console.Write(alphabet[i] + " ");
                        if (i == 8 || i == 17)
                        {
                            Console.WriteLine(); // Salto de linea
                        }
                    }
                    Console.ResetColor();

                    Console.WriteLine("\n"); // Doble Salto de linea

                    Console.Write(MsgShowWordSelected);
                    for (int i = 0; i < wordSelected.Length; i++)
                    {
                        Console.Write(wordSelectecdOculted[i]);
                    }
                    Console.WriteLine(); // Salto de linea

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    switch (versionHanged)
                    {
                        case 1:
                            Console.WriteLine(hangedV1 + "\n");
                            break;
                        case 2:
                            Console.WriteLine(hangedV2 + "\n");
                            break;
                        case 3:
                            Console.WriteLine(hangedV3 + "\n");
                            break;
                        case 4:
                            Console.WriteLine(hangedV4 + "\n");
                            break;
                        case 5:
                            Console.WriteLine(hangedV5 + "\n");
                            break;
                        case 6:
                            Console.WriteLine(hangedV6 + "\n");
                            break;
                        case 7:
                            Console.WriteLine(hangedV7 + "\n");
                            break;
                    }
                    Console.ResetColor();

                    Console.Write(MsgLetterSelectedForGuess);
                    letterSelectedForGuess = char.ToUpper(Console.ReadLine()[0]);

                    for (int i = 0; i < wordSelected.Length; i++)
                    {
                        if (char.ToUpper(wordSelected[i]) == letterSelectedForGuess)
                        {
                            wordSelectecdOculted[i] = letterSelectedForGuess + " ";
                            letterFound = true;
                        }
                    }

                    Console.WriteLine("\n----------------------------------------------");

                    if (letterFound == false)
                    {
                        attempts--;
                        versionHanged++;
                    }

                    letterFound = false;

                    for (int i = 0; i < wordSelectecdOculted.Length; i++)
                    {
                        if (!wordSelectecdOculted[i].Contains("_"))
                        {
                            positionsCheker++;
                        }
                    }

                    if (positionsCheker == wordSelectecdOculted.Length)
                    {
                        stopGame = true;
                    }

                    positionsCheker = 0;

                    if (stopGame == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n" + MsgWin + "\n");
                        Console.ResetColor();
                        Console.Write(MsgRepeatGame);
                        resetGameChoose = char.ToUpper(Console.ReadLine()[0]);
                        while (resetGameChoose != 'A' && resetGameChoose != 'B')
                        {
                            Console.WriteLine(MsgErrorInput);
                            Console.Write("\n" + MsgRepeatGame);
                            resetGameChoose = char.ToUpper(Console.ReadLine()[0]);
                        }
                        if (resetGameChoose == 'A')
                        {
                            resetGame = true;
                        }
                    }
                    else if (attempts <= 0)
                    {
                        Console.Write("\n" + MsgWhatWordWas);
                        Console.WriteLine(wordSelected + "\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(MsgLoose);
                        Console.ResetColor();
                        Console.Write("\n" + MsgRepeatGame);
                        resetGameChoose = char.ToUpper(Console.ReadLine()[0]);
                        while (resetGameChoose != 'A' && resetGameChoose != 'B')
                        {
                            Console.WriteLine(MsgErrorInput);
                            Console.Write("\n" + MsgRepeatGame);
                            resetGameChoose = char.ToUpper(Console.ReadLine()[0]);
                        }
                        if (resetGameChoose == 'A')
                        {
                            resetGame = true;
                            versionHanged = 1;
                        }
                        else
                        {
                            resetGame = false;
                            Console.WriteLine("\n" + MsgByeUser);
                        }
                    }
                }
            } while (resetGame == true);
        }
    }
}