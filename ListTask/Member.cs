using System;

namespace ListTask
{

    class Member
    {
        int _id;
        string _name;
        string _role;

        public int ID
        {
            get
            {
                return _id;
            }
             set
             {
                 _id=value;
             }


        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
             {
                 _name=value;
             }



        }

        public string Role
        {
            get
            {
                return _role;
            }

            set
             {
                 _role=value;
             }



        }


    }
}