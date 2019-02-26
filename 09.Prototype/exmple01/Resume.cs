using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
   public class Resume:ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;
        //private string _timeArea;
        //private string _company;

        private WorkExperience _workExperience;

        public Resume(string name)
        {
            this._name = name;
            _workExperience = new WorkExperience();
        }

        private Resume(WorkExperience experience)
        {
            _workExperience = (WorkExperience)experience.Clone();
        }

        public void SetPersonalInfo(string sex,string age)
        {
            this._sex = sex;
            this._age = age;
        }

        public void SetWorkExperience(string time,string company)
        {
            _workExperience.WorkDate = time;
            _workExperience.Company = company;
        }
        public void Display()
        {
            Console.WriteLine("{0} {1} {2}",_name,_sex,_age);
            Console.WriteLine("Working Experience：{0} {1}", _workExperience.WorkDate, _workExperience.Company);
        }

        public object Clone()
        {
            Resume resume = new Resume(this._workExperience);
            resume._name = this._name;
            resume._sex = this._sex;
            resume._age = this._age;
            //return (Resume)this.MemberwiseClone();
            return resume;
        }

        //public Resume Clone()
        //{
        //    return (Resume)this.MemberwiseClone();
        //}


    }
}
