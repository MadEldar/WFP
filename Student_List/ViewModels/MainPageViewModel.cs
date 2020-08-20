using Student_List.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_List.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Student> StudentList { get; set; } = new ObservableCollection<Student>();
        public MainPageViewModel()
        {
            for (int i = 0; i < 50; i++)
            {
                var random = new Random();
                var student = new Student() {
                    Id = i,
                    Name = $"Student {i}",
                    GPA = double.Parse(String.Format("{0:N2}", random.NextDouble() * 4))
                };
                StudentList.Add(student);
            }
        }
    }
}
