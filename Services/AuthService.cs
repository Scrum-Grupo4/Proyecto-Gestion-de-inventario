namespace GestionInventario.Services
{
    public class AuthService
    {
        public bool IsAuthenticated { get; private set; }
        public bool IsAdmin { get; private set; }

        public void Login(string rol)
        {
            IsAuthenticated = true;
            IsAdmin = rol == "Administrador";
        }

        public void Logout()
        {
            IsAuthenticated = false;
            IsAdmin = false;
        }
    }
}
