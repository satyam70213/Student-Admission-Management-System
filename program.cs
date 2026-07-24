using System;

class Student
{
    // Personal Details
    public string StudentName;
    public string FatherName;
    public string MotherName;
    public string Gender;
    public int Age;
    public DateTime DOB;
    public string MobileNo;
    public string Email;
    public string Address;
    public string City;
    public string State;
    public string Pincode;
    public string AadhaarNo;
    public string BloodGroup;

    // Academic Details
    public string Course;
    public string Branch;
    public double Percentage10;
    public double Percentage12;

    // Hostel & Bus
    public bool HostelRequired;
    public string HostelType;
    public bool BusRequired;

    // Fees
    public double AdmissionFee = 5000;
    public double TuitionFee = 50000;
    public double HostelFee = 0;
    public double BusFee = 0;
    public double TotalFee;

    // Admission Number
    public string AdmissionNo;

    // Constructor
    public Student()
    {
        AdmissionNo = "ADM" + DateTime.Now.ToString("yyyyMMddHHmmss");
    }

    // Admission Process
    public void TakeAdmission()
    {
        Console.WriteLine("===============================================");
        Console.WriteLine("        COLLEGE ADMISSION MANAGEMENT");
        Console.WriteLine("===============================================");

        Console.Write("Student Name : ");
        StudentName = Console.ReadLine();

        Console.Write("Father Name : ");
        FatherName = Console.ReadLine();

        Console.Write("Mother Name : ");
        MotherName = Console.ReadLine();

        Console.Write("Gender : ");
        Gender = Console.ReadLine();

        Console.Write("Age : ");
        Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Date of Birth (dd/mm/yyyy) : ");
        DOB = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Mobile Number : ");
        MobileNo = Console.ReadLine();

        Console.Write("Email : ");
        Email = Console.ReadLine();

        Console.Write("Address : ");
        Address = Console.ReadLine();

        Console.Write("City : ");
        City = Console.ReadLine();

        Console.Write("State : ");
        State = Console.ReadLine();

        Console.Write("Pincode : ");
        Pincode = Console.ReadLine();

        Console.Write("Aadhaar Number : ");
        AadhaarNo = Console.ReadLine();

        Console.Write("Blood Group : ");
        BloodGroup = Console.ReadLine();

        Console.Write("10th Percentage : ");
        Percentage10 = Convert.ToDouble(Console.ReadLine());

        Console.Write("12th Percentage : ");
        Percentage12 = Convert.ToDouble(Console.ReadLine());

        // Course Selection
        Console.WriteLine("\nSelect Course");
        Console.WriteLine("1. B.Tech");
        Console.WriteLine("2. BCA");
        Console.WriteLine("3. B.Sc IT");
        Console.WriteLine("4. MCA");
        Console.WriteLine("5. MBA");

        Console.Write("Enter Choice : ");
        int courseChoice = Convert.ToInt32(Console.ReadLine());

        switch (courseChoice)
        {
            case 1:
                Course = "B.Tech";
                break;
            case 2:
                Course = "BCA";
                break;
            case 3:
                Course = "B.Sc IT";
                break;
            case 4:
                Course = "MCA";
                break;
            case 5:
                Course = "MBA";
                break;
            default:
                Course = "Not Selected";
                break;
        }
                // Branch Selection (Only for B.Tech)
        if (Course == "B.Tech")
        {
            Console.WriteLine("\nSelect Branch");
            Console.WriteLine("1. Computer Science & Engineering (CSE)");
            Console.WriteLine("2. Computer Engineering (CE)");
            Console.WriteLine("3. Artificial Intelligence (AI)");
            Console.WriteLine("4. Artificial Intelligence & Machine Learning (AI & ML)");
            Console.WriteLine("5. Cyber Security");

            Console.Write("Enter Choice (1-5): ");
            int branchChoice = Convert.ToInt32(Console.ReadLine());

            switch (branchChoice)
            {
                case 1:
                    Branch = "Computer Science & Engineering (CSE)";
                    break;

                case 2:
                    Branch = "Computer Engineering (CE)";
                    break;

                case 3:
                    Branch = "Artificial Intelligence (AI)";
                    break;

                case 4:
                    Branch = "Artificial Intelligence & Machine Learning (AI & ML)";
                    break;

                case 5:
                    Branch = "Cyber Security";
                    break;

                default:
                    Branch = "Not Selected";
                    break;
            }
        }
        else
        {
            Branch = "Not Applicable";
        }

        // Hostel Details
        Console.Write("\nNeed Hostel? (yes/no): ");
        HostelRequired = Console.ReadLine().ToLower() == "yes";

        if (HostelRequired)
        {
            Console.WriteLine("\nSelect Hostel Type");
            Console.WriteLine("1. AC");
            Console.WriteLine("2. Non-AC");
            Console.Write("Choice : ");
            int hostelChoice = Convert.ToInt32(Console.ReadLine());

            if (hostelChoice == 1)
            {
                Console.WriteLine("\nAC Room Sharing");
                Console.WriteLine("1. 2 Sharing");
                Console.WriteLine("2. 4 Sharing");
                Console.Write("Choice : ");
                int sharing = Convert.ToInt32(Console.ReadLine());

                if (sharing == 1)
                {
                    HostelType = "AC - 2 Sharing";
                    HostelFee = 80000;
                }
                else
                {
                    HostelType = "AC - 4 Sharing";
                    HostelFee = 65000;
                }
            }
            else
            {
                Console.WriteLine("\nNon-AC Room Sharing");
                Console.WriteLine("1. 2 Sharing");
                Console.WriteLine("2. 4 Sharing");
                Console.WriteLine("3. 6 Sharing");
                Console.Write("Choice : ");
                int sharing = Convert.ToInt32(Console.ReadLine());

                switch (sharing)
                {
                    case 1:
                        HostelType = "Non-AC - 2 Sharing";
                        HostelFee = 60000;
                        break;

                    case 2:
                        HostelType = "Non-AC - 4 Sharing";
                        HostelFee = 50000;
                        break;

                    case 3:
                        HostelType = "Non-AC - 6 Sharing";
                        HostelFee = 40000;
                        break;

                    default:
                        HostelType = "Non-AC";
                        HostelFee = 40000;
                        break;
                }
            }
        }

        // Bus Facility
        Console.Write("\nNeed Bus Facility? (yes/no): ");
        BusRequired = Console.ReadLine().ToLower() == "yes";

        if (BusRequired)
        {
            BusFee = 15000;
        }

        // Calculate Total Fee
        TotalFee = AdmissionFee + TuitionFee + HostelFee + BusFee;
    }
        // Display Admission Details
    public void DisplayAdmission()
    {
        Console.WriteLine("\n===============================================");
        Console.WriteLine("            ADMISSION SUCCESSFUL");
        Console.WriteLine("===============================================");

        Console.WriteLine("Admission Number : " + AdmissionNo);
        Console.WriteLine("Student Name     : " + StudentName);
        Console.WriteLine("Father Name      : " + FatherName);
        Console.WriteLine("Mother Name      : " + MotherName);
        Console.WriteLine("Gender           : " + Gender);
        Console.WriteLine("Age              : " + Age);
        Console.WriteLine("Date of Birth    : " + DOB.ToShortDateString());
        Console.WriteLine("Mobile Number    : " + MobileNo);
        Console.WriteLine("Email            : " + Email);
        Console.WriteLine("Address          : " + Address);
        Console.WriteLine("City             : " + City);
        Console.WriteLine("State            : " + State);
        Console.WriteLine("Pincode          : " + Pincode);
        Console.WriteLine("Aadhaar Number   : " + AadhaarNo);
        Console.WriteLine("Blood Group      : " + BloodGroup);

        Console.WriteLine("\n----------- Academic Details -----------");
        Console.WriteLine("Course           : " + Course);
        Console.WriteLine("Branch           : " + Branch);
        Console.WriteLine("10th Percentage  : " + Percentage10 + "%");
        Console.WriteLine("12th Percentage  : " + Percentage12 + "%");

        Console.WriteLine("\n----------- Hostel Details ------------");
        Console.WriteLine("Hostel Required  : " + (HostelRequired ? "Yes" : "No"));
        if (HostelRequired)
        {
            Console.WriteLine("Hostel Type      : " + HostelType);
        }

        Console.WriteLine("\n----------- Bus Details ---------------");
        Console.WriteLine("Bus Facility     : " + (BusRequired ? "Yes" : "No"));

        Console.WriteLine("\n----------- Fee Details ---------------");
        Console.WriteLine("Admission Fee    : ₹" + AdmissionFee);
        Console.WriteLine("Tuition Fee      : ₹" + TuitionFee);
        Console.WriteLine("Hostel Fee       : ₹" + HostelFee);
        Console.WriteLine("Bus Fee          : ₹" + BusFee);
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Total Fee        : ₹" + TotalFee);

        Console.WriteLine("\nCongratulations!");
        Console.WriteLine("Your admission has been completed successfully.");
    }
    }

// Main Program Class
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.TakeAdmission();

        student.DisplayAdmission();

        Console.WriteLine("\n===============================================");
        Console.WriteLine("Thank you for choosing our College.");
        Console.WriteLine("We wish you a bright future!");
        Console.WriteLine("===============================================");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}