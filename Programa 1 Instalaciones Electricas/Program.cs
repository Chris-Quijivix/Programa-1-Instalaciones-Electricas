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
    Console.WriteLine("8. Tamaños de tuberia Conduit");
    Console.WriteLine("0. Salir Del Programa");
    Console.WriteLine();

    do
    {
        Console.Write("Seleccione Una Opcion: ");

        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Error: Ingrese un numero del 0 al 8.");
            opcion = -1;
        }
        else if (opcion < 0 || opcion > 8)
        {
            Console.WriteLine("Opcion no valida. Seleccione una opcion del 0 al 8.");
        }

    } while (opcion < 0 || opcion > 8);

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

                    do
                    {
                        Console.Write("Seleccione una opcion: ");

                        if (!int.TryParse(Console.ReadLine(), out leyOhm))
                        {
                            Console.WriteLine("Error: Ingrese un numero del 0 al 4.");
                            leyOhm = -1;
                        }
                        else if (leyOhm < 0 || leyOhm > 4)
                        {
                            Console.WriteLine("Opcion no valida. Seleccione una opcion del 0 al 4.");
                        }

                    } while (leyOhm < 0 || leyOhm > 4);

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
                                while (!double.TryParse(Console.ReadLine(), out corriente) || corriente < 0)
                                {
                                    Console.WriteLine("Error: Ingrese un valor igual o mayor que 0.");
                                    Console.Write("Ingrese la corriente: ");
                                }

                                Console.Write("Ingrese la resistencia: ");
                                while (!double.TryParse(Console.ReadLine(), out resistencia) || resistencia < 0)
                                {
                                    Console.WriteLine("Error: Ingrese un valor igual o mayor que 0.");
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

                                do
                                {
                                    Console.Write("Seleccione una opcion: ");

                                    if (!int.TryParse(Console.ReadLine(), out continuar))
                                    {
                                        Console.WriteLine("Error: Ingrese 1 o 0.");
                                        continuar = -1;
                                    }
                                    else if (continuar != 0 && continuar != 1)
                                    {
                                        Console.WriteLine("Opcion no valida. Ingrese 1 o 0.");
                                    }

                                } while (continuar != 0 && continuar != 1);
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
                                while (!double.TryParse(Console.ReadLine(), out voltaje) || voltaje <= 0)
                                {
                                    Console.WriteLine("Error: Ingrese un valor mayor que 0.");
                                    Console.Write("Ingrese el voltaje: ");
                                }

                                Console.Write("Ingrese la resistencia: ");
                                while (!double.TryParse(Console.ReadLine(), out resistencia) || resistencia <= 0)
                                {
                                    Console.WriteLine("Error: Ingrese un valor mayor que 0.");
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

                                do
                                {
                                    Console.Write("Seleccione una opcion: ");
                                    continuar = int.Parse(Console.ReadLine());

                                    if (continuar != 0 && continuar != 1)
                                    {
                                        Console.WriteLine("Opcion no valida. Ingrese 1 o 0.");
                                    }

                                } while (continuar != 0 && continuar != 1);

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
                                while (!double.TryParse(Console.ReadLine(), out voltaje) || voltaje <= 0)
                                {
                                    Console.WriteLine("Error: Ingrese un valor mayor que 0.");
                                    Console.Write("Ingrese el voltaje: ");
                                }

                                Console.Write("Ingrese la corriente: ");
                                while (!double.TryParse(Console.ReadLine(), out corriente) || corriente <= 0)
                                {
                                    Console.WriteLine("Error: Ingrese un valor mayor que 0.");
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

                                do
                                {
                                    Console.Write("Seleccione una opcion: ");

                                    if (!int.TryParse(Console.ReadLine(), out continuar))
                                    {
                                        Console.WriteLine("Error: Ingrese 1 o 0.");
                                        continuar = -1;
                                    }
                                    else if (continuar != 0 && continuar != 1)
                                    {
                                        Console.WriteLine("Opcion no valida. Ingrese 1 o 0.");
                                    }

                                } while (continuar != 0 && continuar != 1);

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
                                while (!double.TryParse(Console.ReadLine(), out voltaje) || voltaje <= 0)
                                {
                                    Console.WriteLine("Error: Ingrese un valor mayor que 0.");
                                    Console.Write("Ingrese el voltaje: ");
                                }

                                Console.Write("Ingrese la corriente: ");
                                while (!double.TryParse(Console.ReadLine(), out corriente) || corriente < 0)
                                {
                                    Console.WriteLine("Error: Ingrese un valor igual o mayor que 0.");
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

                                do
                                {
                                    Console.Write("Seleccione una opcion: ");

                                    if (!int.TryParse(Console.ReadLine(), out continuar))
                                    {
                                        Console.WriteLine("Error: Ingrese 1 o 0.");
                                        continuar = -1;
                                    }
                                    else if (continuar != 0 && continuar != 1)
                                    {
                                        Console.WriteLine("Opcion no valida. Ingrese 1 o 0.");
                                    }

                                } while (continuar != 0 && continuar != 1);
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
                string nombreCalibre;
                int calibreRecomendar;
                bool encontrarCalibre = false;

                Console.WriteLine("Material del conductor");
                Console.WriteLine("1. ALUMINIO");
                Console.WriteLine("2. COBRE");
                Console.WriteLine();

                    do
                    {
                        Console.Write("Seleccione una opcion: ");
                        material = int.Parse(Console.ReadLine());

                        if (material < 1 || material > 2)
                        {
                            Console.WriteLine("Opcion no valida. Seleccione 1 o 2.");
                        }

                    } while (material < 1 || material > 2);

                    if (material == 1)
                    {
                        resistividad = 0.0282;
                    }
                    else
                    {
                        resistividad = 0.0175;
                    }

                    do
                    {
                        Console.Write("Ingrese el voltaje del circuito: ");

                        if (!double.TryParse(Console.ReadLine(), out voltaje))
                        {
                            Console.WriteLine("Error: Ingrese un valor numerico.");
                            voltaje = 0;
                        }
                        else if (voltaje <= 0)
                        {
                            Console.WriteLine("El voltaje debe ser mayor que 0.");
                        }

                    } while (voltaje <= 0);

                    do
                    {
                        Console.Write("Ingrese la longitud de ida y vuelta en metros: ");

                        if (!double.TryParse(Console.ReadLine(), out longitud))
                        {
                            Console.WriteLine("Error: Ingrese un valor numerico.");
                            longitud = 0;
                        }
                        else if (longitud <= 0)
                        {
                            Console.WriteLine("La longitud debe ser mayor que 0.");
                        }

                    } while (longitud <= 0);

                    do
                    {
                        Console.Write("Ingrese la corriente: ");

                        if (!double.TryParse(Console.ReadLine(), out corriente))
                        {
                            Console.WriteLine("Error: Ingrese un valor numerico.");
                            corriente = 0;
                        }
                        else if (corriente <= 0)
                        {
                            Console.WriteLine("La corriente debe ser mayor que 0.");
                        }

                    } while (corriente <= 0);

                    Console.WriteLine();
                Console.WriteLine("CALIBRE DEL CONDUCTOR");
                Console.WriteLine("1. #14 AWG");
                Console.WriteLine("2. #12 AWG");
                Console.WriteLine("3. #10 AWG");
                Console.WriteLine("4. #8 AWG");
                Console.WriteLine("5. #6 AWG");
                Console.WriteLine();

                    do
                    {
                        Console.Write("Seleccione un calibre: ");

                        if (!int.TryParse(Console.ReadLine(), out calibre))
                        {
                            Console.WriteLine("Error: Ingrese un numero del 1 al 5.");
                            calibre = -1;
                        }
                        else if (calibre < 1 || calibre > 5)
                        {
                            Console.WriteLine("Calibre no valido. Seleccione una opcion del 1 al 5.");
                        }

                    } while (calibre < 1 || calibre > 5);

                    switch (calibre)
                    {
                        case 1:
                            { 
                                area = 2.082;
                                nombreCalibre = "#14 AWG";
                            }
                        break;
                            
                        case 2:
                            { 
                                area = 3.307;
                                nombreCalibre = "#12 AWG";
                            }
                        break;

                        case 3:
                            {
                                area = 5.260;
                                nombreCalibre = "#10 AWG";
                            }
                        break;

                        case 4:
                            {
                                area = 8.367;
                                nombreCalibre = "#8 AWG";
                            }
                        break;

                        case 5:
                            {
                                area = 13.300;
                                nombreCalibre = "#6 AWG";
                            }
                        break;

                        default:
                            {
                                area = 0;
                                nombreCalibre = "NO VALIDO";
                            }
                        break;
                    }

                Console.WriteLine();
                Console.WriteLine($"Calibre Seleccionado: {nombreCalibre}");
                Console.WriteLine($"Area del conductor: {area:F3}");

                Console.WriteLine();
                Console.WriteLine();

                caidaTension = (resistividad * longitud * corriente) / area;
                porcentaje = (caidaTension / voltaje) * 100;

                Console.WriteLine();
                Console.WriteLine("Tipo de circuito");
                Console.WriteLine("1. Circuito Derivado, Maximo 3%");
                Console.WriteLine("2. Tablero principal a carga final, Maximo 5%");
                Console.WriteLine();

                    do
                    {
                        Console.Write("Seleccione el tipo de circuito: ");
                        tipoCircuito = int.Parse(Console.ReadLine());

                        if (tipoCircuito < 1 || tipoCircuito > 2)
                        {
                            Console.WriteLine("Opcion no valida. Seleccione 1 o 2.");
                        }

                    } while (tipoCircuito < 1 || tipoCircuito > 2);

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
                   Console.WriteLine("El calibre seleccionado no es adecuado");
                   Console.WriteLine();
                   Console.WriteLine("Buscar un calibre mayor?");
                   Console.WriteLine("1. si");
                   Console.WriteLine("0. No");
                   Console.WriteLine();
                   Console.Write("Seleccione una opcion: ");

                        int buscarCalibre;

                        do
                        {
                            Console.Write("Seleccione una opcion: ");

                            if (!int.TryParse(Console.ReadLine(), out buscarCalibre))
                            {
                                Console.WriteLine("Error: Ingrese 1 o 0.");
                                buscarCalibre = -1;
                            }
                            else if (buscarCalibre != 0 && buscarCalibre != 1)
                            {
                                Console.WriteLine("Opcion no valida. Seleccione 1 o 0.");
                            }

                        } while (buscarCalibre != 0 && buscarCalibre != 1);

                        if (buscarCalibre == 1)
                        {
                            for (int i = calibre +1; i <= 5; i++)
                            {
                                double areaCalibreNuevo;
                                string nombreNuevoCalibre;

                                switch (i)
                                {
                                    case 2:
                                        {
                                            areaCalibreNuevo = 3.307;
                                            nombreNuevoCalibre = "#12 AWG";
                                        }
                                    break;

                                    case 3:
                                        {
                                            areaCalibreNuevo = 5.260;
                                            nombreNuevoCalibre = "#10 AWG";
                                        }
                                    break;

                                    case 4:
                                        {
                                            areaCalibreNuevo = 8.367;
                                            nombreNuevoCalibre = "#8 AWG";
                                        }
                                    break;

                                    case 5:
                                        {
                                            areaCalibreNuevo = 13.300;
                                            nombreNuevoCalibre = "#6 AWG";
                                        }
                                    break;

                                    default:
                                        {
                                            areaCalibreNuevo = 0;
                                            nombreNuevoCalibre = "NO VALIDO";
                                        }
                                    break;
                                }

                                double caidaNueva;
                                double PorcentajeNuevo;

                                caidaNueva = (resistividad * longitud * corriente) / areaCalibreNuevo;
                                PorcentajeNuevo = (caidaNueva / voltaje) * 100;

                                Console.WriteLine();
                                Console.WriteLine($"Probando {nombreNuevoCalibre}");
                                Console.WriteLine($"Caida de tension: {caidaNueva:F2} V");
                                Console.WriteLine($"Porcentaje de caida: {PorcentajeNuevo:F2} %");

                                if (PorcentajeNuevo <= limite)
                                {
                                    Console.WriteLine("CÚMPLE");
                                    Console.WriteLine();
                                    Console.WriteLine($"Calibre Recomendado: {nombreNuevoCalibre}");

                                    encontrarCalibre = true;

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("NO CUMPLE");
                                }

                            }

                            if (encontrarCalibre == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("No se encontro un calibre mayor con el limite permitido");
                            }
                        }
                }

                Console.WriteLine();
                Console.WriteLine("1. Realizar otro calculo");
                Console.WriteLine("0. Menu principal");
                Console.WriteLine();

                    do
                    {
                        Console.Write("Seleccione una opcion: ");

                        if (!int.TryParse(Console.ReadLine(), out continuar))
                        {
                            Console.WriteLine("Error: Ingrese 1 o 0.");
                            continuar = -1;
                        }
                        else if (continuar != 0 && continuar != 1)
                        {
                            Console.WriteLine("Opcion no valida. Seleccione 1 o 0.");
                        }

                    } while (continuar != 0 && continuar != 1);


                } while (continuar != 0);

        }
        break;

        case 3:
        {
                Console.Clear();

                int conversion;
                int continuar;

                do
                {
                    Console.Clear();

                    Console.WriteLine("CONVERSION ENTRE UNIDADES");
                    Console.WriteLine();

                    Console.WriteLine("1. METROS A PIES");
                    Console.WriteLine("2. PIES A METROS");
                    Console.WriteLine("3. MILIMETROS A PULGADAS");
                    Console.WriteLine("4. PULGADAS A MILIMETROS");
                    Console.WriteLine("5. AMPERIOS A MILIAMPERIOS");
                    Console.WriteLine("6. MILIAMPERIOS A AMPERIOS");
                    Console.WriteLine("0. MENU PRINCIPAL");
                    Console.WriteLine();

                    do
                    {
                        Console.Write("Seleccione una opcion: ");

                        if (!int.TryParse(Console.ReadLine(), out conversion))
                        {
                            Console.WriteLine("Error: Ingrese un numero del 0 al 6.");
                            conversion = -1;
                        }
                        else if (conversion < 0 || conversion > 6)
                        {
                            Console.WriteLine("Opcion no valida. Seleccione una opcion del 0 al 6.");
                        }

                    } while (conversion < 0 || conversion > 6);

                    switch (conversion)
                    {
                        case 1:
                            {
                                Console.Clear();

                                Console.WriteLine("METROS A PIES");
                                Console.WriteLine();

                                double metros;
                                double pies;

                                do
                                {
                                    Console.Write("Ingrese los metros: ");

                                    if (!double.TryParse(Console.ReadLine(), out metros))
                                    {
                                        Console.WriteLine("Error: Ingrese un valor numerico.");
                                        metros = -1;
                                    }
                                    else if (metros < 0)
                                    {
                                        Console.WriteLine("El valor no puede ser negativo.");
                                    }

                                } while (metros < 0);

                                pies = metros * 3.28084;

                                Console.WriteLine();
                                Console.WriteLine($"El resultado es: {pies:F2} pies");
                            }
                        break;

                        case 2:
                            {
                                Console.Clear();

                                Console.WriteLine("PIES A METROS");
                                Console.WriteLine();

                                double pies;
                                double metros;

                                do
                                {
                                    Console.Write("Ingrese los pies: ");

                                    if (!double.TryParse(Console.ReadLine(), out pies))
                                    {
                                        Console.WriteLine("Error: Ingrese un valor numerico.");
                                        pies = -1;
                                    }
                                    else if (pies < 0)
                                    {
                                        Console.WriteLine("El valor no puede ser negativo.");
                                    }

                                } while (pies < 0);

                                metros = pies / 3.28084;

                                Console.WriteLine();
                                Console.WriteLine($"El resultado es: {metros:F2} metros");
                            }
                        break;

                        case 3:
                            {
                                Console.Clear();

                                Console.WriteLine("MILIMETROS A PULGADAS");
                                Console.WriteLine();

                                double milimetros;
                                double pulgadas;

                                do
                                {
                                    Console.Write("Ingrese los milimetros: ");

                                    if (!double.TryParse(Console.ReadLine(), out milimetros))
                                    {
                                        Console.WriteLine("Error: Ingrese un valor numerico.");
                                        milimetros = -1;
                                    }
                                    else if (milimetros < 0)
                                    {
                                        Console.WriteLine("El valor no puede ser negativo.");
                                    }

                                } while (milimetros < 0);

                                pulgadas = milimetros / 25.4;

                                Console.WriteLine();
                                Console.WriteLine($"El resultado es: {pulgadas:F2} pulgadas");
                            }
                        break;

                        case 4:
                            {
                                Console.Clear();

                                Console.WriteLine("PULGADAS A MILIMETROS");
                                Console.WriteLine();

                                double pulgadas;
                                double milimetros;

                                do
                                {
                                    Console.Write("Ingrese las pulgadas: ");

                                    if (!double.TryParse(Console.ReadLine(), out pulgadas))
                                    {
                                        Console.WriteLine("Error: Ingrese un valor numerico.");
                                        pulgadas = -1;
                                    }
                                    else if (pulgadas < 0)
                                    {
                                        Console.WriteLine("El valor no puede ser negativo.");
                                    }

                                } while (pulgadas < 0);

                                milimetros = pulgadas * 25.4;

                                Console.WriteLine();
                                Console.WriteLine($"El resultado es: {milimetros:F2} mm");
                            }
                        break;

                        case 5:
                            {
                                Console.Clear();

                                Console.WriteLine("AMPERIOS A MILIAMPERIOS");
                                Console.WriteLine();

                                double amperios;
                                double miliamperios;

                                do
                                {
                                    Console.Write("Ingrese los amperios: ");

                                    if (!double.TryParse(Console.ReadLine(), out amperios))
                                    {
                                        Console.WriteLine("Error: Ingrese un valor numerico.");
                                        amperios = -1;
                                    }
                                    else if (amperios < 0)
                                    {
                                        Console.WriteLine("El valor no puede ser negativo.");
                                    }

                                } while (amperios < 0);

                                miliamperios = amperios * 1000;

                                Console.WriteLine();
                                Console.WriteLine($"El resultado es: {miliamperios:F2} mA");
                            }
                        break;

                        case 6:
                            {
                                Console.Clear();

                                Console.WriteLine("MILIAMPERIOS A AMPERIOS");
                                Console.WriteLine();

                                double miliamperios;
                                double amperios;

                                do
                                {
                                    Console.Write("Ingrese los miliamperios: ");

                                    if (!double.TryParse(Console.ReadLine(), out miliamperios))
                                    {
                                        Console.WriteLine("Error: Ingrese un valor numerico.");
                                        miliamperios = -1;
                                    }
                                    else if (miliamperios < 0)
                                    {
                                        Console.WriteLine("El valor no puede ser negativo.");
                                    }

                                } while (miliamperios < 0);

                                amperios = miliamperios / 1000;

                                Console.WriteLine();
                                Console.WriteLine($"El resultado es: {amperios:F2} A");
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
                                Console.WriteLine();
                                Console.WriteLine("OPCION INGRESADA NO VALIDA");
                            }
                        break;
                    }

                    if (conversion != 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1. Realizar otra conversion");
                        Console.WriteLine("0. Menu principal");
                        Console.WriteLine();

                        do
                        {
                            Console.Write("Seleccione una opcion: ");
                            continuar = int.Parse(Console.ReadLine());

                            if (continuar != 0 && continuar != 1)
                            {
                                Console.WriteLine("Opcion no valida. Seleccione 1 o 0.");
                            }

                        } while (continuar != 0 && continuar != 1);
                    }
                    else
                    {
                        continuar = 0;
                    }

                } while (continuar != 0);

            }
        break;

        case 4:
        {
                Console.Clear();

                int calculoMonofasico;
                int continuar;

                do
                {
                    Console.Clear();

                    Console.WriteLine("CALCULO PARA CIRCUITOS MONOFASICOS");
                    Console.WriteLine();

                    Console.WriteLine("1. Calcular Corriente");
                    Console.WriteLine("2. Calcular Potencia");
                    Console.WriteLine("3. Calcular Voltaje");
                    Console.WriteLine("0. Menu principal");
                    Console.WriteLine();

                    do
                    {
                        Console.Write("Seleccione una opcion: ");

                        if (!int.TryParse(Console.ReadLine(), out calculoMonofasico))
                        {
                            Console.WriteLine("Error: Ingrese un numero del 0 al 3.");
                            calculoMonofasico = -1;
                        }
                        else if (calculoMonofasico < 0 || calculoMonofasico > 3)
                        {
                            Console.WriteLine("Opcion no valida. Seleccione una opcion del 0 al 3.");
                        }

                    } while (calculoMonofasico < 0 || calculoMonofasico > 3);

                    switch (calculoMonofasico)
                    {
                        case 1:
                            {
                                Console.Clear();

                                Console.WriteLine("CALCULAR CORRIENTE");
                                Console.WriteLine();

                                double potencia;
                                double voltaje;
                                double corriente;

                                do
                                {
                                    Console.Write("Ingrese la potencia: ");
                                    potencia = double.Parse(Console.ReadLine());

                                    if (potencia < 0)
                                    {
                                        Console.WriteLine("La potencia no puede ser negativa.");
                                    }

                                } while (potencia < 0);

                                do
                                {
                                    Console.Write("Ingrese el voltaje: ");
                                    voltaje = double.Parse(Console.ReadLine());

                                    if (voltaje <= 0)
                                    {
                                        Console.WriteLine("El voltaje debe ser mayor que 0.");
                                    }

                                } while (voltaje <= 0);

                                corriente = potencia / voltaje;

                                Console.WriteLine();
                                Console.WriteLine($"La corriente es: {corriente:F2} A");
                            }
                            break;

                        case 2:
                            {
                                Console.Clear();

                                Console.WriteLine("CALCULAR POTENCIA");
                                Console.WriteLine();

                                double voltaje;
                                double corriente;
                                double potencia;

                                do
                                {
                                    Console.Write("Ingrese el voltaje: ");
                                    voltaje = double.Parse(Console.ReadLine());

                                    if (voltaje <= 0)
                                    {
                                        Console.WriteLine("El voltaje debe ser mayor que 0.");
                                    }

                                } while (voltaje <= 0);

                                do
                                {
                                    Console.Write("Ingrese la corriente: ");
                                    corriente = double.Parse(Console.ReadLine());

                                    if (corriente < 0)
                                    {
                                        Console.WriteLine("La corriente no puede ser negativa.");
                                    }

                                } while (corriente < 0);

                                potencia = voltaje * corriente;

                                Console.WriteLine();
                                Console.WriteLine($"La potencia es: {potencia:F2} W");
                            }
                            break;

                        case 3:
                            {
                                Console.Clear();

                                Console.WriteLine("CALCULAR VOLTAJE");
                                Console.WriteLine();

                                double potencia;
                                double corriente;
                                double voltaje;

                                do
                                {
                                    Console.Write("Ingrese la potencia: ");
                                    potencia = double.Parse(Console.ReadLine());

                                    if (potencia < 0)
                                    {
                                        Console.WriteLine("La potencia no puede ser negativa.");
                                    }

                                } while (potencia < 0);

                                do
                                {
                                    Console.Write("Ingrese la corriente: ");
                                    corriente = double.Parse(Console.ReadLine());

                                    if (corriente <= 0)
                                    {
                                        Console.WriteLine("La corriente debe ser mayor que 0.");
                                    }

                                } while (corriente <= 0);

                                voltaje = potencia / corriente;

                                Console.WriteLine();
                                Console.WriteLine($"El voltaje es: {voltaje:F2} V");
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
                                Console.WriteLine();
                                Console.WriteLine("OPCION INGRESADA NO VALIDA");
                            }
                        break;
                    }

                    if (calculoMonofasico != 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1. Realizar otro calculo");
                        Console.WriteLine("0. Menu principal");
                        Console.WriteLine();

                        do
                        {
                            Console.Write("Seleccione una opcion: ");
                            continuar = int.Parse(Console.ReadLine());

                            if (continuar != 0 && continuar != 1)
                            {
                                Console.WriteLine("Opcion no valida. Seleccione 1 o 0.");
                            }

                        } while (continuar != 0 && continuar != 1);
                    }
                    else
                    {
                        continuar = 0;
                    }

                } while (continuar != 0);

            }
        break;

        case 5:
        {
                Console.Clear();

                int opcionCircuito;

                do
                {
                    Console.Clear();

                    Console.WriteLine("CALCULO DE CIRCUITOS DERIVADOS Y ALIMENTADORES");
                    Console.WriteLine();

                    Console.WriteLine("1. Calcular circuito derivado");
                    Console.WriteLine("2. Calcular alimentador");
                    Console.WriteLine("0. Menu Principal");
                    Console.WriteLine();

                    do
                    {
                        Console.Write("Seleccione una opcion: ");

                        if (!int.TryParse(Console.ReadLine(), out opcionCircuito))
                        {
                            Console.WriteLine("Error: Ingrese un numero del 0 al 2.");
                            opcionCircuito = -1;
                        }
                        else if (opcionCircuito < 0 || opcionCircuito > 2)
                        {
                            Console.WriteLine("Opcion no valida. Seleccione una opcion del 0 al 2.");
                        }

                    } while (opcionCircuito < 0 || opcionCircuito > 2);

                    switch (opcionCircuito)
                    {
                        case 1:
                            {
                                Console.Clear();

                                Console.WriteLine("CALCULAR CIRCUITO DERIVADO");
                                Console.WriteLine();

                                double potencia;
                                double voltaje;
                                double corriente;
                                int calibre;
                                double ampacidad;
                                string nombreCalibre;
                                string calibreRecomendado;

                                do
                                {
                                    Console.Write("Ingrese la potencia de la carga: ");
                                    potencia = double.Parse(Console.ReadLine());

                                    if (potencia < 0)
                                    {
                                        Console.WriteLine("La potencia no puede ser negativa.");
                                    }

                                } while (potencia < 0);

                                do
                                {
                                    Console.Write("Ingrese el voltaje: ");
                                    voltaje = double.Parse(Console.ReadLine());

                                    if (voltaje <= 0)
                                    {
                                        Console.WriteLine("El voltaje debe ser mayor que 0.");
                                    }

                                } while (voltaje <= 0);

                                corriente = potencia / voltaje;

                                Console.WriteLine();
                                Console.WriteLine($"La corriente de la carga es: {corriente:F2} A");
                                Console.WriteLine();
                                Console.WriteLine("CALIBRE DEL CONDUCTOR");
                                Console.WriteLine("1. #14 AWG");
                                Console.WriteLine("2. #12 AWG");
                                Console.WriteLine("3. #10 AWG");
                                Console.WriteLine("4. #8 AWG");
                                Console.WriteLine("5. #6 AWG");
                                Console.WriteLine();

                                do
                                {
                                    Console.Write("Seleccione un calibre: ");

                                    if (!int.TryParse(Console.ReadLine(), out calibre))
                                    {
                                        Console.WriteLine("Error: Ingrese un numero del 1 al 5.");
                                        calibre = -1;
                                    }
                                    else if (calibre < 1 || calibre > 5)
                                    {
                                        Console.WriteLine("Opcion no valida. Seleccione un calibre del 1 al 5.");
                                    }

                                } while (calibre < 1 || calibre > 5);

                                switch (calibre)
                                {
                                    case 1:
                                        {
                                            ampacidad = 15;
                                            nombreCalibre = "#14 AWG";
                                        }
                                    break;

                                    case 2:
                                        {
                                            ampacidad = 20;
                                            nombreCalibre = "#12 AWG";
                                        }
                                    break;

                                    case 3:
                                        {
                                            ampacidad = 30;
                                            nombreCalibre = "#10 AWG";
                                        }
                                    break;

                                    case 4:
                                        {
                                            ampacidad = 40;
                                            nombreCalibre = "#8 AWG";
                                        }
                                    break;

                                    case 5:
                                        {
                                            ampacidad = 55;
                                            nombreCalibre = "#6 AWG";
                                        }
                                    break;

                                    default:
                                        {
                                            ampacidad = 0;
                                            nombreCalibre = "NO VALIDO";
                                        }
                                    break;
                                }

                                Console.WriteLine();
                                Console.WriteLine($"Calibre seleccionado: {nombreCalibre}");
                                Console.WriteLine($"Ampacidad del conductor: {ampacidad:F2} A");
                                Console.WriteLine();

                                if (corriente <= ampacidad)
                                {
                                    Console.WriteLine("El conductor es adecuado.");
                                }
                                else
                                {
                                    Console.WriteLine("El conductor NO es adecuado.");
                                    Console.WriteLine();

                                    if (corriente <= 20)
                                    {
                                        calibreRecomendado = "#12 AWG";
                                    }
                                    else if (corriente <= 30)
                                    {
                                        calibreRecomendado = "#10 AWG";
                                    }
                                    else if (corriente <= 40)
                                    {
                                        calibreRecomendado = "#8 AWG";
                                    }
                                    else if (corriente <= 55)
                                    {
                                        calibreRecomendado = "#6 AWG";
                                    }
                                    else
                                    {
                                        calibreRecomendado = "No disponible en la tabla";
                                    }

                                    Console.WriteLine($"Se recomienda utilizar: {calibreRecomendado}");
                                }

                                Console.WriteLine();
                                Console.WriteLine("Presione una tecla para continuar...");
                                Console.ReadKey();
                            }
                        break;

                        case 2:
                            {
                                Console.Clear();

                                Console.WriteLine("CALCULAR ALIMENTADOR");
                                Console.WriteLine();

                                double potenciaTotal;
                                double voltaje;
                                double corrienteAlimentador;

                                do
                                {
                                    Console.Write("Ingrese la potencia total de las cargas: ");
                                    potenciaTotal = double.Parse(Console.ReadLine());

                                    if (potenciaTotal < 0)
                                    {
                                        Console.WriteLine("La potencia no puede ser negativa.");
                                    }

                                } while (potenciaTotal < 0);

                                do
                                {
                                    Console.Write("Ingrese el voltaje del alimentador: ");
                                    voltaje = double.Parse(Console.ReadLine());

                                    if (voltaje <= 0)
                                    {
                                        Console.WriteLine("El voltaje debe ser mayor que 0.");
                                    }

                                } while (voltaje <= 0);

                                corrienteAlimentador = potenciaTotal / voltaje;

                                Console.WriteLine();
                                Console.WriteLine($"La corriente del alimentador es: {corrienteAlimentador:F2} A");
                                Console.WriteLine();

                                int calibre;
                                double ampacidad;
                                string nombreCalibre;

                                Console.WriteLine("CALIBRE DEL CONDUCTOR");
                                Console.WriteLine("1. #14 AWG");
                                Console.WriteLine("2. #12 AWG");
                                Console.WriteLine("3. #10 AWG");
                                Console.WriteLine("4. #8 AWG");
                                Console.WriteLine("5. #6 AWG");
                                Console.WriteLine();

                                do
                                {
                                    Console.Write("Seleccione un calibre: ");

                                    if (!int.TryParse(Console.ReadLine(), out calibre))
                                    {
                                        Console.WriteLine("Error: Ingrese un numero del 1 al 5.");
                                        calibre = -1;
                                    }
                                    else if (calibre < 1 || calibre > 5)
                                    {
                                        Console.WriteLine("Opcion no valida. Seleccione un calibre del 1 al 5.");
                                    }

                                } while (calibre < 1 || calibre > 5);

                                switch (calibre)
                                {
                                    case 1:
                                        {
                                            ampacidad = 15;
                                            nombreCalibre = "#14 AWG";
                                        }
                                    break;

                                    case 2:
                                        {
                                            ampacidad = 20;
                                            nombreCalibre = "#12 AWG";
                                        }
                                    break;

                                    case 3:
                                        {
                                            ampacidad = 30;
                                            nombreCalibre = "#10 AWG";
                                        }
                                    break;

                                    case 4:
                                        {
                                            ampacidad = 40;
                                            nombreCalibre = "#8 AWG";
                                        }
                                    break;

                                    case 5:
                                        {
                                            ampacidad = 55;
                                            nombreCalibre = "#6 AWG";
                                        }
                                    break;

                                    default:
                                        {
                                            ampacidad = 0;
                                            nombreCalibre = "NO VALIDO";
                                        }
                                    break;
                                }

                                Console.WriteLine();
                                Console.WriteLine($"Calibre seleccionado: {nombreCalibre}");
                                Console.WriteLine($"Ampacidad del conductor: {ampacidad:F2} A");
                                Console.WriteLine();

                                if (corrienteAlimentador <= ampacidad)
                                {
                                    Console.WriteLine("El conductor es adecuado para el alimentador.");
                                }
                                else
                                {
                                    Console.WriteLine("El conductor NO es adecuado para el alimentador.");
                                }

                                Console.WriteLine();
                                Console.WriteLine("1. Realizar otro calculo");
                                Console.WriteLine("0. Menu principal");
                                Console.WriteLine();

                                int continuar;

                                do
                                {
                                    Console.Write("Seleccione una opcion: ");
                                    continuar = int.Parse(Console.ReadLine());

                                    if (continuar != 0 && continuar != 1)
                                    {
                                        Console.WriteLine("Opcion no valida. Seleccione 1 o 0.");
                                    }

                                } while (continuar != 0 && continuar != 1);

                                if (continuar == 0)
                                {
                                    opcionCircuito = 0;
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
                                Console.WriteLine();
                                Console.WriteLine("OPCION INGRESADA NO VALIDA");
                            }
                        break;
                    }

                } while (opcionCircuito != 0);

            }
        break;

        case 6:
        {
                Console.Clear();

                Console.WriteLine("TABLA DE CALIBRES DE CONDUCTORES");
                Console.WriteLine();

                Console.WriteLine("CALIBRE");
                Console.WriteLine("1. #14 AWG");
                Console.WriteLine("2. #12 AWG");
                Console.WriteLine("3. #10 AWG");
                Console.WriteLine("4. #8 AWG");
                Console.WriteLine("5. #6 AWG");
                Console.WriteLine("6. #4 AWG");
                Console.WriteLine("7. #2 AWG");
                Console.WriteLine("8. #1/0 AWG");
                Console.WriteLine("9. #2/0 AWG");
                Console.WriteLine("10. #3/0 AWG");
                Console.WriteLine("11. #4/0 AWG");
                Console.WriteLine();

                int calibre;

                do
                {
                    Console.Write("Seleccione el calibre que desea consultar: ");

                    if (!int.TryParse(Console.ReadLine(), out calibre))
                    {
                        Console.WriteLine("Error: Ingrese un numero del 1 al 11.");
                        calibre = -1;
                    }
                    else if (calibre < 1 || calibre > 11)
                    {
                        Console.WriteLine("Opcion no valida. Seleccione un calibre del 1 al 11.");
                    }

                } while (calibre < 1 || calibre > 11);

                double ampacidad;
                string nombreCalibre;

                switch (calibre)
                {
                    case 1:
                        {
                            ampacidad = 15;
                            nombreCalibre = "#14 AWG";
                        }
                    break;

                    case 2:
                        {
                            ampacidad = 20;
                            nombreCalibre = "#12 AWG";
                        }
                    break;

                    case 3:
                        {
                            ampacidad = 30;
                            nombreCalibre = "#10 AWG";
                        }
                    break;

                    case 4:
                        {
                            ampacidad = 40;
                            nombreCalibre = "#8 AWG";
                        }
                    break;

                    case 5:
                        {
                            ampacidad = 55;
                            nombreCalibre = "#6 AWG";
                        }
                    break;

                    case 6:
                        {
                            ampacidad = 0;
                            nombreCalibre = "#4 AWG";
                        }
                    break;

                    case 7:
                        {
                            ampacidad = 0;
                            nombreCalibre = "#2 AWG";
                        }
                    break;

                    case 8:
                        {
                            ampacidad = 0;
                            nombreCalibre = "#1/0 AWG";
                        }
                    break;

                    case 9:
                        {
                            ampacidad = 0;
                            nombreCalibre = "#2/0 AWG";
                        }
                    break;

                    case 10:
                        {
                            ampacidad = 0;
                            nombreCalibre = "#3/0 AWG";
                        }
                    break;

                    case 11:
                        {
                            ampacidad = 0;
                            nombreCalibre = "#4/0 AWG";
                        }
                    break;

                    default:
                        {
                            ampacidad = 0;
                            nombreCalibre = "NO VALIDO";
                        }
                    break;
                }

                if (calibre >= 1 && calibre <= 5)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Calibre seleccionado: {nombreCalibre}");
                    Console.WriteLine($"Ampacidad: {ampacidad:F2} A");
                }
                else if (calibre >= 6 && calibre <= 11)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Calibre seleccionado: {nombreCalibre}");
                    Console.WriteLine("Ampacidad: No disponible en la tabla.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Calibre no valido.");
                }

                Console.WriteLine();
                Console.WriteLine("Presione una tecla para volver al menu principal");
                Console.ReadKey();

        }
        break;

        case 7:
        {
                Console.Clear();

                Console.WriteLine("TABLA DE AREA DE CONDUCTORES SEGUN CALIBRE");
                Console.WriteLine();

                Console.WriteLine("Area del conductor sin aislamiento");
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

                int opcionTuberia;

                do
                {
                    Console.Clear();

                    Console.WriteLine("TAMAÑOS DE TUBERIA CONDUIT");
                    Console.WriteLine();

                    Console.WriteLine("1. Calcular factor de relleno");
                    Console.WriteLine("2. Consultar tamaños de tuberia");
                    Console.WriteLine("0. Menu Principal");
                    Console.WriteLine();

                    do
                    {
                        Console.Write("Seleccione una opcion: ");

                        if (!int.TryParse(Console.ReadLine(), out opcionTuberia))
                        {
                            Console.WriteLine("Error: Ingrese un numero del 0 al 2.");
                            opcionTuberia = -1;
                        }
                        else if (opcionTuberia < 0 || opcionTuberia > 2)
                        {
                            Console.WriteLine("Opcion no valida. Seleccione una opcion del 0 al 2.");
                        }

                    } while (opcionTuberia < 0 || opcionTuberia > 2);

                    switch (opcionTuberia)
                    {
                        case 1:
                            {
                                Console.Clear();

                                Console.WriteLine("CALCULAR FACTOR DE RELLENO");
                                Console.WriteLine();

                                int cantidadConductores;
                                double areaConductor;
                                double areaTotalConductores;
                                double areaTuberia;
                                double factorRelleno;
                                double limiteRelleno;

                                do
                                {
                                    Console.Write("Ingrese la cantidad de conductores: ");

                                    if (!int.TryParse(Console.ReadLine(), out cantidadConductores))
                                    {
                                        Console.WriteLine("Error: Ingrese un numero entero mayor que 0.");
                                        cantidadConductores = 0;
                                    }
                                    else if (cantidadConductores <= 0)
                                    {
                                        Console.WriteLine("La cantidad debe ser mayor que 0.");
                                    }

                                } while (cantidadConductores <= 0);

                                areaTotalConductores = 0;

                                for (int i = 1; i <= cantidadConductores; i++)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"CONDUCTOR {i}");
                                    Console.WriteLine("1. #14 AWG");
                                    Console.WriteLine("2. #12 AWG");
                                    Console.WriteLine("3. #10 AWG");
                                    Console.WriteLine("4. #8 AWG");
                                    Console.WriteLine("5. #6 AWG");

                                    int calibre;
                                    bool calibreValido;

                                    do
                                    {
                                        Console.Write("Seleccione el calibre: ");

                                        if (!int.TryParse(Console.ReadLine(), out calibre))
                                        {
                                            Console.WriteLine("Error: Ingrese un numero del 1 al 5.");
                                            calibreValido = false;
                                        }
                                        else
                                        {
                                            calibreValido = calibre >= 1 && calibre <= 5;

                                            if (!calibreValido)
                                            {
                                                Console.WriteLine("Calibre no valido. Seleccione una opcion del 1 al 5.");
                                            }
                                        }

                                    } while (!calibreValido);

                                    switch (calibre)
                                    {
                                        case 1:
                                            {
                                                areaConductor = 9.24;
                                            }
                                        break;

                                        case 2:
                                            {
                                                areaConductor = 12.0;
                                            }
                                        break;

                                        case 3:
                                            {
                                                areaConductor = 16.1;
                                            }
                                        break;

                                        case 4:
                                            {
                                                areaConductor = 29.2;
                                            }
                                        break;

                                        case 5:
                                            {
                                                areaConductor = 48.0;
                                            }
                                        break;

                                        default:
                                            {
                                                areaConductor = 0;
                                                calibreValido = false;
                                            }
                                        break;
                                    }

                                    if (!calibreValido)
                                    {
                                        Console.WriteLine("Calibre no valido.");
                                    }
                                    else
                                    {
                                        areaTotalConductores = areaTotalConductores + areaConductor;
                                    }

                                }


                                Console.WriteLine();
                                Console.WriteLine("TAMAÑO DE TUBERIA CONDUIT");
                                Console.WriteLine("1. 1/2\"");
                                Console.WriteLine("2. 3/4\"");
                                Console.WriteLine("3. 1\"");
                                Console.WriteLine("4. 1 1/4\"");
                                Console.WriteLine("5. 1 1/2\"");
                                Console.WriteLine();

                                int tamañoTuberia;

                                do
                                {
                                    Console.Write("Seleccione el tamaño de la tuberia: ");

                                    if (!int.TryParse(Console.ReadLine(), out tamañoTuberia))
                                    {
                                        Console.WriteLine("Error: Ingrese un numero del 1 al 5.");
                                        tamañoTuberia = -1;
                                    }
                                    else if (tamañoTuberia < 1 || tamañoTuberia > 5)
                                    {
                                        Console.WriteLine("Opcion no valida. Seleccione un tamaño del 1 al 5.");
                                    }

                                } while (tamañoTuberia < 1 || tamañoTuberia > 5);

                                switch (tamañoTuberia)
                                {
                                    case 1:
                                        {
                                            areaTuberia = 260;
                                        }
                                    break;

                                    case 2:
                                        {
                                            areaTuberia = 438;
                                        }
                                    break;

                                    case 3:
                                        {
                                            areaTuberia = 723;
                                        }
                                    break;

                                    case 4:
                                        {
                                            areaTuberia = 1170;
                                        }
                                    break;

                                    case 5:
                                        {
                                            areaTuberia = 1534;
                                        }
                                    break;

                                    default:
                                        {
                                            areaTuberia = 0;
                                        }
                                    break;
                                }

                                Console.WriteLine();
                                Console.WriteLine($"Area total de los conductores: {areaTotalConductores:F3} mm²");

                                if (areaTuberia == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Tamaño de tuberia no valido.");
                                }
                                else
                                {
                                    factorRelleno = (areaTotalConductores / areaTuberia) * 100;

                                    Console.WriteLine($"Area de la tuberia: {areaTuberia:F3} mm²");
                                    Console.WriteLine($"Factor de relleno: {factorRelleno:F2} %");

                                    limiteRelleno = 40;

                                    Console.WriteLine($"Limite de relleno permitido: {limiteRelleno:F2} %");

                                    if (factorRelleno <= limiteRelleno)
                                    {
                                        Console.WriteLine("CUMPLE: La tuberia es adecuada.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("NO CUMPLE: La tuberia es insuficiente.");
                                    }
                                }

                                Console.WriteLine();
                                Console.WriteLine("Presione una tecla para continuar...");
                                Console.ReadKey();
                            }
                        break;

                        case 2:
                            {
                                Console.Clear();

                                Console.WriteLine("TAMAÑOS DE TUBERIA CONDUIT");
                                Console.WriteLine();

                                Console.WriteLine("TAMAÑO       AREA INTERNA");
                                Console.WriteLine("1/2\"         260 mm²");
                                Console.WriteLine("3/4\"         438 mm²");
                                Console.WriteLine("1\"           723 mm²");
                                Console.WriteLine("1 1/4\"       1170 mm²");
                                Console.WriteLine("1 1/2\"       1534 mm²");

                                Console.WriteLine();
                                Console.WriteLine("Presione una tecla para continuar...");
                                Console.ReadKey();
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
                                Console.WriteLine();
                                Console.WriteLine("OPCION INGRESADA NO VALIDA");
                                Console.WriteLine();
                                Console.WriteLine("Presione una tecla para continuar...");
                                Console.ReadKey();
                            }
                        break;
                    }

                } while (opcionTuberia != 0);

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



Console.ReadKey();
Console.Clear();

