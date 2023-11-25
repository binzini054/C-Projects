namespace GameProject
{
    class VoitekhovychYevheniiCode
    {
        static void Main()
        {
            /*Variable entera para el menu*/
            int playOrExit;

            /*Variables enteras para los valores de vida de los personajes*/
            int healthFirstCharacter = 0, healthSecondCharacter = 0, healthThirdCharacter = 0, healthFourthCharacter = 0;

            /*Variables enteras para contar la vida maxima de los heroes*/
            int maxHealthFirstCharacter, maxHealthSecondCharacter, maxHealthThirdCharacter, maxHealthFourthCharacter;

            /*Variables enteras para los valores de ataque de los personajes*/
            int damageFirstCharacter = 0, damageSecondCharacter = 0, damageThirdCharacter = 0, damageFourthCharacter = 0;

            /*Variables enteras para los valores de escudo de los personajes*/
            int shieldFirstCharacter = 0, shieldSecondCharacter = 0, shieldThirdCharacter = 0, shieldFourthCharacter = 0;

            /*Variables enteras para los valores de habilidad de los personajes*/
            bool specialHabilityFirstCharacter = false, specialHabilitySecondCharacter = false, specialHabilityThirdCharacter = false, specialHabilityFourthCharacter = false;

            /*Variables enteras necesarias para las habilidades especiales*/
            int specialHabilityFirstCharacterRoundsCounter = 0, specialHabilitySecondCharacterRoundsCounter = 0, specialHabilityThirdCharacterRoundsCounter = 0, specialHabilityFourthCharacterRoundsCounter = 0;

            /*Variables enteras para los valores de monstruo*/
            int healthMonster, damageMonster, shieldMonster;


            /*Constantes con mensajes para menu*/
            const string MsgWelcome = "Bienvenido a Heroes vs Monstruo!\n";
            const string MsgPlayOrExit = "Que quieres hacer:\n1 - Jugar\n0 - Salir\nTu seleccion: ";
            const string MsgPlaySelect = "Perfecto! Comencemos a crear personajes.\n";
            const string MsgExitSelect = "Hasta la proxima!";

            /*Constantes con mensajes para personajes*/
            const string MsgFirstCharacter = "Primer personaje: Arquera. Introduce los valores requiridos: ";
            const string MsgSecondCharacter = "Segundo personaje: Barbaro. Introduce los valores requiridos: ";
            const string MsgThirdCharacter = "Tercer personaje: Maga. Introduce los valores requiridos: ";
            const string MsgFourthCharacter = "Cuarto personaje: Druida. Introduce los valores requiridos: ";

            /*Constantes con mensajes de valores de vida para los personajes*/
            const string MsgHealthFirstCharacter = "Vida [1500-2000]: ";
            const string MsgHealthSecondCharacter = "Vida [3000-3750]: ";
            const string MsgHealthThirdCharacter = "Vida [1000-1500]: ";
            const string MsgHealthFourthCharacter = "Vida [2000-2500]: ";

            /*Constantes con mensajes de valores de ataque para los personajes*/
            const string MsgDamageFirstCharacter = "Ataque [180-300]: ";
            const string MsgDamageSecondCharacter = "Ataque [150-250]: ";
            const string MsgDamageThirdCharacter = "Ataque [300-350]: ";
            const string MsgDamageFourthCharacter = "Ataque [70-120]: ";

            /*Constantes con mensajes de valores de escudo para personajes*/
            const string MsgShieldFirstCharacter = "Reduccion de daño (valor porcentual) [25-40]%: ";
            const string MsgShieldSecondCharacter = "Reduccion de daño (valor porcentual) [35-45]%: ";
            const string MsgShieldThirdCharacter = "Reduccion de daño (valor porcentual) [20-35]%: ";
            const string MsgShieldFourthCharacter = "Reduccion de daño (valor porcentual) [25-40]%: ";

            /*Constantes con mensajes de valores de habilidades especiales de los personajes*/
            const string MsgSpecialAbilityFirstCharacter = "Noquea al monstruo durante 2 turnos (no puede atacar)";
            const string MsgSpecialAbilitySecondCharacter = "Aumenta su defensa al 100% durante 3 turnos";
            const string MsgSpecialAbilityThirdCharacter = "Dispara una bola de fuego con daño como 3 veces su ataque";
            const string MsgSpecialAbilityFourthCharacter = "Recupera 500 de vida a todos los heroes";

            /*Constantes con mensajes para el monstruo*/
            const string MsgMonsterStart = "Ahora toca el Monstruo. Introduce los valores requeridos: ";
            const string MsgHealthMonster = "Vida: [9000-12000]: ";
            const string MsgDamageMonster = "Ataque: [250-400]: ";
            const string MsgShieldMonster = "Reduccion de daño (valor porcentual) [20-30]%: ";
            const string MsgMonsterStartAttac = "El munstruo ataca a todos vuestros heroes:\n";

            /*Constante con mensaje para comienzo de batalla*/
            const string MsgStartBattle = "Comienza la batalla!\n";

            /*Constantes con mensajes en caso de Error*/
            const string MsgHealthCharacterError = "A introducido la vida no valida!\nPorfavor introduzca un valor dentro del rango.\n";
            const string MsgDamageCharacterError = "A introducido el daño de ataque no valido!\nPorfavor introduzca un valor dentro del rango.\n";
            const string MsgShieldCharacterError = "A introducido el porcentaje de escudo no valido!\nPorfavor introduzca un valor dentro del rango.\n";
            const string MsgSelectOptionError = "A introducido la opcion no valida!\nPorfavor introdzca una opcion existente\n";

            /*Variable entera para contar las rondas*/
            int rounds = 0;

            /*Constantes con mensajes de la batalla*/
            const string MsgSelectBattleOption = "\nSelecciona una accion:\n1 - Atacar\n2 - Defenderse\n3 - Utilizar habilidad especial\nTu seleccion: ";

            /*Variable entera para la eleccion de accion de batalla*/
            int selectBattleOption;

            /*Constantes con informacion de quien gano la partida y como*/
            const string MsgUserWin = "Habeis matado al montruo!\nEnhorabuena, has ganado!";

            /*Variable para comprobar si el jugador a vuelto a jugar o salio del programa*/
            int repeatGameChecker = 0;

            Console.WriteLine(MsgWelcome);

            Console.Write(MsgPlayOrExit);
            playOrExit = Convert.ToInt32(Console.ReadLine());

            while (playOrExit < 0 || playOrExit > 1)
            {
                Console.WriteLine(MsgSelectOptionError);

                Console.Write(MsgPlayOrExit);
                playOrExit = Convert.ToInt32(Console.ReadLine());
            }

            if (playOrExit == 0)
            {
                Console.WriteLine(MsgExitSelect);
            }

            /*Comprovacion de que si el usuario quiere jugar o salir*/
            while (playOrExit == 1)
            {
                Console.WriteLine(); /*Salto de linea*/

                Console.WriteLine(MsgPlaySelect);

                /*Arquera*/
                Console.WriteLine(MsgFirstCharacter);
                Console.Write(MsgHealthFirstCharacter);
                healthFirstCharacter = Convert.ToInt32(Console.ReadLine());
                while (healthFirstCharacter < 1500 || healthFirstCharacter > 2000)
                {
                    Console.Write(MsgHealthCharacterError + MsgHealthFirstCharacter);
                    healthFirstCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(MsgDamageFirstCharacter);
                damageFirstCharacter = Convert.ToInt32(Console.ReadLine());
                while (damageFirstCharacter < 180 || damageFirstCharacter > 300)
                {
                    Console.Write(MsgDamageCharacterError + MsgDamageFirstCharacter);
                    damageFirstCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(MsgShieldFirstCharacter);
                shieldFirstCharacter = Convert.ToInt32(Console.ReadLine());
                while (shieldFirstCharacter < 25 || shieldFirstCharacter > 40)
                {
                    Console.Write(MsgShieldCharacterError + MsgShieldFirstCharacter);
                    shieldFirstCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Habilidad Especial: " + MsgSpecialAbilityFirstCharacter);

                Console.WriteLine(); /*Salto de linea*/

                /*Barbaro*/
                Console.WriteLine(MsgSecondCharacter);
                Console.Write(MsgHealthSecondCharacter);
                healthSecondCharacter = Convert.ToInt32(Console.ReadLine());
                while (healthSecondCharacter < 3000 || healthSecondCharacter > 3750)
                {
                    Console.Write(MsgHealthCharacterError + MsgHealthSecondCharacter);
                    healthSecondCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(MsgDamageSecondCharacter);
                damageSecondCharacter = Convert.ToInt32(Console.ReadLine());
                while (damageSecondCharacter < 150 || damageSecondCharacter > 250)
                {
                    Console.Write(MsgDamageCharacterError + MsgDamageSecondCharacter);
                    damageSecondCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(MsgShieldSecondCharacter);
                shieldSecondCharacter = Convert.ToInt32(Console.ReadLine());
                while (shieldSecondCharacter < 35 || shieldSecondCharacter > 45)
                {
                    Console.Write(MsgShieldCharacterError + MsgShieldSecondCharacter);
                    shieldSecondCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Habilidad Especial: " + MsgSpecialAbilitySecondCharacter);

                Console.WriteLine(); /*Salto de linea*/

                /*Maga*/
                Console.WriteLine(MsgThirdCharacter);
                Console.Write(MsgHealthThirdCharacter);
                healthThirdCharacter = Convert.ToInt32(Console.ReadLine());
                while (healthThirdCharacter < 1000 || healthThirdCharacter > 1500)
                {
                    Console.Write(MsgHealthCharacterError + MsgHealthThirdCharacter);
                    healthThirdCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(MsgDamageThirdCharacter);
                damageThirdCharacter = Convert.ToInt32(Console.ReadLine());
                while (damageThirdCharacter < 300 || damageThirdCharacter > 350)
                {
                    Console.Write(MsgDamageCharacterError + MsgDamageThirdCharacter);
                    damageThirdCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(MsgShieldThirdCharacter);
                shieldThirdCharacter = Convert.ToInt32(Console.ReadLine());
                while (shieldThirdCharacter < 20 || shieldThirdCharacter > 35)
                {
                    Console.Write(MsgShieldCharacterError + MsgShieldThirdCharacter);
                    shieldThirdCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Habilidad Especial: " + MsgSpecialAbilityThirdCharacter);

                Console.WriteLine(); /*Salto de linea*/

                /*Druida*/
                Console.WriteLine(MsgFourthCharacter);
                Console.Write(MsgHealthFourthCharacter);
                healthFourthCharacter = Convert.ToInt32(Console.ReadLine());
                while (healthFourthCharacter < 2000 || healthFourthCharacter > 2500)
                {
                    Console.Write(MsgHealthCharacterError + MsgHealthFourthCharacter);
                    healthFourthCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(MsgDamageFourthCharacter);
                damageFourthCharacter = Convert.ToInt32(Console.ReadLine());
                while (damageFourthCharacter < 70 || damageFourthCharacter > 120)
                {
                    Console.Write(MsgDamageCharacterError + MsgDamageFourthCharacter);
                    damageFourthCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(MsgShieldFourthCharacter);
                shieldFourthCharacter = Convert.ToInt32(Console.ReadLine());
                while (shieldFourthCharacter < 25 || shieldFourthCharacter > 40)
                {
                    Console.Write(MsgShieldCharacterError + MsgShieldFourthCharacter);
                    shieldFourthCharacter = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Habilidad Especial: " + MsgSpecialAbilityFourthCharacter);

                Console.WriteLine(); /*Salto de linea*/

                /*Monstruo*/
                Console.WriteLine(MsgMonsterStart);
                Console.Write(MsgHealthMonster);
                healthMonster = Convert.ToInt32(Console.ReadLine());
                while (healthMonster < 9000 || healthMonster > 12000)
                {
                    Console.Write(MsgHealthCharacterError + MsgHealthMonster);
                    healthMonster = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(MsgDamageMonster);
                damageMonster = Convert.ToInt32(Console.ReadLine());
                while (damageMonster < 250 || damageMonster > 400)
                {
                    Console.Write(MsgDamageCharacterError + MsgDamageMonster);
                    damageMonster = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(MsgShieldMonster);
                shieldMonster = Convert.ToInt32(Console.ReadLine());
                while (shieldMonster < 20 || shieldMonster > 30)
                {
                    Console.Write(MsgShieldCharacterError + MsgShieldMonster);
                    shieldMonster = Convert.ToInt32(Console.ReadLine());
                }

                maxHealthFirstCharacter = healthFirstCharacter;
                maxHealthSecondCharacter = healthSecondCharacter;
                maxHealthThirdCharacter = healthThirdCharacter;
                maxHealthFourthCharacter = healthFourthCharacter;

                Console.WriteLine(); /*Salto de linea*/

                /*COMIENZO DE BATALLA*/

                Console.WriteLine(MsgStartBattle);

                while (healthMonster > 0 || (healthFirstCharacter > 0 && healthSecondCharacter > 0 && healthThirdCharacter > 0 && healthFourthCharacter > 0))
                {
                    if (repeatGameChecker > 0)
                    {
                        Console.WriteLine(MsgPlaySelect);

                        /*Arquera*/
                        Console.WriteLine(MsgFirstCharacter);
                        Console.Write(MsgHealthFirstCharacter);
                        healthFirstCharacter = Convert.ToInt32(Console.ReadLine());
                        while (healthFirstCharacter < 1500 || healthFirstCharacter > 2000)
                        {
                            Console.Write(MsgHealthCharacterError + MsgHealthFirstCharacter);
                            healthFirstCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write(MsgDamageFirstCharacter);
                        damageFirstCharacter = Convert.ToInt32(Console.ReadLine());
                        while (damageFirstCharacter < 180 || damageFirstCharacter > 300)
                        {
                            Console.Write(MsgDamageCharacterError + MsgDamageFirstCharacter);
                            damageFirstCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write(MsgShieldFirstCharacter);
                        shieldFirstCharacter = Convert.ToInt32(Console.ReadLine());
                        while (shieldFirstCharacter < 25 || shieldFirstCharacter > 40)
                        {
                            Console.Write(MsgShieldCharacterError + MsgShieldFirstCharacter);
                            shieldFirstCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Habilidad Especial: " + MsgSpecialAbilityFirstCharacter);

                        Console.WriteLine(); /*Salto de linea*/

                        /*Barbaro*/
                        Console.WriteLine(MsgSecondCharacter);
                        Console.Write(MsgHealthSecondCharacter);
                        healthSecondCharacter = Convert.ToInt32(Console.ReadLine());
                        while (healthSecondCharacter < 3000 || healthSecondCharacter > 3750)
                        {
                            Console.Write(MsgHealthCharacterError + MsgHealthSecondCharacter);
                            healthSecondCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write(MsgDamageSecondCharacter);
                        damageSecondCharacter = Convert.ToInt32(Console.ReadLine());
                        while (damageSecondCharacter < 150 || damageSecondCharacter > 250)
                        {
                            Console.Write(MsgDamageCharacterError + MsgDamageSecondCharacter);
                            damageSecondCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write(MsgShieldSecondCharacter);
                        shieldSecondCharacter = Convert.ToInt32(Console.ReadLine());
                        while (shieldSecondCharacter < 35 || shieldSecondCharacter > 45)
                        {
                            Console.Write(MsgShieldCharacterError + MsgShieldSecondCharacter);
                            shieldSecondCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Habilidad Especial: " + MsgSpecialAbilitySecondCharacter);

                        Console.WriteLine(); /*Salto de linea*/

                        /*Maga*/
                        Console.WriteLine(MsgThirdCharacter);
                        Console.Write(MsgHealthThirdCharacter);
                        healthThirdCharacter = Convert.ToInt32(Console.ReadLine());
                        while (healthThirdCharacter < 1000 || healthThirdCharacter > 1500)
                        {
                            Console.Write(MsgHealthCharacterError + MsgHealthThirdCharacter);
                            healthThirdCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write(MsgDamageThirdCharacter);
                        damageThirdCharacter = Convert.ToInt32(Console.ReadLine());
                        while (damageThirdCharacter < 300 || damageThirdCharacter > 350)
                        {
                            Console.Write(MsgDamageCharacterError + MsgDamageThirdCharacter);
                            damageThirdCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write(MsgShieldThirdCharacter);
                        shieldThirdCharacter = Convert.ToInt32(Console.ReadLine());
                        while (shieldThirdCharacter < 20 || shieldThirdCharacter > 35)
                        {
                            Console.Write(MsgShieldCharacterError + MsgShieldThirdCharacter);
                            shieldThirdCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Habilidad Especial: " + MsgSpecialAbilityThirdCharacter);

                        Console.WriteLine(); /*Salto de linea*/

                        /*Druida*/
                        Console.WriteLine(MsgFourthCharacter);
                        Console.Write(MsgHealthFourthCharacter);
                        healthFourthCharacter = Convert.ToInt32(Console.ReadLine());
                        while (healthFourthCharacter < 2000 || healthFourthCharacter > 2500)
                        {
                            Console.Write(MsgHealthCharacterError + MsgHealthFourthCharacter);
                            healthFourthCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write(MsgDamageFourthCharacter);
                        damageFourthCharacter = Convert.ToInt32(Console.ReadLine());
                        while (damageFourthCharacter < 70 || damageFourthCharacter > 120)
                        {
                            Console.Write(MsgDamageCharacterError + MsgDamageFourthCharacter);
                            damageFourthCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write(MsgShieldFourthCharacter);
                        shieldFourthCharacter = Convert.ToInt32(Console.ReadLine());
                        while (shieldFourthCharacter < 25 || shieldFourthCharacter > 40)
                        {
                            Console.Write(MsgShieldCharacterError + MsgShieldFourthCharacter);
                            shieldFourthCharacter = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Habilidad Especial: " + MsgSpecialAbilityFourthCharacter);

                        Console.WriteLine(); /*Salto de linea*/

                        /*Monstruo*/
                        Console.WriteLine(MsgMonsterStart);
                        Console.Write(MsgHealthMonster);
                        healthMonster = Convert.ToInt32(Console.ReadLine());
                        while (healthMonster < 9000 || healthMonster > 12000)
                        {
                            Console.Write(MsgHealthCharacterError + MsgHealthMonster);
                            healthMonster = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write(MsgDamageMonster);
                        damageMonster = Convert.ToInt32(Console.ReadLine());
                        while (damageMonster < 250 || damageMonster > 400)
                        {
                            Console.Write(MsgDamageCharacterError + MsgDamageMonster);
                            damageMonster = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write(MsgShieldMonster);
                        shieldMonster = Convert.ToInt32(Console.ReadLine());
                        while (shieldMonster < 20 || shieldMonster > 30)
                        {
                            Console.Write(MsgShieldCharacterError + MsgShieldMonster);
                            shieldMonster = Convert.ToInt32(Console.ReadLine());
                        }

                        maxHealthFirstCharacter = healthFirstCharacter;
                        maxHealthSecondCharacter = healthSecondCharacter;
                        maxHealthThirdCharacter = healthThirdCharacter;
                        maxHealthFourthCharacter = healthFourthCharacter;

                        Console.WriteLine(); /*Salto de linea*/

                        /*COMIENZO DE BATALLA*/

                        Console.WriteLine(MsgStartBattle);

                        repeatGameChecker = 0;
                    }

                    if (specialHabilityFirstCharacter == true)
                    {
                        specialHabilityFirstCharacterRoundsCounter++;
                    }

                    if (specialHabilitySecondCharacter == true)
                    {
                        specialHabilitySecondCharacterRoundsCounter++;
                    }

                    if (specialHabilityThirdCharacter == true)
                    {
                        specialHabilityThirdCharacterRoundsCounter++;
                    }

                    if (specialHabilityFourthCharacter == true)
                    {
                        specialHabilityFourthCharacterRoundsCounter++;
                    }

                    rounds++;

                    Console.WriteLine("Ronda " + rounds);

                    Console.WriteLine(); /*Salto de linea*/

                    /*Calculos de ataques de heroes al monstruo*/
                    int damageRecivedMonsterFromFirstCharacter = damageFirstCharacter - (damageFirstCharacter * shieldMonster / 100);
                    int damageRecivedMonsterFromSecondCharacter = damageSecondCharacter - (damageSecondCharacter * shieldMonster / 100);
                    int damageRecivedMonsterFromThirdCharacter = damageThirdCharacter - (damageThirdCharacter * shieldMonster / 100);
                    int damageRecivedMonsterFromThirdCharacterAfterUseSpecialHability = (damageThirdCharacter * 3) - (damageThirdCharacter * 3) * shieldMonster / 100;
                    int damageRecivedMonsterFromFourthCharacter = damageFourthCharacter - (damageFourthCharacter * shieldMonster / 100);

                    /*Calculos del escudo de heroes al recibir el daño de monstruo*/
                    int damageRecivedFirstCharacterFromMonster = damageMonster - (damageMonster * shieldFirstCharacter / 100);
                    int damageRecivedSecondCharacterFromMonster = damageMonster - (damageMonster * shieldSecondCharacter / 100);
                    int damageRecivedThirdCharacterFromMonster = damageMonster - (damageMonster * shieldThirdCharacter / 100);
                    int damageRecivedFourthCharacterFromMonster = damageMonster - (damageMonster * shieldFourthCharacter / 100);

                    /*Calculos de las habilidades especiales*/


                    /*Seleccion de opciones para Arquera*/
                    if (healthMonster > 0)
                    {
                        if (healthFirstCharacter > 0)
                        {
                            Console.Write("Arquera\n" + MsgSelectBattleOption);
                            selectBattleOption = Convert.ToInt32(Console.ReadLine());

                            while (selectBattleOption < 1 || selectBattleOption > 3)
                            {
                                Console.WriteLine(MsgSelectOptionError);
                                Console.Write("Arquera\n" + MsgSelectBattleOption);
                                selectBattleOption = Convert.ToInt32(Console.ReadLine());
                            }

                            while (selectBattleOption == 1 || selectBattleOption == 2 || selectBattleOption == 3)
                            {
                                if (selectBattleOption == 1)
                                {
                                    Console.WriteLine("Arquera ataca a monstruo con " + damageFirstCharacter + " de daño.\nEl monstruo se defiende y recibe " + damageRecivedMonsterFromFirstCharacter + " de daño. \nVida del Monstruo: " + (healthMonster -= damageRecivedMonsterFromFirstCharacter));
                                    Console.WriteLine(); /*Salto de linea*/
                                    if (healthMonster <= 0)
                                    {
                                        Console.WriteLine(MsgUserWin);
                                        break;
                                    }
                                    selectBattleOption = 0;
                                }

                                else if (selectBattleOption == 2)
                                {
                                    Console.WriteLine("Arquera se protege del monstruo y duplica su defensa en el ataque del monstruo\n");
                                    selectBattleOption = 0;
                                }

                                else if (selectBattleOption == 3)
                                {
                                    if (specialHabilityFirstCharacterRoundsCounter == 0)
                                    {
                                        Console.WriteLine("Arquera utiliza su habilidad especial y noquea al monstruo durante 2 turnos!\n");
                                        specialHabilityFirstCharacter = true;
                                        selectBattleOption = 0;
                                    }
                                    else
                                    {
                                        while (selectBattleOption == 3)
                                        {

                                            Console.WriteLine("No puede utilizar la habilidad especial durante 5 rondas despues de usarla\n");
                                            Console.Write("Arquera\n" + MsgSelectBattleOption);
                                            selectBattleOption = Convert.ToInt32(Console.ReadLine());
                                        }
                                    }
                                }
                            }
                        }
                    }

                    /*Seleccion de opciones para Barbaro*/
                    if (healthMonster > 0)
                    {
                        if (healthSecondCharacter > 0)
                        {
                            Console.Write("Barbaro\n" + MsgSelectBattleOption);
                            selectBattleOption = Convert.ToInt32(Console.ReadLine());

                            while (selectBattleOption < 1 || selectBattleOption > 3)
                            {
                                Console.WriteLine(MsgSelectOptionError);
                                Console.Write("Barbaro\n" + MsgSelectBattleOption);
                                selectBattleOption = Convert.ToInt32(Console.ReadLine());
                            }

                            while (selectBattleOption == 1 || selectBattleOption == 2 || selectBattleOption == 3)
                            {
                                if (selectBattleOption == 1)
                                {
                                    Console.WriteLine("Barbaro ataca a monstruo con " + damageSecondCharacter + " de daño.\nEl monstruo se defiende y recibe " + damageRecivedMonsterFromSecondCharacter + " de daño. \nVida del Monstruo: " + (healthMonster -= damageRecivedMonsterFromSecondCharacter));
                                    Console.WriteLine(); /*Salto de linea*/
                                    if (healthMonster <= 0)
                                    {
                                        Console.WriteLine(MsgUserWin);
                                        break;
                                    }
                                    selectBattleOption = 0;
                                }

                                else if (selectBattleOption == 2)
                                {
                                    Console.WriteLine("Barbaro se protege del monstruo y duplica su defensa en el ataque del monstruo\n");
                                    selectBattleOption = 0;
                                }

                                else if (selectBattleOption == 3)
                                {
                                    if (specialHabilitySecondCharacterRoundsCounter == 0)
                                    {
                                        Console.WriteLine("Barbaro utiliza su habilidad especial y aumenta su defensa al 100% durante 3 rondas!\n");
                                        specialHabilitySecondCharacter = true;
                                        selectBattleOption = 0;
                                    }
                                    else
                                    {
                                        while (selectBattleOption == 3)
                                        {

                                            Console.WriteLine("No puede utilizar la habilidad especial durante 5 rondas despues de usarla\n");
                                            Console.Write("Barbaro\n" + MsgSelectBattleOption);
                                            selectBattleOption = Convert.ToInt32(Console.ReadLine());
                                        }
                                    }
                                }
                            }
                        }
                    }

                    /*Seleccion de opciones para Maga*/
                    if (healthMonster > 0)
                    {
                        if (healthThirdCharacter > 0)
                        {
                            Console.Write("Maga\n" + MsgSelectBattleOption);
                            selectBattleOption = Convert.ToInt32(Console.ReadLine());

                            while (selectBattleOption < 1 || selectBattleOption > 3)
                            {
                                Console.WriteLine(MsgSelectOptionError);
                                Console.Write("Maga\n" + MsgSelectBattleOption);
                                selectBattleOption = Convert.ToInt32(Console.ReadLine());
                            }

                            while (selectBattleOption == 1 || selectBattleOption == 2 || selectBattleOption == 3)
                            {
                                if (selectBattleOption == 1)
                                {
                                    Console.WriteLine("Maga ataca a monstruo con " + damageThirdCharacter + " de daño.\nEl monstruo se defiende y recibe " + damageRecivedMonsterFromThirdCharacter + " de daño. \nVida del Monstruo: " + (healthMonster -= damageRecivedMonsterFromThirdCharacter));
                                    Console.WriteLine(); /*Salto de linea*/
                                    if (healthMonster <= 0)
                                    {
                                        Console.WriteLine(MsgUserWin);
                                        break;
                                    }
                                    selectBattleOption = 0;
                                }

                                else if (selectBattleOption == 2)
                                {
                                    Console.WriteLine("Maga se protege del monstruo y duplica su defensa en el ataque del monstruo\n");
                                    selectBattleOption = 0;
                                }

                                else if (selectBattleOption == 3)
                                {
                                    if (specialHabilityThirdCharacterRoundsCounter == 0)
                                    {
                                        Console.WriteLine("Maga utiliza su habilidad especial y dispara una bola de fuego con " + damageThirdCharacter * 3 + " de daño.\nEl monstruo se defiende y recibe " + damageRecivedMonsterFromThirdCharacterAfterUseSpecialHability + " de daño.\nVida del Monstruo: " + (healthMonster -= damageRecivedMonsterFromThirdCharacterAfterUseSpecialHability));
                                        Console.WriteLine(); /*Salto de linea*/
                                        if (healthMonster <= 0)
                                        {
                                            Console.WriteLine(MsgUserWin);
                                            break;
                                        }
                                        specialHabilityThirdCharacter = true;
                                        selectBattleOption = 0;
                                    }
                                    else
                                    {
                                        while (selectBattleOption == 3)
                                        {

                                            Console.WriteLine("No puede utilizar la habilidad especial durante 5 rondas despues de usarla\n");
                                            Console.Write("Maga\n" + MsgSelectBattleOption);
                                            selectBattleOption = Convert.ToInt32(Console.ReadLine());
                                        }
                                    }
                                }
                            }
                        }
                    }

                    /*Seleccion de opciones para Druida*/
                    if (healthMonster > 0)
                    {
                        if (healthFourthCharacter > 0)
                        {
                            Console.Write("Druida\n" + MsgSelectBattleOption);
                            selectBattleOption = Convert.ToInt32(Console.ReadLine());

                            while (selectBattleOption < 1 || selectBattleOption > 3)
                            {
                                Console.WriteLine(MsgSelectOptionError);
                                Console.Write("Druida\n" + MsgSelectBattleOption);
                                selectBattleOption = Convert.ToInt32(Console.ReadLine());
                            }

                            while (selectBattleOption == 1 || selectBattleOption == 2 || selectBattleOption == 3)
                            {
                                if (selectBattleOption == 1)
                                {
                                    Console.WriteLine("Druida ataca a monstruo con " + damageFourthCharacter + " de daño.\nEl monstruo se defiende y recibe " + damageRecivedMonsterFromFourthCharacter + " de daño. \nVida del Monstruo: " + (healthMonster -= damageRecivedMonsterFromFourthCharacter));
                                    Console.WriteLine(); /*Salto de linea*/
                                    if (healthMonster <= 0)
                                    {
                                        Console.WriteLine(MsgUserWin);
                                        break;
                                    }
                                    selectBattleOption = 0;
                                }

                                else if (selectBattleOption == 2)
                                {
                                    Console.WriteLine("Druida se protege del monstruo y duplica su defensa en el ataque del monstruo\n");
                                    selectBattleOption = 0;
                                }

                                else if (selectBattleOption == 3)
                                {
                                    if (specialHabilityFourthCharacterRoundsCounter == 0)
                                    {
                                        Console.WriteLine("Druida utiliza su habilidad especial y cura 500 de vida a todos los heroes!");
                                        Console.WriteLine(); /*Salto de linea*/
                                        if (healthFirstCharacter < maxHealthFirstCharacter && healthFirstCharacter > 0)
                                        {
                                            healthFirstCharacter += 500;

                                            while (healthFirstCharacter > maxHealthFirstCharacter)
                                            {
                                                healthFirstCharacter--;
                                            }
                                        }

                                        if (healthSecondCharacter < maxHealthSecondCharacter && healthSecondCharacter > 0)
                                        {
                                            healthSecondCharacter += 500;

                                            while (healthSecondCharacter > maxHealthSecondCharacter)
                                            {
                                                healthSecondCharacter--;
                                            }
                                        }

                                        if (healthThirdCharacter < maxHealthThirdCharacter && healthThirdCharacter > 0)
                                        {
                                            healthThirdCharacter += 500;

                                            while (healthThirdCharacter > maxHealthThirdCharacter)
                                            {
                                                healthThirdCharacter--;
                                            }
                                        }

                                        if (healthFourthCharacter < maxHealthFourthCharacter && healthFourthCharacter > 0)
                                        {
                                            healthFourthCharacter += 500;

                                            while (healthFourthCharacter > maxHealthFourthCharacter)
                                            {
                                                healthFourthCharacter--;
                                            }
                                        }
                                        specialHabilityFourthCharacter = true;
                                        selectBattleOption = 0;
                                    }
                                    else
                                    {
                                        while (selectBattleOption == 3)
                                        {

                                            Console.WriteLine("No puede utilizar la habilidad especial durante 5 rondas despues de usarla\n");
                                            Console.Write("Druida\n" + MsgSelectBattleOption);
                                            selectBattleOption = Convert.ToInt32(Console.ReadLine());
                                        }
                                    }
                                }
                            }
                        }
                    }

                    /*Operaciones if para que la vida de los heroes no baje de 0*/
                    if (healthFirstCharacter < 0)
                    {
                        healthFirstCharacter = 0;
                    }
                    if (healthSecondCharacter < 0)
                    {
                        healthSecondCharacter = 0;
                    }
                    if (healthThirdCharacter < 0)
                    {
                        healthThirdCharacter = 0;
                    }
                    if (healthFourthCharacter < 0)
                    {
                        healthFourthCharacter = 0;
                    }


                    /*Comprobacion de que han pasado dos rondas para que el monstruo siga atacando*/
                    if (specialHabilityFirstCharacterRoundsCounter >= 2)
                    {
                        specialHabilityFirstCharacter = false;

                        specialHabilityFirstCharacterRoundsCounter++;

                        if (specialHabilityFirstCharacterRoundsCounter == 5)
                        {
                            specialHabilityFirstCharacterRoundsCounter = 0;
                        }
                    }

                    /*Comprobacion de que han pasado 3 rondas para que la habilidad del barbaro pare*/
                    if (specialHabilitySecondCharacterRoundsCounter >= 3)
                    {
                        specialHabilitySecondCharacter = false;

                        specialHabilitySecondCharacterRoundsCounter++;

                        if (specialHabilitySecondCharacterRoundsCounter == 5)
                        {
                            specialHabilitySecondCharacterRoundsCounter = 0;
                        }
                    }

                    /*Comprobacion de que ha pasado mas de una ronda para que la habilidad de la maga pare*/
                    if (specialHabilityThirdCharacterRoundsCounter > 1)
                    {
                        specialHabilityThirdCharacter = false;

                        specialHabilityThirdCharacterRoundsCounter++;

                        if (specialHabilityThirdCharacterRoundsCounter == 5)
                        {
                            specialHabilityThirdCharacterRoundsCounter = 0;
                        }
                    }

                    /*Comprobacion de que ha pasado mas de una ronda para que la habilidad del druida pare*/
                    if (specialHabilityFourthCharacterRoundsCounter > 1)
                    {
                        specialHabilityFourthCharacter = false;

                        specialHabilityFourthCharacterRoundsCounter++;

                        if (specialHabilityFourthCharacterRoundsCounter == 5)
                        {
                            specialHabilityFourthCharacterRoundsCounter = 0;
                        }
                    }

                    /*Informacion de los daños recebidos por el monstruo*/
                    if (healthMonster > 0)
                    {
                        if (specialHabilityFirstCharacter == false)
                        {
                            Console.WriteLine(MsgMonsterStartAttac);

                            Console.Write("El Monstruo ataca a la Arquera con " + damageMonster + " de daño.\nArquera se defiende y recibe " + damageRecivedFirstCharacterFromMonster + " de daño\nVida de la Arquera: ");
                            if (healthFirstCharacter <= 0)
                            {
                                healthFirstCharacter = 0;
                                Console.Write(healthFirstCharacter);
                            }
                            else
                            {
                                Console.Write(healthFirstCharacter -= damageRecivedFirstCharacterFromMonster);
                            }

                            Console.WriteLine(); /*Salto de linea*/

                            if (specialHabilitySecondCharacter == true)
                            {
                                Console.Write("El Monstruo ataca al Barbaro con " + damageMonster + " de daño.\nBarbaro se defiende y recibe " + 0 + " de daño\nVida del Barbaro: ");
                                if (healthSecondCharacter <= 0)
                                {
                                    healthSecondCharacter = 0;
                                    Console.Write(healthSecondCharacter);
                                }
                                else
                                {
                                    Console.Write(healthSecondCharacter);
                                }

                            }
                            else
                            {
                                Console.Write("El Monstruo ataca al Barbaro con " + damageMonster + " de daño.\nBarbaro se defiende y recibe " + damageRecivedSecondCharacterFromMonster + " de daño\nVida del Barbaro: ");
                                if (healthSecondCharacter <= 0)
                                {
                                    healthSecondCharacter = 0;
                                    Console.Write(healthSecondCharacter);
                                }
                                else
                                {
                                    Console.Write(healthSecondCharacter -= damageRecivedSecondCharacterFromMonster);
                                }
                            }

                            Console.WriteLine(); /*Salto de linea*/

                            Console.Write("El Monstruo ataca a la Maga con " + damageMonster + " de daño.\nMaga se defiende y recibe " + damageRecivedThirdCharacterFromMonster + " de daño\nVida de la Maga: ");
                            if (healthThirdCharacter <= 0)
                            {
                                healthThirdCharacter = 0;
                                Console.Write(healthThirdCharacter);
                            }
                            else
                            {
                                Console.Write(healthThirdCharacter -= damageRecivedThirdCharacterFromMonster);
                            }

                            Console.WriteLine(); /*Salto de linea*/

                            Console.Write("El Monstruo ataca al Druida con " + damageMonster + " de daño.\nDruida se defiende y recibe " + damageRecivedFourthCharacterFromMonster + " de daño\nVida del Druida: ");
                            if (healthFourthCharacter <= 0)
                            {
                                healthFourthCharacter = 0;
                                Console.Write(healthFourthCharacter);
                            }
                            else
                            {
                                Console.Write(healthFourthCharacter -= damageRecivedFourthCharacterFromMonster);
                            }

                            Console.WriteLine(); /*Salto de linea*/

                        }
                    }

                    Console.WriteLine(); /*Salto de linea*/

                    /*FINAL DE LA RONDA*/


                    /*FINAL DE LA PARTIDA*/

                    /*Pregunta si el usuario quiere volver a jugar*/
                    if (healthMonster <= 0 || (healthFirstCharacter <= 0 && healthSecondCharacter <= 0 && healthThirdCharacter <= 0 && healthFourthCharacter <= 0))
                    {
                        Console.WriteLine(); /*Salto de linea*/

                        Console.Write(MsgPlayOrExit);
                        playOrExit = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(); /*Salto de linea*/

                        while (playOrExit < 0 || playOrExit > 1)
                        {
                            Console.WriteLine(MsgSelectOptionError);

                            Console.Write(MsgPlayOrExit);
                            playOrExit = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(); /*Salto de linea*/
                        }

                        if (playOrExit == 1)
                        {
                            rounds = 0;
                            repeatGameChecker++;
                        }
                        else
                        {
                            Console.WriteLine(MsgExitSelect);
                            playOrExit = 0;
                        }
                    }
                }
            }
        }
    }
}