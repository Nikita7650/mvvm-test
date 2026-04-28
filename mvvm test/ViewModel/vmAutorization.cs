using mvvm_test.Class;
using mvvm_test.Model;
using mvvm_test.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace mvvm_test.ViewModel
{
    public class vmAutorization
    {
        private КалиевПрактикаEntities
            db = new КалиевПрактикаEntities();

        private IList<Пользователи> _listUser;

        public IList<Пользователи> ListUser => _listUser ?? (_listUser = new ObservableCollection<Пользователи>());

        private Пользователи _selectedUser;

        public Пользователи SelectedUser
        {
            get => _selectedUser ?? (_selectedUser = new Пользователи());
            set => _selectedUser = value;
        }

        public vmAutorization()
        {
            ListUser.Clear();

            foreach (var item in db.Пользователи.ToList())
            {
                ListUser.Add(item);
            }
        }

        private ICommand _command;

        public ICommand LoginCommand => _command ?? (_command = new CommandAction(Login));


        void Login()
        {
            var users = db.Пользователи.ToList();

            var user = users
                .Where(w => w.Логин == SelectedUser.Логин &&
                    w.Пароль == SelectedUser.Пароль)
            .ToList()
            .LastOrDefault();

            if (user != null)
            {
                Autorization autorization = new Autorization();
                autorization.Close();

                ViewTovar viewTovar = new ViewTovar(null);
                viewTovar.Show();

            }

        }

        private ICommand GostCommand;
        public ICommand GostLogin => GostCommand ?? (GostCommand = new CommandAction(LoginGost));
        void LoginGost()
        {
            Autorization autorization = new Autorization();
            autorization.Close();


            ViewGuest viewGuest = new ViewGuest();
            viewGuest.Show();
        }


    }

}

