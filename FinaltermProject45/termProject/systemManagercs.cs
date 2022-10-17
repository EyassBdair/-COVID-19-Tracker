using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termProject
{
   
    public enum STATUS
    {
        OPEN,
        CLOSE


    }
    public enum VACCINE
    {
        Fizer,
        Sinopharm,
        jj,
        Moderna,
        Astrazeneca,
        NULL

    }

    // ---------------------------- class person ***************************
    public class Person
    {
        private string ShotOneType;
        public string _ShotOneType
        {
            set
            {
                ShotOneType = value;
            }
            get
            {
                return ShotOneType;
            }
        }
        private string ShotSeondType;
        public string _ShotSeondType
        {
            set
            {
                ShotSeondType = value;
            }
            get
            {
                return ShotSeondType;
            }
        }
        private bool Takeshot1;
        public bool _Takeshot1
        {
            set
            {
                Takeshot1 = value;
            }
            get
            {
                return Takeshot1;
            }
        }
        private bool Takeshot2;
        public bool _Takeshot2
        {
            set
            {
                Takeshot2 = value;
            }
            get
            {
                return Takeshot2;
            }
        }

        
        public static List<Person> PersonDone = new List<Person>();  //**
        public static List<Person> PersonNotDone = new List<Person>(); //**
        /*private Center center2;
        public Center _center2
        {
            get { return _center2; }
            set { _center2 = value; }
        }*/
        string centerNameShot1;

        public string _centerNameShot1
        {
            set
            {
                centerNameShot1 = value;
            }
            get
            {
                return centerNameShot1;
            }
        }

        string centerNameShot2;

        public string _centerNameShot2
        {
            set
            {
                centerNameShot2 = value;
            }
            get
            {
                return centerNameShot2;
            }
        }


        private int SSN;
        public  int _SSN
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Sorry, the SSN number must be positive ");
                else
                {
                    this.SSN = value;
                }
            }
            get
            {
                return SSN;
            }
        }
        public string Fname;
        public string _Fname
        {
            get
            {
                return Fname;
            }
            set
            {
                Fname = value;
            }
        }
        private string Lname;
        public string _Lname
        {
            get
            {
                return Lname;
            }

            set
            {
                Lname = value;
            }

        }
        private DateTime DoB;
        public DateTime _DoB
        {
            get
            {
                return DoB;
            }
            set
            {
                if (DateTime.Now < value)
                {
                    Console.WriteLine("Sorry future date");
                }
                else this.DoB = value;
            }

        }
        public DateTime[] InfectionDates;
        private int CountInfection;
        private VaccineShot Shot1;
        private VaccineShot Shot2;
        


        public Person(int ssn, string fname, string lname, DateTime dob,string centerNameShot1,string centerNameShot2,bool Takeshot1,bool Takeshot2,string ShotOneType, string ShotSeondType)
        {

            this._SSN = ssn;
            this.Fname = fname;
            this.Lname = lname;
            this._DoB = dob;
            this.InfectionDates = new DateTime[100];
            CountInfection = 0;
            this.centerNameShot1 = centerNameShot1;
            this.centerNameShot2 = centerNameShot2;
            this.Takeshot1 = Takeshot1;
            this.Takeshot2 = Takeshot2;
            this.ShotOneType = ShotOneType;
            this.ShotSeondType = ShotSeondType;

        }
        public override string ToString()
        {

            return   ($"SSN = {SSN}  Fname = {Fname}  Lname = {Lname}  center Name for Shot1 ={centerNameShot1} center Name for Shot2 = {centerNameShot2}");


        }
        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            Person that = obj as Person;
            if (that != null)
                return (this.SSN.Equals(that.SSN) && this.Fname.Equals(that.Fname) && this.Lname.Equals(that.Lname) && this.DoB.Equals(that.DoB) && this.InfectionDates.Equals(that.InfectionDates)
                    && this.Shot1.Equals(that.Shot1) && this.Shot2.Equals(that.Shot2));
            else
                return false;
        }

        public void AddInfection(DateTime D)
        {
            if (D <= DateTime.Now)

            {

                InfectionDates[CountInfection] = D;

                CountInfection++;

            }
        }
        public bool TakeShot1(VaccineShot S)
        {
            STATUS e = STATUS.OPEN;
            if (true)
            {
                if (Age() > 12)
                {
                    if (DateTime.Now >= S.ShotDate)
                    {
                        this.Shot1 = S;
                        return true;
                    }
                    else return false;
                }
                else
                {
                    Console.WriteLine("  Sorry:(  , the person who wants to be vaccinated must be over 12 years old");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("sorry  , the Center is close");
                return false;
            }
        }
        public bool TakeShot2(VaccineShot S)
        {
            if (DateTime.Now >= S.ShotDate)
            {
                this.Shot2 = S;
                return true;
            }
            else
            {
                return false;
            }

        }
        public double Age()
        {

            double age = 0;
            age = DateTime.Now.Subtract(DoB).Days;
            age = age / 365;
            return age;

        }
        public bool Islmmune()
        {
            if (Shot1 != null && Shot2 != null)
            {
               
                return true;
            }
            for (int i = 0; i < CountInfection; i++)

            {

                if ((DateTime.Today - InfectionDates[i]).TotalDays >= 14)

                {

                    return true;

                }

            }

            return false;


        }
    }
    // ------------------------------- class VaccineShot *******************
    public class VaccineShot
    {
        static public int countofVaccineShot = 0;
        public DateTime ShotDate;
        private VACCINE VaccineType;
        private int LotNumber;
        private int _LotNumber
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Sorry, the LotNumber number must be positive ");
                else
                {
                    this.LotNumber = value;
                }
            }
            get
            {
                return _LotNumber;
            }
        }
        public Center VacCenter;
        private string NurseName;

        public override string ToString()

        {
            if (this != null)
            {
                return ($"ShotDate = {ShotDate}  VaccineType = {VaccineType}  LotNumber = {LotNumber}  VacCenter = {VacCenter}  NurseName = {NurseName}");
            }
            else return ("non finish the shot");

        }
        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            VaccineShot that = obj as VaccineShot;
            if (that != null)
                return (this.ShotDate.Equals(that.ShotDate) && this.VaccineType.Equals(that.VaccineType)
                    && this.LotNumber.Equals(that.LotNumber) && this.VacCenter.Equals(that.VacCenter) && this.NurseName.Equals(that.NurseName));
            else
                return false;
        }

        public VaccineShot(DateTime ShotDate, VACCINE Type, int Lot,  String Nurse)
        {
            countofVaccineShot++;
            this.ShotDate = ShotDate;
            this.VaccineType = Type;
            this._LotNumber = Lot;
            this.NurseName = Nurse;

        }
        public VACCINE GetVaccineType()
        {

            return this.VaccineType;
        }
        //**********Raneem*********
        public static int GetCount()
        {
            return countofVaccineShot;
        }
    }
    // ------------------------ class ImportedVaccine ***********************
    public class ImportedVaccine

    {
        private int LotNumber;
        private int _LotNumber
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Sorry, the LotNumber number must be positive ");
                else
                {
                    this.LotNumber = value;
                }
            }
            get
            {
                return _LotNumber;
            }
        }
        private VACCINE VaccineType;
        private string Country;



        private int ImportedDoses;
        private int _ImportedDoses
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Sorry, the ImportedDoses number must be positive ");
                else
                {
                    this.ImportedDoses = value;
                }
            }
            get
            {
                return _ImportedDoses;
            }
        }
        private int UsedDoses;
        public int _UsedDoses
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Sorry, the UsedDoses number must be positive ");
                else
                {
                    this.UsedDoses = value;
                }
            }
            get
            {
                return _UsedDoses;
            }
        }
        public ImportedVaccine(int Lot, VACCINE type, string cntry, int Idate, int Doses)
        {

            this._LotNumber = Lot;
            this.VaccineType = type;
            this.Country = cntry;
            this._ImportedDoses = Idate;
            this._UsedDoses = Doses;

        }
        public override string ToString()
        {
            return ($"LotNumber = {LotNumber}  VaccineType = {VaccineType}  Country = {Country}  ImportedDoses = {ImportedDoses}  UsedDoses = {UsedDoses} ");
        }
        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            ImportedVaccine that = obj as ImportedVaccine;
            if (that != null)
                return (this.LotNumber.Equals(that.LotNumber) && this.VaccineType.Equals(that.VaccineType)
                    && this.Country.Equals(that.Country) && this.ImportedDoses.Equals(that.ImportedDoses) && this.UsedDoses.Equals(that.UsedDoses));
            else
                return false;

        }//*******Raneem**********
        public int GetLotNum()
        {
            return this.LotNumber;
        }
        public VACCINE GetVACCINE()
        {
            return VaccineType;
        }
        public static int GetNumOfType(VACCINE v)

        {
            int num = 0;
            for (int i = 0; i < SystemManager.ImportedVaccines.Count; i++)
                if (v == SystemManager.ImportedVaccines[i].VaccineType)
                    num++;
            return num;
        }
        public int ImRemaining()
        { //*****Raneem*********
            return SystemManager.ImportedVaccines.Count - VaccineShot.GetCount();
        }
        /*  public int Remaining()
          {
              return ImportedDoses - UsedDoses;
          }*/

    }
    // ----------------------class center ******************
    public class Center

    {
       
        public Center(string name )
        {
            this.Name = name;
        }
        private int ID;
         public int _ID //***
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Sorry, the ID number must be positive ");
                else
                {
                    this.ID = value;
                }
            }
            get
            {
                return ID;
            }

        }

        public string Name { get; set; }//mahmoud
        //public string getName { return Name; }
        private string AdderssLine1;
        private string AdderssLine2;
        private string Phone;
        private string _Phone
        {
            set
            {
                if (value == null || value.Length < 10 || value.Length == 0 || value.Length > 10)
                {
                    Console.WriteLine("Sorry, the phone number should be ten digits ");
                    
                }
                else
                {
                    this.Phone = value;
                }
            }
            get
            {
                return Phone;
            }

        }

        public STATUS status;

        public Center(int ID, string Name, String addl1, String addl2, string Phone)
        {
            this._ID = ID;
            this.Name = Name;
            this._Phone = Phone;
            this.AdderssLine1 = addl1;
            this.AdderssLine2 = addl2;


        }
        public bool UpdatePhone(string Phone)
        {
            if (Phone.Length < 10 && Phone == null)
            {
                Console.WriteLine("*****----- Input error, try again ");
                return false;
            }
            string p = this.Phone;
            if (p != Phone)
                return true;
            else return false;

        }
        public bool UpdateAddress(string addl1, String addl2)
        {
            string a1 = this.AdderssLine1;
            string a2 = this.AdderssLine2;

            this.AdderssLine1 = addl1;
            this.AdderssLine2 = addl2;
            if (a1 != addl1 && a2 != addl2)
                return true;
            else return false;
        }
        public override string ToString()
        {
            return $"(ID = {ID} Name = {Name} AdderssLine1 = {AdderssLine1 }  AdderssLine2 = {AdderssLine2} Phone = {Phone} STATUS = {status})";
        }
        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            Center that = obj as Center;
            if (that != null)
                return (this.ID.Equals(that.ID) && this.Name.Equals(that.Name) && this.AdderssLine1.Equals(that.AdderssLine1)
                    && this.AdderssLine2.Equals(that.AdderssLine2) && this.status.Equals(that.status));
            else
                return false;
        }
        public bool UpdateStatus(STATUS s)
        {
            if (s == STATUS.CLOSE)
            {
                this.status = STATUS.OPEN;
                return true;
            }
            else
            {
                this.status = STATUS.CLOSE;
                return true;
            }


        }

    }

    public static class SystemManager
    {
        public static List<Person> Persons = new List<Person>();
        public static List<ImportedVaccine> ImportedVaccines = new List<ImportedVaccine>();
   public static List<Center> Centers = new List<Center>();

        public static List<VaccineShot> Vaccines = new List<VaccineShot>();

        public static bool AddPersone(Person p)
        {
            int i = Persons.Count;
            Persons.Add(p);
            if (Persons.Count > i)
                return true;
            else
                return false;


        }
        public static bool AddImportedVaccine(ImportedVaccine a)
        {
            int i = ImportedVaccines.Count;
            ImportedVaccines.Add(a);
            if (ImportedVaccines.Count > i)
                return true;
            else
                return false;

        }
        public static bool AddCenter(Center c)
        {
            int i = Centers.Count;
            Centers.Add(c);
            if (Centers.Count > i)
                return true;
            else
                return false;

        }
        public static bool VaccinePersoneShot1(Person p, VaccineShot v)
        {

            return p.TakeShot1(v);
        }
        public static bool VaccinePersoneShot2(Person p, VaccineShot v)
        {
            return p.TakeShot2(v);
        }
        public static bool CloseCenter(Center c)
        {
            STATUS s = STATUS.CLOSE;
            if (c.status == s)
                return true;
            else return false;
        }
        public static bool OpenCenter(Center c)
        {
            STATUS s = STATUS.OPEN;

            if (c.status == s)
                return true;
            else return false;
            //return c.UpdateStatus(c.status);
        }
        //**********Raneem**********

        public static int Remaining()
        {
            for (int i = 0; i < ImportedVaccines.Count; i++)
                return ImportedVaccines[i].ImRemaining();
            return 0;
        }



    }
}

