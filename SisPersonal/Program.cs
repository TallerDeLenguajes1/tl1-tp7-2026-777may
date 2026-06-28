using Empleados;
// Console.OutputEncoding = System.Text.Encoding.UTF8; //PARA TENER LETRAS CON ACENTOS
Empleado[] tresEmpleados = new Empleado[3];
tresEmpleados[0] = new Empleado("Juan", "Pérez", DateOnly.Parse("1985-05-15"), 'C', DateOnly.Parse("2011-06-26"), 650000m, Cargos.Ingeniero);
tresEmpleados[1] = new Empleado("Ana", "Juarez", DateOnly.Parse("07/06/1995"), 'S', DateOnly.Parse("10/4/2020"), 600000m, Cargos.Auxiliar);
tresEmpleados[2] = new Empleado("Mengna", "Go", DateOnly.Parse("03/10/1990"), 'S', DateOnly.Parse("10/4/2020"), 700000m, Cargos.Investigador);

// Empleado[] tresEmpleados =
// [
//     new Empleado { Nombre = "Juan", Cargo = Cargos.Ingeniero, ... },
//     new Empleado { Nombre = "Ana",  Cargo = Cargos.Auxiliar, ... },
//     new Empleado { Nombre = "Luis", Cargo = Cargos.Investigador, ... }
// ];

// Empleado[] tresEmpleados = new Empleado[]
// {
//     new Empleado { Nombre = "Juan", Cargo = Cargos.Ingeniero, ... },
//     new Empleado { Nombre = "Ana",  Cargo = Cargos.Auxiliar, ... },
//     new Empleado { Nombre = "Luis", Cargo = Cargos.Investigador, ... }
// };


decimal montoTotal = 0;
Empleado proximoJubilarse = tresEmpleados[0];
foreach (var emple in tresEmpleados){
    montoTotal += emple.Salario();
    if (emple.EdadParaJubilarse < proximoJubilarse.EdadParaJubilarse)
    {
        proximoJubilarse = emple;
    }
} 

Console.WriteLine($"""

    =========== En total se paga: {montoTotal,8:G} ===========
    =========== EMPLEADO MÁS PRÓXIMO A JUBILARSE ===========
    Nombre Completo: {proximoJubilarse.Apellido}, {proximoJubilarse.Nombre}
    Fecha de Nacimiento: {proximoJubilarse.FechaDeNacimiento:dd/MM/yyyy}
    Estado Civil: {proximoJubilarse.EstadoCivil}
    Edad Actual: {proximoJubilarse.Edad} años
    Ingreso a la empresa: {proximoJubilarse.FechaIngresoEmpresa:dd/MM/yyyy}
    Antigüedad: {proximoJubilarse.Antiguedad} años
    Cargo: {proximoJubilarse.Cargo}
    Sueldo base: {proximoJubilarse.SueldoBasico:N2}
    Años restantes para jubilarse: {proximoJubilarse.EdadParaJubilarse} años
    ----------------------------------------------------------
    Salario Correspondiente: ${proximoJubilarse.Salario():N4}
    ==========================================================
    """);


    // Operacion op;
    // op = Operacion.Division;
    // switch (op)
    // {
    //     case Operacion.Suma:
    //         Console.WriteLine("Sumando...");
    //         break;
    //     case Operacion.Resta:
    //         Console.WriteLine("Restando...");
    //         break;
    // }