using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// Author: Kviatkovskyi Andrii

namespace KviatkovskyiLab1
{
    internal class BirthdayViewModel
    {

        private BirthdayModel _birthday;

        public BirthdayViewModel()
        {
            _birthday = new BirthdayModel();
        }

        public DateTime Birthdate
        {
            get { return _birthday != null ? _birthday.Birthdate : DateTime.Now; }
            set
            {
                if (_birthday == null)
                {
                    _birthday = new BirthdayModel();
                }

                _birthday.Birthdate = value;
            }
        }

        public int Age
        {
            get { return _birthday != null ? _birthday.Age() : 0; }
        }

        public bool IsBirthday
        {
            get { return _birthday != null ? _birthday.IsBirthday() : false; }
        }

        public string ZodiacWestern
        {
            get { return _birthday != null ? _birthday.ZodiacWestern() : string.Empty; }
        }

        public string ZodiacChinese
        {
            get { return _birthday != null ? _birthday.ZodiacChinese() : string.Empty; }
        }
    }
}
