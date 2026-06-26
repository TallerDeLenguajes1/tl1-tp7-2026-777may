namespace Empleados
{
    class Empleado
    {
        string nombre;
        string apellido;
        DateOnly fechaDeNacimiento;
        char estadoCivil;
        DateOnly fechaIngresoEmpresa;
        decimal sueldoBasico;
        Cargos cargo;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public DateOnly FechaDeNacimiento { get => fechaDeNacimiento; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateOnly FechaIngresoEmpresa { get => fechaIngresoEmpresa; }
        public decimal SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        public Empleado(string nombre, string apellido, DateOnly fechaNac, char estadoCivil, DateOnly fechaIngreso, decimal sueldo, Cargos cargo)
    {
        // Guardamos los parámetros que entran en nuestras variables privadas
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaDeNacimiento = fechaNac;
        this.estadoCivil = estadoCivil;
        this.fechaIngresoEmpresa = fechaIngreso;
        this.sueldoBasico = sueldo;
        this.cargo = cargo;
    }+
// En C#, cuando un método no recibe parámetros y solo calcula un dato interno (como Edad() o Antiguedad()), se acostumbra transformarlo en una Propiedad de solo lectura.
        public int Antiguedad => AniosCumplidos(fechaIngresoEmpresa);
        public int Edad => AniosCumplidos(fechaDeNacimiento);
        public int EdadParaJubilarse => 65-Edad;
        private int AniosCumplidos(DateOnly anio)
        {
            DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);
            int anios = hoy.Year - anio.Year;
            
            if (hoy < anio.AddYears(anios))
            {
                anios--;
            }
            return anios;
        }
        public decimal Salario()
        {
            decimal adicional;
            if(Antiguedad < 20)
            {
                adicional = sueldoBasico/100m*Antiguedad;
            }
            else
            {
                adicional = sueldoBasico/4m;
            }
            if(cargo == Cargos.Ingeniero ||  cargo == Cargos.Especialista)
            {
                adicional += adicional/2m;
            }
            if(estadoCivil == 'C')
            {
                adicional += 150000m;
            }
            
            return SueldoBasico + adicional;
        }
    }
}