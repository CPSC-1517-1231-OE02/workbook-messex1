using HockeyData;
using Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hockey.Data
{
    /// <summary>
    /// An instance of this class will hold data about a hockey player
    /// </summary>

    public class HockeyPlayer
    {
        //Data fields (info about the name, description, etc)
        //Naming to fields is done with a prefixed _ underscore

        private string _birthPlace; //? marked here allows 'null' or string
        private string _firstName;
        private string _lastName;
        private int _heightInInches;
        private int _weightInPounds;
        private DateOnly _dateOfBirth;

                 /*private Position _position;*/ //leftWing, RightWing, Center, Defense, Goalie

                    //create a shot enum and declare a _shot private field here
        
                /*  private Shot _shot;*/ //left, right


        //properties
        public string BirthPlace
        {
            get
            {
                return _birthPlace; //expression-bodied accessor
            }
            set
            {
                //paraments in a set are associated to 'Value'

                if (Utilities.IsNugllOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth Place cannot be null or empty");
                }

                _birthPlace = value;
                
            }
        }


        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (Utilities.IsNugllOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName Cannot be Null or Whitespace")
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (Utilities.IsNugllOrWhiteSpace(value))
                {
                    throw new ArgumentException("LastName Cannot be Null or Whitespace")
                }
                _firstName = value;
            }
        }
        public int HeightInInches
        {
            get
            {
                return _heightInInches; 
            }
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive. ");
                }

                _heightInInches = value;

            }
        }
        
        public int WeightInPounds
        {
            get
            {
                return _weightInPounds;
            }

            set
            {
                if (value <= 0)
                {
                    return;
                }

                else { }
            }
        }
        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                //*is9-13 class exercise: validate this part
                //cant be in the future

                if (Utilities.IsInTheFuture(value)) ///*(value > DateOnly.FromDateTime(DateTime.Now))*/ 
                {
                    _dateOfBirth = value;

                }
                else
                ///*(value > DateOnly.FromDateTime(DateTime.Now))*/ 
                {
                    throw new ArgumentException("Date of birth cannot be in the future. ");

                }
            }
        }

        public Position Position { get; set; }

        public Shot Shot { get; set; }

        //Default constructor
        public HockeyPlayer()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthPlace = string.Empty;
            _dateOfBirth = new DateOnly();
            _heightInInches = 0;
            _weightInPounds = 0;
            Position = Position.Center;

            //dont need to include these
            //_position = new Position();
            //_shot = new Shot();
        } 

//do we specify a return type? no its already predefiened/ filled in based on what you named the class


        //public void SetPosition(string value) 
        //{
        //    value = value.ToUpper();
        //    if (value =="LEFT WING" || ...)
        //    _position = value; 
        //}


        //greedy constructor/  method overloading
        public HockeyPlayer(string FirstName firstName, string lastName, string birthPlace, DateOnly birthDate, int weightInPounds, int heightInInches, Position position = Position.Center, Shot shot = Shot.Left)

        {
            //validate the values in the brackets
            //TODO: implement and use the remaining properties
            FirstName = firstName;
            BirthPlace = birthPlace;
            HeightInInches = heightInInches;
            DateOfBirth = birthDate;
            Shot = shot;
            Position = position;

        }

    }
}

