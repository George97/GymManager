using System;
using GymManager.Entities;

namespace GymManager
{
    public class ActiveAdmin
    {
        private static Administrator _activeAdmin;

        public static void Initialize(Administrator admin)
        {
            if (_activeAdmin != null)
            {
                throw new InvalidOperationException("Current admin has been already active!");
            }

            _activeAdmin = admin;
        }

        public static int Id => _activeAdmin.Id; 

        public static string Name => _activeAdmin.Name;
            
        public static string Surname => _activeAdmin.Surname;
        
        public string Login => _activeAdmin.Login;

        public bool IsActive => _activeAdmin.IsActive;

    }
}
