    class Paciente
    {
        private string apellido;
        private string nombre;
        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public Paciente(string apellido, string nombre, string dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }

        public static bool operator ==(Paciente paciente1, string dni)
        {
            return (paciente1.dni == dni);
        }
        public static bool operator !=(Paciente paciente1, string dni)
        {
            return !(paciente1 == dni);
        }

        public string InfoPaciente
        {
            get
            {
                return "Apellido: " + apellido + ", Nombre: " + nombre + ", DNI: " + dni;
            }
        }
    }

