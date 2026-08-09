// ============================================================
// 02 - APRENDE CÓMO FUNCIONA
// Microsoft Learn - C#
// .NET 10
// ============================================================


// ============================================================
// 1. ¿QUÉ ES UN LENGUAJE DE PROGRAMACIÓN?
// ============================================================

// C# es un lenguaje de programación que permite escribir
// instrucciones que posteriormente serán procesadas
// y ejecutadas por el equipo.
//
// El código que escribimos se denomina código fuente.
//
// Ejemplo:
//
// Console.WriteLine("Hello World!");


// ============================================================
// 2. ¿QUÉ ES LA COMPILACIÓN?
// ============================================================

// El código fuente debe ser compilado antes de ejecutarse.
//
// Flujo:
//
// Código fuente
//      ↓
// Compilador
//      ↓
// Código compilado
//      ↓
// Ejecución
//      ↓
// Resultado


// ============================================================
// 3. ¿QUÉ ES LA SINTAXIS?
// ============================================================

// La sintaxis son las reglas que determinan cómo escribir
// correctamente código C#.
//
// C# distingue entre mayúsculas y minúsculas.
//
// Correcto:
//
// Console.WriteLine("Hello World!");
//
// Incorrecto:
//
// console.WriteLine("Hello World!");


// ============================================================
// 4. ANALIZANDO UNA INSTRUCCIÓN
// ============================================================

// Console.WriteLine("Hello World!");
//
// Console      → Clase
// .            → Operador de acceso al miembro
// WriteLine    → Método
// ()           → Invocación del método
// "Hello World!" → Argumento
// ;            → Fin de la instrucción


// ============================================================
// 5. CLASE
// ============================================================

// Console es una clase de .NET.
//
// Las clases pueden contener métodos y funcionalidades.
//
// Ejemplo:
//
// Console


// ============================================================
// 6. OPERADOR DE ACCESO AL MIEMBRO
// ============================================================

// El punto:
//
// .
//
// permite acceder a un miembro de una clase.
//
// Ejemplo:
//
// Console.WriteLine();


// ============================================================
// 7. MÉTODO
// ============================================================

// WriteLine() es un método.
//
// Un método representa una acción que puede ejecutar
// el programa.
//
// Ejemplo:
//
// Console.WriteLine();


// ============================================================
// 8. OPERADOR DE INVOCACIÓN
// ============================================================

// Los paréntesis:
//
// ()
//
// indican la invocación de un método.
//
// Ejemplo:
//
// WriteLine();


// ============================================================
// 9. CADENA LITERAL
// ============================================================

// "Hello World!" es una cadena literal.
//
// Las cadenas utilizan comillas dobles.
//
// Ejemplos:
//
// "Hola"
// "George"
// "C#"


// ============================================================
// 10. ARGUMENTO
// ============================================================

// En:
//
// Console.WriteLine("Hello World!");
//
// "Hello World!" es el argumento que recibe
// el método WriteLine.


// ============================================================
// 11. PUNTO Y COMA
// ============================================================

// El punto y coma:
//
// ;
//
// indica el final de una instrucción.
//
// Ejemplo:
//
// Console.WriteLine("Hello World!");


// ============================================================
// 12. FLUJO DE EJECUCIÓN
// ============================================================

// En un programa sencillo, las instrucciones se ejecutan
// normalmente de arriba hacia abajo.
//
// Ejemplo:
//
// Console.WriteLine("Primero");
// Console.WriteLine("Segundo");
// Console.WriteLine("Tercero");


// ============================================================
// 13. FLUJO GENERAL
// ============================================================

// Escribir código
//      ↓
// Código fuente
//      ↓
// Compilación
//      ↓
// Ejecución
//      ↓
// Resultado


// ============================================================
// 14. ERRORES DE SINTAXIS
// ============================================================

// Ejemplo incorrecto:
//
// console.WriteLine("Hello World!");
//
// "console" y "Console" son diferentes.
//
// Otro error:
//
// Console.WriteLine("Hello World!")
//
// Falta el punto y coma.
//
// Otro error:
//
// Console.WriteLine('Hello World!');
//
// Se utilizan comillas simples para una cadena.


// ============================================================
// 15. EJEMPLOS PRÁCTICOS
// ============================================================

// A diferencia de los ejemplos anteriores,
// estos SÍ se ejecutan.

Console.WriteLine("Primera línea");
Console.WriteLine("Segunda línea");
Console.WriteLine("Tercera línea");


// ============================================================
// 16. WRITE VS WRITELINE
// ============================================================

Console.Write("Hola ");
Console.Write("George");

Console.WriteLine();

Console.WriteLine("Esta es una nueva línea");


// ============================================================
// 17. COMPROBACIÓN DE CONOCIMIENTOS
// ============================================================

// Console.Write()
// → Imprime sin agregar un salto de línea.
//
// Console.WriteLine()
// → Imprime y agrega un salto de línea.


// ============================================================
// CONCEPTO PRINCIPAL
// ============================================================

// Una instrucción como:
//
// Console.WriteLine("Hello World!");
//
// contiene:
//
// Console      → Clase
// .            → Acceso al miembro
// WriteLine    → Método
// ()           → Invocación
// "Hello World!" → Argumento
// ;            → Fin de instrucción