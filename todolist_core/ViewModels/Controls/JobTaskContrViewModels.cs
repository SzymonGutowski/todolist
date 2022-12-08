using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using todolist_core.Helpers;

namespace todolist_core
{
    public class JobTaskContrViewModels : BaseViewModel
    {
        public ObservableCollection<JobTaskViewModels> JobToDoList { get; set; } = new ObservableCollection<JobTaskViewModels>();
        public string NewJobActionTitle { get; set; }

        public string NewJobActionDescription { get; set; }

        public bool IsSelected { get; set; }

        public ICommand AddNewTaskCommand { get; set; }

        public ICommand RemoveTaskCommand { get; set; }

        public JobTaskContrViewModels()
        {
            AddNewTaskCommand = new PrepCommand(AddJobOnToDoList);
            RemoveTaskCommand = new PrepCommand(DeleteJobOnToDoList);
        }

        private void AddJobOnToDoList()
        {
            var addNewAction = new JobTaskViewModels
            {
                Title = NewJobActionTitle,
                Description = NewJobActionDescription,
                Taskdate = DateTime.Now

            };
            JobToDoList.Add(addNewAction);

            NewJobActionTitle = string.Empty;
            NewJobActionDescription = string.Empty;

            OnPropertyChanged(nameof(NewJobActionTitle));
            OnPropertyChanged(nameof(NewJobActionDescription));
        }

        private void DeleteJobOnToDoList()
        {
            var SelectedTasks = JobToDoList.Where(x => x.IsSelected).ToList();

            foreach (var task in SelectedTasks)
            {
                JobToDoList.Remove(task);
            }
        }

        
    }
}
