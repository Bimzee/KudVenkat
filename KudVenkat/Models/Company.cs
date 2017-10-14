using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KudVenkat.Models
{
    public class Company
    {
        private string _name;
        public Company(string name)
        {
            this._name = name;

        }

        public List<tblDepartment> Departments
        {
            get
            {
                KudVenkatMVCDataModel db = new KudVenkatMVCDataModel();
                return db.tblDepartments.ToList();
            }
        }
        public string CompanyName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}