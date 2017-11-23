    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente("Pepe", "Pepito", "123");
            Paciente paciente2 = new Paciente("Perez", "Juan", "456");
            Paciente paciente3 = new Paciente("Gomez", "Diego", "789");
            Paciente paciente4 = new Paciente("Garcia", "German", "012");
            Paciente paciente5 = new Paciente("PEPE", "PEPITO", "123");

            Sanatorio sanatorio = new Sanatorio(3);

            bool seInterno;
            Paciente pacienteDadoDeAlta;
            seInterno = sanatorio.InternarPaciente(paciente1);
            seInterno = sanatorio.InternarPaciente(paciente5);
            seInterno = sanatorio.InternarPaciente(paciente2);
            seInterno = sanatorio.InternarPaciente(paciente3);

            seInterno = sanatorio.InternarPaciente(paciente4);
            pacienteDadoDeAlta = sanatorio.DarDeAltaPaciente("456");
            seInterno = sanatorio.InternarPaciente(paciente5);
            seInterno = sanatorio.InternarPaciente(new Paciente("otro", "otro", "1"));
            pacienteDadoDeAlta = sanatorio.DarDeAltaPaciente("123");

            Sanatorio.MostrarCamas(sanatorio, eEstado.Disponible);
            Sanatorio.MostrarCamas(sanatorio, eEstado.Ocupado);
        }
    }

