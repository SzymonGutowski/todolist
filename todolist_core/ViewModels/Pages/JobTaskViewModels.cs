using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todolist_core.Helpers;

namespace todolist_core
{
    public class JobTaskViewModels : BaseViewModel
    {
        internal bool IsSelected;

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Taskdate { get; set; }

     
    }
}
