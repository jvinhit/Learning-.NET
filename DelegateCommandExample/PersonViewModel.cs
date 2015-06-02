using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DelegateCommandExample
{
    public class PersonViewModel
    {
        private ObservableCollection<Person> personDataSource;
        private ICommand loadDataCommand;

        public PersonViewModel()
        {
            this.personDataSource = new ObservableCollection<Person>();
            this.loadDataCommand = new DelegateCommand(this.LoadDataAction);
        }

        private void LoadDataAction(object p)
        {
            this.DataSource.Add(new Person() { Name = "Trang♥" });
            this.DataSource.Add(new Person() { Name = "Kate" });
            this.DataSource.Add(new Person() { Name = "Sam" });
        }

        public ICommand LoadDataCommand
        {
            get
            {
                return this.loadDataCommand;
            }
        }

        public ObservableCollection<Person> DataSource
        {
            get
            {
                return this.personDataSource;
            }
        }
    }
}
