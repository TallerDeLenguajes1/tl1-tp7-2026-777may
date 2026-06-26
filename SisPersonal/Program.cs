using Empleados;
Empleado[] tresEmpleados = new Empleado[3];
tresEmpleados[0] = new Empleado("Juan", "Pérez", DateOnly.Parse("1985-05-15"), 'C', DateOnly.Parse("2011-06-26"), 650000m, Cargos.Ingeniero);
tresEmpleados[1] = new Empleado("Ana", "Juarez", DateOnly.Parse("07/06/1995"), 'S', DateOnly.Parse("10/4/2020"), 600000m, Cargos.Auxiliar);
tresEmpleados[2] = new Empleado("Mengna", "Go", DateOnly.Parse("03/10/1990"), 'S', DateOnly.Parse("10/4/2020"), 700000m, Cargos.Investigador);

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
    =========== EMPLEADO MÁS PRÓXIMO A JUBILARSE ===========
    Nombre Completo: {proximoJubilarse.Apellido}, {proximoJubilarse.Nombre}
    Fecha de Nacimiento: {proximoJubilarse.FechaDeNacimiento.ToString("dd/MM/yyyy")}
    Estado Civil: {proximoJubilarse.EstadoCivil}
    Edad Actual: {proximoJubilarse.Edad} años
    Años restantes para jubilarse: {proximoJubilarse.EdadParaJubilarse} años
    ----------------------------------------------------------
    Salario Correspondiente: ${proximoJubilarse.Salario().ToString("N2")}
    ==========================================================
    """);