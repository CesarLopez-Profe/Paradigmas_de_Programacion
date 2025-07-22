 
 // Ejemplo 1: Formato de moneda
        decimal precio = 12345.6789m; //real de alta precisión
        Console.WriteLine("Formato de moneda:");
        Console.WriteLine(precio.ToString("C", CultureInfo.CurrentCulture)); // Moneda local
        Console.WriteLine(precio.ToString("C", new CultureInfo("en-US")));    // Dólares
        Console.WriteLine(precio.ToString("C", new CultureInfo("es-CO")));    // Pesos colombianos
        Console.WriteLine();

        // Ejemplo 2: Formato numérico con decimales
        double numero = 9876.54321;
        Console.WriteLine("Formato numérico con decimales:");
        Console.WriteLine(numero.ToString("N2")); // 2 decimales
        Console.WriteLine(numero.ToString("N4")); // 4 decimales
        Console.WriteLine();

        // Ejemplo 3: Porcentaje
        double porcentaje = 0.875;
        Console.WriteLine("Formato de porcentaje:");
        Console.WriteLine(porcentaje.ToString("P"));   // 87.50%
        Console.WriteLine(porcentaje.ToString("P1"));  // 87.5%
        Console.WriteLine();

        // Ejemplo 4: Número en notación científica
        double grande = 123456789;
        Console.WriteLine("Notación científica:");
        Console.WriteLine(grande.ToString("E"));   // E formato por defecto
        Console.WriteLine(grande.ToString("E3"));  // E con 3 decimales
        Console.WriteLine();

        // Ejemplo 5: Número en formato hexadecimal
        int valor = 255;
        Console.WriteLine("Formato hexadecimal:");
        Console.WriteLine(valor.ToString("X"));    // FF
        Console.WriteLine(valor.ToString("X4"));   // 00FF
        Console.WriteLine();

        // Ejemplo 6: Colores en la consola
        Console.WriteLine("Texto en diferentes colores:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Este texto es verde");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Este texto es rojo");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Este texto es amarillo");
        Console.ResetColor(); // Restaurar colores por defecto

        // Ejemplo 7: Fondo de color
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Texto blanco con fondo azul");
        Console.ResetColor(); // Restaurar colores por defecto