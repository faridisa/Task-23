using System;
using System.Collections.Generic;
using System.Text;

namespace Task_23.Employess
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employe> Employes { get; set; } = new List<Employe>();


        public void AddEmployee(Employe employe) 
        {
            Employes.Add(employe);
        }
        public Employe GetEmployeById(int id) => Employes.FirstOrDefault(e => e.Id == id);

        public void RemoveEmployee(int id)
        {
            Employe employe = GetEmployeById(id);
            if (employe != null)
            {
                Employes.Remove(employe);
            }
        }
    }
}
