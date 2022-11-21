using System;
using System.Security.AccessControl;
using System.ComponentModel.DataAnotions;
namespace VuLinh_BTH2_3-10
{
    public class Employee    
    {
        [Key]
        public string EmpID{get;set;}
        public string EmpName{get; set;}
        public string Address{get; set;}
    }
}