namespace PPAI.Clases
{
    public class PersonalCientifico
    {
        private string nombre { get; set; }
        private string apellido { get; set; }   
        private string correoElectronicoInstitucional { get; set; }
        private string correoElectronicoPersonal { get; set; }
        private long legajo { get; set; }
        private long numeroDocumento { get; set; }
        private string telefonoCelular { get; set; }
        private Usuario usuario { get; set; }

        public bool esTuUsuario(Usuario _usuario)
        {
            return usuario.Equals(_usuario);
        }

        public string getCorreoElectronicoInstitucional()
        {
            return correoElectronicoInstitucional;
        }

    }
}
