Console.WriteLine("INSTALACIONES ELECTRICAS");
Console.WriteLine();

int opcion;

do
{
    Console.WriteLine("1. Ley De Ohm");
    Console.WriteLine("2. Calcular De Caida De Tension");
    Console.WriteLine("3. Conversion Entre Unidades");
    Console.WriteLine("4. Calculo Para Circuitos Monofasicos");
    Console.WriteLine("5. Calculo De Circuitos Derivados Y Alinmentadores");
    Console.WriteLine("6. Tabla De Calibres De Conductores");
    Console.WriteLine("7. Tabla De Area De Conductores Segun Calibre");
    Console.WriteLine("8. Tabla De Tamaños De Tuberia Conduit");
    Console.WriteLine("0. Salir Del Programa");
    Console.WriteLine();

    Console.Write("Seleccione Una Opcion:");
    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    { 
        case 1:
        {
                Console.Clear();

                int leyOhm;
                int continuar;

                do
                {

                    Console.WriteLine("LEY DE OHM");
                    Console.WriteLine();

                    Console.WriteLine("1. CALCULAR VOLTAJE/TENSION (V)");
                    Console.WriteLine("2. CALCULAR AMPERAJE/CORRIENTE (I)");
                    Console.WriteLine("3. CALCULAR RESISTENCIA (R)");
                    Console.WriteLine("4. CALCULAR POTENCIA (W)");
                    Console.WriteLine("0. MENU PRINCIPAL");
                    Console.WriteLine();

                    Console.Write("Seleccione una opcion: ");
                    leyOhm = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (leyOhm)
                    {
                        case 1:
                            {
                                Console.Clear();

                                Console.WriteLine("CALCULAR VOLTAJE/TENSION (V)");
                                Console.WriteLine();

                                double corriente;
                                double resistencia;
                                double voltaje;

                                Console.Write("Ingrese la corriente: ");
                                while (!double.TryParse(Console.ReadLine(), out corriente))
                                {
                                    Console.WriteLine("Error: Solo se permite valores numericos");
                                    Console.Write("Ingrese la corriente: ");
                                }

                                Console.Write("Ingrese la resistencia: ");
                                while (!double.TryParse(Console.ReadLine(), out resistencia))
                                {
                                    Console.WriteLine("ERROR: Solo se permite valores numericos");
                                    Console.Write("Ingrese la resistencia: ");
                                }

                                voltaje = corriente * resistencia;
                                Console.WriteLine();
                                Console.Write($"El voltaje es: {voltaje:F2} V");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("1.Realizar otro calculo");
                                Console.WriteLine("0.Menu Principal");
                                Console.WriteLine();

                                Console.Write("Seleccione una opcion: ");
                                continuar = int.Parse(Console.ReadLine());
                                if (continuar == 0)
                                {
                                    leyOhm = 0;
                                }
                            }
                            break;

                        case 2:
                            {
                                Console.Clear();

                                Console.WriteLine("CALCULAR AMPERAJE/CORRIENTE (A)");
                                Console.WriteLine();

                                double voltaje;
                                double resistencia;
                                double corriente;

                                Console.Write("Ingrese el voltaje: ");
                                while (!double.TryParse(Console.ReadLine(), out voltaje))
                                {
                                    Console.WriteLine("Error: Solo se permite valores numericos");
                                    Console.Write("Ingrese el voltaje: ");
                                }

                                Console.Write("Ingrese la resistencia: ");
                                while (!double.TryParse(Console.ReadLine(), out resistencia))
                                {
                                    Console.WriteLine("Error: Solo se permite valores numericos");
                                    Console.Write("Ingrese la resistencia: ");
                                }

                                if (resistencia == 0)
                                {
                                    Console.WriteLine("Error: La resistencia no puede ser 0");
                                }
                                else
                                {
                                    corriente = voltaje / resistencia;

                                    Console.WriteLine();
                                    Console.WriteLine($"La corriente es: {corriente:F2} A");
                                }

                                Console.WriteLine();
                                Console.WriteLine("1.Realizar otro calculo");
                                Console.WriteLine("0.Menu Principal");
                                Console.WriteLine();

                                Console.Write("Seleccione una opcion: ");
                                continuar = int.Parse(Console.ReadLine());
                                if (continuar == 0)
                                {
                                    leyOhm = 0;
                                }

                            }
                            break;

                        case 3:
                            {
                                Console.Clear();

                                Console.WriteLine("CALCULAR RESISTENCIA (R)");
                                Console.WriteLine();

                                double voltaje;
                                double corriente;
                                double resistencia;

                                Console.Write("Ingrese el voltaje: ");
                                while (!double.TryParse(Console.ReadLine(), out voltaje))
                                {
                                    Console.WriteLine("Error: Solo se permite valores numericos");
                                    Console.Write("Ingrese el voltaje: ");
                                }

                                Console.Write("Ingrese la corriente: ");
                                while (!double.TryParse(Console.ReadLine(), out corriente))
                                {
                                    Console.WriteLine("Error: Solo se permite valores numericos");
                                    Console.Write("Ingrese la corriente: ");
                                }

                                if (corriente == 0)
                                {
                                    Console.WriteLine("Error: La corriente no puede ser 0");
                                }
                                else
                                {
                                     resistencia = voltaje / corriente;

                                    Console.WriteLine();
                                    Console.WriteLine($"La resistencia es: {resistencia:F2} Ω");
                                }

                                    Console.WriteLine();
                                Console.WriteLine("1.Realizar otro calculo");
                                Console.WriteLine("0.Menu Principal");
                                Console.WriteLine();

                                Console.Write("Seleccione una opcion: ");
                                continuar = int.Parse(Console.ReadLine());
                                if (continuar == 0)
                                {
                                    leyOhm = 0;
                                }

                            }
                            break;

                        case 4:
                            {
                                Console.Clear();

                                Console.WriteLine("CALCULAR POTENCIA (W)");
                                Console.WriteLine();

                                double voltaje;
                                double corriente;
                                double potencia;

                                Console.Write("Ingrese el voltaje: ");
                                while (!double.TryParse(Console.ReadLine(), out voltaje))
                                {
                                    Console.WriteLine("Error: Solo se permite valores numericos");
                                    Console.Write("Ingrese el voltaje: ");
                                }

                                Console.Write("Ingrese la corriente: ");
                                while (!double.TryParse(Console.ReadLine(), out corriente))
                                {
                                    Console.WriteLine("Error: Solo se permite valores numericos");
                                    Console.Write("Ingrese la corriente: ");
                                }

                                potencia = voltaje * corriente;
                                Console.WriteLine();
                                Console.Write($"La potencia es: {potencia:F2} W");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("1.Realizar otro calculo");
                                Console.WriteLine("0.Menu Principal");
                                Console.WriteLine();

                                Console.Write("Seleccione una opcion: ");
                                continuar = int.Parse(Console.ReadLine());
                                if (continuar == 0)
                                {
                                    leyOhm = 0;
                                }


                            }
                        break;

                        case 0:
                            {
                                Console.Clear();
                                Console.WriteLine("REGRESANDO AL MENU PRINCIPAL...");

                            }
                        break;
                            

                        default:
                            {
                                Console.WriteLine("OPCION INGRESADA NO VALIDA");
                            }
                            break;
                    }

                } while (leyOhm != 0);


        }
        break;

        case 2:
        {
                Console.Clear();
                int continuar;

             do
             {
                Console.WriteLine("CALCULAR CAIDA DE TENSION");
                Console.WriteLine();

                double resistividad;
                double longitud;
                double corriente;
                double area;
                double caidaTension;
                double voltaje;
                double porcentaje;
                double limite;
                int material;
                int tipoCircuito;
                int calibre;

                Console.WriteLine("Material del conductor");
                Console.WriteLine("1. ALUMINIO");
                Console.WriteLine("2. COBRE");
                Console.WriteLine();
                Console.Write("Seleccione una opcion: ");
                material = int.Parse(Console.ReadLine());

                if(material == 1)
                {
                    resistividad = 0.0282;
                }
                else
                {
                    resistividad = 0.0175;
                }

                Console.Write("Ingrese el voltaje del circuito: ");
                voltaje = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la longitud de ida y vuelta en metros: ");
                longitud = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la corriente: ");
                corriente = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("CALIBRE DEL CONDUCTOR");
                Console.WriteLine("1. #14 AWG");
                Console.WriteLine("2. #12 AWG");
                Console.WriteLine("3. #10 AWG");
                Console.WriteLine("4. #8 AWG");
                Console.WriteLine("5. #6 AWG");
                Console.WriteLine();

                Console.Write("Seleccione un calibre: ");
                calibre = int.Parse(Console.ReadLine());
                    switch (calibre)
                    {
                        case 1:
                            area = 2.082;
                            break;

                        case 2:
                            area = 3.307;
                            break;

                        case 3:
                            area = 5.260;
                            break;

                        case 4:
                            area = 8.367;
                            break;

                        case 5:
                            area = 13.300;
                            break;

                        default:
                            area = 0;
                            break;
                    }

                    caidaTension = (resistividad * longitud * corriente) / area;
                porcentaje = (caidaTension / voltaje) * 100;
                Console.WriteLine();
                Console.WriteLine("Tipo de circuito");
                Console.WriteLine("1. Circuito Derivado, Maximo 3%");
                Console.WriteLine("2. Tablero principal a carga final, Maximo 5%");
                Console.WriteLine();
                Console.Write("Seleccione el tipo de circuito: ");
                tipoCircuito = int.Parse(Console.ReadLine());
                if (tipoCircuito == 1)
                {
                    limite = 3;
                }
                else
                {
                    limite = 5;
                }

                Console.WriteLine();
                Console.WriteLine($"La caida de tension es: {caidaTension:F2} V");
                Console.WriteLine($"El porcentaje de caida es: {porcentaje:F2} %");
                Console.WriteLine($"El limite permitido es: {limite} %");
                Console.WriteLine();

                if (porcentaje <= limite)
                {
                    Console.WriteLine("Si cumple");
                }
                else
                {
                    Console.WriteLine("No cumple");
                }

                Console.WriteLine();
                Console.WriteLine("1. Realizar otro calculo");
                Console.WriteLine("0. Menu principal");
                Console.WriteLine();

                Console.Write("Seleccione una opcion: ");
                continuar = int.Parse(Console.ReadLine());


             }while (continuar != 0);

        }
        break;

        case 3:
        {
                Console.Clear();

                Console.WriteLine("CONVERSION ENTRE UNIDADES");
                Console.WriteLine();

        }
        break;

        case 4:
        {
                Console.Clear();

                Console.WriteLine("CALCULO PARA CIRCUITOS MONOFASICOS");
                Console.WriteLine();

        }
        break;

        case 5:
        {
                Console.Clear();

                Console.WriteLine("cALCULO DE CIRCUITOS DERIVADOS Y ALIMENTADORES");
                Console.WriteLine();

        }
        break;

        case 6:
        {
                Console.Clear();

                Console.WriteLine("TABLA DE CALIBRES DE CONDUCTORES");
                Console.WriteLine();

                Console.WriteLine("CALIBRE");
                Console.WriteLine("#14");
                Console.WriteLine("#12");
                Console.WriteLine("#10");
                Console.WriteLine("#8");
                Console.WriteLine("#6");
                Console.WriteLine("#4");
                Console.WriteLine("#2");
                Console.WriteLine("#1/0");
                Console.WriteLine("#2/0");
                Console.WriteLine("#3/0");
                Console.WriteLine("#4/0");

                Console.WriteLine();
                Console.WriteLine("Presione una tecla para volver al menu principal");
                Console.WriteLine();

            }
        break;

        case 7:
        {
                Console.Clear();

                Console.WriteLine("TABLA DE AREA DE CONDUCTORES SEGUN CALIBRE");
                Console.WriteLine();

                Console.WriteLine("CALIBRE         AREA mm²");
                Console.WriteLine("#14 AWG         2.082");
                Console.WriteLine("#12 AWG         3.307");
                Console.WriteLine("#10 AWG         5.260");
                Console.WriteLine("#08 AWG         8.367");
                Console.WriteLine("#06 AWG         13.300");

                Console.WriteLine();
                Console.WriteLine("Presione una tecla para regresar al menu principal");
                Console.ReadKey();

        }
        break;

        case 8:
        {
                Console.Clear();

                Console.WriteLine("TABLA DE TAMAÑOS DE TUBERIA CONDUIT");
                Console.WriteLine();

        }
        break;

        case 0:
        {
                Console.Clear();

                Console.WriteLine("Saliendo del programa...");
        }
        break;

        default:
        {
            Console.WriteLine("Opcion Seleccionada No valida");
            Console.WriteLine();
        }
        break;

    }




} while (opcion != 0);

Console.WriteLine($"La opcion ({opcion}) corto el proceso y salio de la ejecucion");

Console.ReadKey();
Console.Clear();

