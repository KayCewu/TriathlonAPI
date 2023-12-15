using CodeCollabra.Domain;
using CodeCollabra.Infrastructure.DatabaseContext;
using Microsoft.IdentityModel.Tokens;

namespace CodeCollabra.API.Services
{
    public class UserService : IUserService
    {
        private bool disposedValue;
        private readonly CodeCollabraDBContext _context;
        public UserService(CodeCollabraDBContext con)
        {
                _context= con;
        }

        public IEnumerable<User> GetUsers()
        {
            var Users= _context.Users.ToList();
            if (!Users.IsNullOrEmpty())
            {
                return Users.ToList();
            }
            else
            {
                return null;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UserService()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
